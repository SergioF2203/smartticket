using System;
using System.ServiceModel;
using System.Threading;

namespace Host
{
	class Program
	{
		static void Main(string[] args)
		{
			Init();
			Process();
		}

		static void Init()
		{
			startAdminService();
			startCustomerService();
		}

		static void Process()
		{
			bool loop = true;

			while (loop)
			{
				if (Console.ReadKey().Key == ConsoleKey.Enter)
				{
					string command = GetCommand();

					switch (command)
					{
						case "close AdminService":
							AdminHost.StopService();
							ShowMessage("AdminService is closed");
							break;
						case "close CustomerService":
							CustomerHost.StopService();
							ShowMessage("CustomerService is closed");
							break;
						case "open AdminService":
							if (AdminHost.AdminServiceHost.State == CommunicationState.Closed)
								startAdminService();
							else
								ShowMessage("AdminService is already opened");
							break;
						case "open CustomerService":
							if (CustomerHost.CustomerServiceHost.State == CommunicationState.Closed)
								startCustomerService();
							else
								ShowMessage("CustomerService is already opened");
							break;
						case "restart AdminService":
							AdminHost.StopService();
							startAdminService();
							ShowMessage("AdminService is restarted");
							break;
						case "restart CustomerService":
							CustomerHost.StopService();
							startCustomerService();
							ShowMessage("CustomerService is restarted");
							break;
						case "state":
							string msg = $"AdminService state\n\t\t{AdminHost.AdminServiceHost.State}";
							msg += AdminHost.AdminServiceHost.State == CommunicationState.Opened ? $"\n\t\t{AdminHost.AdminServiceHost.BaseAddresses[0]}" : "";
							msg += $"\n\tCustomerService state\n\t\t{CustomerHost.CustomerServiceHost.State}";
							msg += CustomerHost.CustomerServiceHost.State == CommunicationState.Opened ? $"\n\t\t{CustomerHost.CustomerServiceHost.BaseAddresses[0]}" : "";

							ShowMessage(msg);
							break;
						case "quit":
							AdminHost.StopService();
							CustomerHost.StopService();
							ShowMessage("All services are closed");
							loop = false;
							break;
						case "help":
							ShowMessage("Use commands:" +
										"\n\tclose <service name>: close service" +
										"\n\topen <service name>: open service" +
										"\n\trestart <service name>: restart service" +
										"\n\tstate: show states of services" +
										"\n\tquit: stop all services and exit");
							break;
						default:
							ShowMessage("Unkown command...");
							break;
					}
				}
			}

			Thread.Sleep(1000);
		}

		static void ShowMessage(string msg)
		{
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.Write($"HOST >> {msg}\n");
			Console.ForegroundColor = ConsoleColor.White;
		}

		static string GetCommand()
		{
			Console.Write("\ncommand >> ");
			string command = Console.ReadLine();
			return command;
		}

		static void startAdminService()
		{
			AdminHost.StartService();
			ShowMessage($"Admin Service opened in {AdminHost.AdminServiceHost.BaseAddresses[0]}");
		}

		static void startCustomerService()
		{
			CustomerHost.StartService();
			ShowMessage($"Customer Service opened in {CustomerHost.CustomerServiceHost.BaseAddresses[0]}");
		}
	}
}
