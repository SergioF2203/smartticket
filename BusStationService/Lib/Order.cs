using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BusStationService.Lib
{
	[DataContract]
	public class Order
	{
		[DataMember]
		public int Id { get; set; }
		[DataMember]
		public int? CustomerId { get; set; }
		[DataMember]
		public int? TripId { get; set; }
		[DataMember]
		public int PlaceNumber { get; set; }

		[DataMember]
		public Customer Customer { get; set; }
		[DataMember]
		public Trip Trip { get; set; }
	}
}
