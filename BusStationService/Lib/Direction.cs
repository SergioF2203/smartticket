using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStationService.Lib
{
	public class Direction
	{
		public Direction()
		{
			Trips = new List<Trip>();
		}

		public int Id { get; set; }
		public string City { get; set; }
		public int Distance { get; set; }
		public double Price { get; set; }

		public ICollection<Trip> Trips { get; set; } 
	}
}
