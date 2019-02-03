using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestServices.AdminServiceClient;

namespace TestServices
{
	class Program
	{
		static void Main(string[] args)
		{
			var customer = new CustomerService.CustomerServiceClient();
			var admin = new AdminServiceClient.AdminServiceClient();

			var res = customer.GetDirections();
			foreach (var d in res)
			{
				Console.WriteLine(d.Coordinates);
			}


		}
	}
}
