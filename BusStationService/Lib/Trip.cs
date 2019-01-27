using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStationService.Lib
{
	public class Trip
	{
		public Trip()
		{
			Orders = new List<Order>();
		}

		public int Id { get; set; }
		public int? DirectionId { get; set; }
		public int? BusId { get; set; }
		public DateTime Departure { get; set; }
		public int Filling { get; set; }

		public Direction Direction { get; set; }
		public Bus Bus { get; set; }
		public ICollection<Order> Orders;
	}
}
