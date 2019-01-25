using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.lib
{
	class DB : DbContext
	{
		public DB() : base("DBConnection")
		{
		}

		public DbSet<Bus> Buses { get; set; }
		public DbSet<Direction> Directions { get; set; }
		public DbSet<Trip> Trips { get; set; }
	}
}
