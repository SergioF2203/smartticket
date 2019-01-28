using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestServices
{
	class Program
	{
		static void Main(string[] args)
		{
			var cs = new CustomerService.CustomerServiceClient();
			Console.WriteLine(cs.CustomerDoWork());

			var aser = new AdminServiceClient.AdminServiceClient();
			Console.WriteLine(aser.DoWork());
		}
	}
}
