using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BusStationService.Lib;
using Newtonsoft.Json;

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

				Helper.ShowMessage("CustomerService", "called GetOccupiedPlaces(int tripId)");

				return places;
			}
		}

		public string GetTripsByDate(DateTime date)
		{
			using (DB db = new DB())
			{
				var trips = db.Trips
					.Where(t => DbFunctions.TruncateTime(t.Departure) == date.Date)
					.Include(t => t.Direction)
					.Include(t => t.Bus)
					.Include(t => t.Orders)
					.ToList();

				string json = JsonConvert.SerializeObject(trips,
					Formatting.Indented,
					new JsonSerializerSettings
					{
						ReferenceLoopHandling = ReferenceLoopHandling.Ignore
					});

				Helper.ShowMessage("CustomerService", "called GetTripsByDate(DateTime date)");

				return json;
			}
		}
	}
}
