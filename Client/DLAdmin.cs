using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Client.AdminService;


namespace Client
{
	public class DLAdmin
	{
		public AdminServiceClient adminProxy;
		public DLAdmin()
		{
			adminProxy = new AdminServiceClient();
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
