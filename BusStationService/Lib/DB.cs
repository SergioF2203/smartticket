using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BusStationService.Lib
{
	[DataContract]
	class DB : DbContext
	{
		public DB() : base("DBConnection")
		{
		}

		[DataMember]
		public DbSet<Bus> Buses { get; set; }
		[DataMember]
		public DbSet<Direction> Directions { get; set; }
		[DataMember]
		public DbSet<Trip> Trips { get; set; }
		[DataMember]
		public DbSet<Customer> Customers { get; set; }
		[DataMember]
		public DbSet<Order> Orders { get; set; } 
	}
}
