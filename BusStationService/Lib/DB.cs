using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStationService.Lib
{
	public class DB : DbContext
	{
		static DB()
		{
			Database.SetInitializer<DB>(new DbInitializer());
		}

		public DB() : base("BusesStore")
		{
		}

		public DbSet<Bus> Buses { get; set; }
		public DbSet<Direction> Directions { get; set; }
		public DbSet<Trip> Trips { get; set; }
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Order> Orders { get; set; } 
	}
}
