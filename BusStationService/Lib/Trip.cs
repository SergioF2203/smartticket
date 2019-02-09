using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BusStationService.Lib
{
	[DataContract]
	public class Trip
	{
		public Trip()
		{
			Orders = new List<Order>();
		}

		[DataMember]
		public int Id { get; set; }
		[DataMember]
		public int? DirectionId { get; set; }
		[DataMember]
		public int? BusId { get; set; }
		[DataMember]
		public DateTime Departure { get; set; }
		[DataMember]
		public int Filling { get; set; }

		[DataMember]
		public Direction Direction { get; set; }
		[DataMember]
		public Bus Bus { get; set; }
		[DataMember]
		public ICollection<Order> Orders { get; set; }
	}
}
