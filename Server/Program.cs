using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server.lib;

namespace Server
{
	class Program
	{
		static void Main(string[] args)
		{
			using (DB db = new DB())
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







				Console.WriteLine("Data pushed to db");
			}
		}
	}
}
