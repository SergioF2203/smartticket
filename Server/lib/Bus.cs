using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.lib
{
	public class Bus
	{
		public Bus()
		{
			Trips = new List<Trip>();
		}

		public int Id { get; set; }
		public string RegNumber { get; set; }
		public string Model { get; set; }
		public int Capacity { get; set; }

		public ICollection<Trip> Trips { get; set; } 
	}
}
