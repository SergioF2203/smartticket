using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStationService.Lib
{
	public class Order
	{
		public int Id { get; set; }
		public int? CustomerId { get; set; }
		public int? TripId { get; set; }

		public Customer Customer { get; set; }
		public Trip Trip { get; set; }
	}
}
