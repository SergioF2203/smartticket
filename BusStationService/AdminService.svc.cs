using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BusStationService.Lib;
using System.Data.Entity;

namespace BusStationService
{
	public class AdminService : IAdminService
	{
		public string DoWork()
		{
			return "All work in Admin service!";
		}

		public Bus SecondOperation()
		{
			return new Bus
			{
				Capacity = 34,
				Model = "Jiguli",
				RegNumber = "FH87458745",
			};
		}

		public void AddBus(Bus bus)
		{
			//var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
			using (DB db = new DB())
			{
				//Bus bus = new Bus()
				//{
				//	Capacity = 100,
				//	Model = "rrrrrrrrrrr"
				//};

				db.Buses.Add(bus);

				db.SaveChanges();

				Console.WriteLine("Data pushed to db");

				//db.Buses.Add(bus);

				//db.SaveChanges();

				//Console.WriteLine("Data pushed to db");
			}
		}
	}
}
