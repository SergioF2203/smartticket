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
				Bus b1 = new Bus
				{
					RegNumber = "АР3476ВА",
					Capacity = 24,
					Model = "Mercedes"
				};
				Bus b2 = new Bus
				{
					RegNumber = "АР6012ВА",
					Capacity = 12,
					Model = "Wolksvagen"
				};

				db.Buses.Add(b1);
				db.Buses.Add(b2);


				Direction d1 = new Direction
				{
					City = "Dnepr",
					Distance = 60,
					Price = 65.0
				};
				Direction d2 = new Direction
				{
					City = "Kiev",
					Distance = 700,
					Price = 580
				};

				db.Directions.Add(d1);
				db.Directions.Add(d2);
				db.SaveChanges();







				Console.WriteLine("Data pushed to db");
			}
		}
	}
}
