using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BusStationService.Lib
{
	[DataContract]
	public class Bus
	{
		public Bus()
		{
			Trips = new List<Trip>();
		}
		[DataMember]
		public int Id { get; set; }
		[DataMember]
		public string RegNumber { get; set; }
		[DataMember]
		public string Model { get; set; }
		[DataMember]
		public int Capacity { get; set; }

		[DataMember]
		public ICollection<Trip> Trips { get; set; } 
	}
}
