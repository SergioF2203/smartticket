using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.CustomerService;
using Newtonsoft.Json;

namespace Client
{
	public class DLCustomer
	{
		public CustomerServiceClient customerProxy;
		public DLCustomer()
		{
			customerProxy = new CustomerServiceClient();
		}

		// FUNCTIONS
		public List<Direction> GetDirections()
		{
			Direction[] result = customerProxy.GetDirections();
			return result.ToList<Direction>();
		}

		public List<int> GetOccupiedPlaces(int tripId)
		{
			List<int> places = customerProxy.GetOccupiedPlaces(tripId).ToList();
			return places;
		}

		public ObservableCollection<Trip> GetTripsByDate(DateTime date)
		{
			string jsonResult = customerProxy.GetTripsByDate(date);

			var trips = JsonConvert.DeserializeObject<ObservableCollection<Trip>>(jsonResult);

			return trips;
		}




		// Service functions
		public int[] ToCoordinates(string coord)
		{
			coord = coord.Replace("{", "");
			coord = coord.Replace("}", "");

			string[] arr = coord.Split(',');

			int x = Int32.Parse(arr[0].Split(':')[1]);
			int y = Int32.Parse(arr[1].Split(':')[1]);

			return new[] {x, y};
		}

	}
}
