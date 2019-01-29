using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BusStationService.Lib
{
	[DataContract]
	public class Customer
	{
		public Customer()
		{
			Orders = new List<Order>();
		}

		[DataMember]
		public int Id { get; set; }
		[DataMember]
		public string Name { get; set; }
		[DataMember]
		public string Email { get; set; }
		[DataMember]
		public string Phone { get; set; }

		[DataMember]
		public ICollection<Order> Orders { get; set; }
	}
}
