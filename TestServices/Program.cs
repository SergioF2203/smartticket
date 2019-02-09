using System;
using System.Collections.ObjectModel;
using TestServices.AdminServiceClient;
using Newtonsoft.Json;


namespace TestServices
{
	class Program
	{
		static void Main(string[] args)
		{
			var customer = new CustomerService.CustomerServiceClient();
			var admin = new AdminServiceClient.AdminServiceClient();

			//var res = customer.GetDirections();
			//foreach (var d in res)
			//{
			//	Console.WriteLine(d.Coordinates);
			//}

			//Bus bus = admin.GetBusById(2);

			//bus.RegNumber = "9999xxxx9999";

			//admin.SaveBus(bus);

			

			//Direction[] dirs = customer.GetDirections();
			//foreach (var d in dirs)
			//{
			//	string coord = d.Coordinates;
			//	coord = coord.Replace("{", "");
			//	coord = coord.Replace("}", "");

			//	string[] arr = coord.Split(',');

			//	int x = Int32.Parse(arr[0].Split(':')[1]);
			//	int y = Int32.Parse(arr[1].Split(':')[1]);

			//	Console.WriteLine($"{x} - {y}");
			//}

			//var places = customer.GetOccupiedPlaces(1);
			//foreach (int p in places)
			//{
			//	Console.WriteLine(p);
			//}

			//var directions = admin.GetAllDirections();
			//foreach (var d in directions)
			//{
			//	Console.WriteLine($"{d.City} - {d.Coordinates}");
			//}

			//var directions = admin.GetAllDirections();
			//foreach (var d in directions)
			//{
			//	d.IsActive = true;
			//}

			//admin.SaveDirections(directions);

			//var places = customer.GetOccupiedPlaces(1);
			//foreach (int p in places)
			//{
			//	Console.WriteLine(p);
			//}

			//var str = admin.GetAllTrips();

			//var trips = JsonConvert.DeserializeObject<ObservableCollection<Trip>>(str);

			//foreach (var t in trips)
			//{
			//	Trip trip = t as Trip;
			//	Console.WriteLine($"{trip.Bus.Model}");
			//}

			DateTime date = new DateTime(2019, 02, 05, 0, 0, 0);
			string jsonResult = customer.GetTripsByDate(date);

			var trips = JsonConvert.DeserializeObject<ObservableCollection<Trip>>(jsonResult);

			foreach (var t in trips)
			{
				Console.WriteLine($"{t.Departure} - {t.Bus.RegNumber} - {t.Direction.City}");
			}


		}
	}
}
