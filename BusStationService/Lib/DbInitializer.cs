using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BusStationService.Lib
{
	public class DbInitializer : DropCreateDatabaseAlways<DB>
	{
		protected override void Seed(DB db)
		{
			db.Buses.AddRange(new List<Bus>
				{
					new Bus {RegNumber = "АР6012ВА", Capacity = 12, Model = "Wolksvagen"},
					new Bus {RegNumber = "АР3476ВА", Capacity = 24, Model = "Mercedes"},
					new Bus {RegNumber = "АР5478ВА", Capacity = 18, Model = "Wolksvagen"}
				});

			db.Directions.AddRange(new List<Direction>
				{
					new Direction {City = "Dnepr", Distance = 60, Price = 65.0},
					new Direction {City = "Kiev", Distance = 700, Price = 580.0},
					new Direction {City = "Kharkov", Distance = 610, Price = 650.0},
				});




			db.SaveChanges();
		}
	}
}