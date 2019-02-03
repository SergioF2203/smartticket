using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BusStationService.Lib
{
	[DataContract]
	public class Direction
	{
		public Direction()
		{
			Trips = new List<Trip>();
		}

		[DataMember]
		public int Id { get; set; }
		[DataMember]
		public string City { get; set; }
		[DataMember]
		public int Distance { get; set; }
		[DataMember]
		public double Price { get; set; }
		[DataMember]
		public string Coordinates { get; set; }
		[DataMember]
		public bool IsActive { get; set; }

		[DataMember]
		public ICollection<Trip> Trips { get; set; } 
	}
}
