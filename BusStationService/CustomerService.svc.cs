using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BusStationService.Lib;

namespace BusStationService
{
	public class CustomerService : ICustomerService
	{
		public List<Direction> GetDirections()
		{
			using (DB db = new DB())
			{
				var coords = db.Directions
					.Where(d => d.Coordinates != "")
					.ToList();

				Helper.ShowMessage("CustomerService", "called GetDirections()");

				return coords;
			}
		}

		public List<int> GetOccupiedPlaces(int tripId)
		{
			using (DB db = new DB())
			{
				var places = db.Orders
					.Where(o => o.TripId == tripId)
					.Select(o => o.PlaceNumber)
					.ToList();

				Helper.ShowMessage("CustomerService", "called GetFreePlaces(int tripId)");

				return places;
			}
		}
	}
}
