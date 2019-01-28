using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Host
{
	class Program
	{
		static void Main(string[] args)
		{
			AdminHost.StartService();
			Console.WriteLine("Admin Service running. Press return to exit..");

			CustomerHost.StartService();
			Console.WriteLine("Customer Service running. Press return to exit..");

			Console.WriteLine("Press return to exit..");

			Console.ReadLine();
			AdminHost.StopService();
			CustomerHost.StopService();

			Console.WriteLine("Services stopped.");
		}
	}
}
