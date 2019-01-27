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
			var admin  = new AdminService.AdminServiceClient();

			Console.WriteLine(admin.DoWork());

		}
	}
}
