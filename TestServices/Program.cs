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
			var cs = new CustomerService.CustomerServiceClient();
			Console.WriteLine(cs.CustomerDoWork());

			var aser = new AdminServiceClient.AdminServiceClient();
			Console.WriteLine(aser.DoWork());

			//var bus = aser.SecondOperation();
			//Console.WriteLine(bus.Capacity);

			//Bus bus = new Bus()
			//{
			//	Capacity = 100,
			//	Model = "rrrrrrrrrrr"
			//};
			//aser.AddBus(bus);

			aser.AddBus();




		}
	}
}
