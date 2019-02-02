using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Client.AdminService;
using Client.CustomerService;

namespace Client
{
	public class DL
	{
		public AdminServiceClient adminProxy;
		public CustomerServiceClient customerProxy;
		public DL()
		{
			adminProxy = new AdminServiceClient();
			customerProxy = new CustomerServiceClient();
		}

		public void AddBus()
		{
			Bus bus = new Bus
			{
				Capacity = 47,
				Model = "Lexus",
				RegNumber = "АР7654ВЕ"
			};

			this.adminProxy.AddBus(bus);
		}
	}
}
