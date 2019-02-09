using System;
using System.Collections.Generic;
using System.Linq;
using BusStationService.Lib;
using System.Data.Entity;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

namespace BusStationService
{
	public class AdminService : IAdminService
	{
		#region === Buses ===
		public void AddBus(Bus bus)
		{
			using (DB db = new DB())
			{
				db.Buses.Add(bus);
				db.SaveChanges();

				Helper.ShowMessage("AdminService", "called AddBus()");
			}
		}

		public Bus GetBusById(int id)
		{
			using (DB db = new DB())
			{
				Bus bus = db.Buses.Find(id);

				Helper.ShowMessage("AdminService", "GetBusById(int id)");

				return bus;
			}
		}

		public void SaveBus(Bus bus)
		{
			if (bus != null)
			{
				using (DB db = new DB())
				{
					db.Entry(bus).State = EntityState.Modified;
					db.SaveChanges();

					Helper.ShowMessage("AdminService", "SaveBus(Bus bus)");
				}
			}
		}

		public List<Bus> GetAllBusses()
		{
			using (DB db = new DB())
			{
				var result = db.Buses.ToList();

				Helper.ShowMessage("AdminService", "GetAllBusses()");

				return result;
			}
		}

		public void DeleteBus(int id)
		{
			using (DB db = new DB())
			{
				Bus bus = db.Buses.Find(id);
				if (bus != null)
				{
					db.Buses.Remove(bus);
					db.SaveChanges();
				}

				Helper.ShowMessage("AdminService", "DeleteBus(int id)");
			}
		}
		#endregion

		#region === Directions ===
		public List<Direction> GetAllDirections()
		{
			using (DB db = new DB())
			{
				var result = db.Directions.ToList();

				Helper.ShowMessage("AdminService", "GetAllDirections()");

				return result;
			}
		}

		public void SaveDirections(List<Direction> directions)
		{
			using (DB db = new DB())
			{
				foreach (var d in directions)
				{
					if (d != null)
					{
						db.Entry(d).State = EntityState.Modified;
					}
				}

				db.SaveChanges();

				Helper.ShowMessage("AdminService", "SaveDirections(List<Direction> directions)");
			}
		}
		#endregion

		#region === Customers ===
		public List<Customer> GetAllCustomers()
		{
			using (DB db = new DB())
			{
				var result = db.Customers.ToList();

				Helper.ShowMessage("AdminService", "GetAllCustomers()");

				return result;
			}
		}

		public Customer GetCustomerById(int id)
		{
			using (DB db = new DB())
			{
				Customer customer = db.Customers.Find(id);

				Helper.ShowMessage("AdminService", "GetCustomerById(int id)");

				return customer;
			}
		}

		public void AddCustomer(Customer customer)
		{
			using (DB db = new DB())
			{
				db.Customers.Add(customer);
				db.SaveChanges();

				Helper.ShowMessage("AdminService", "AddCustomer(Customer customer)");
			}
		}

		public void SaveCustomer(Customer customer)
		{
			if (customer != null)
			{
				using (DB db = new DB())
				{
					db.Entry(customer).State = EntityState.Modified;
					db.SaveChanges();

					Helper.ShowMessage("AdminService", "SaveCustomer(Customer customer)");
				}
			}
		}

		public void DeleteCustomer(int id)
		{
			using (DB db = new DB())
			{
				Customer customer = db.Customers.Find(id);
				if (customer != null)
				{
					db.Customers.Remove(customer);
					db.SaveChanges();
				}

				Helper.ShowMessage("AdminService", "DeleteCustomer(int id)");
			}
		}
		#endregion

		#region === Orders ===
		public List<Order> GetAllOrders()
		{
			using (DB db = new DB())
			{
				var result = db.Orders.ToList();

				Helper.ShowMessage("AdminService", "GetAllOrders()");

				return result;
			}
		}

		public Order GetOrderById(int id)
		{
			using (DB db = new DB())
			{
				Order order = db.Orders.Find(id);

				Helper.ShowMessage("AdminService", "GetOrderById(int id)");

				return order;
			}
		}

		public void AddOrder(Order order)
		{
			using (DB db = new DB())
			{
				db.Orders.Add(order);
				db.SaveChanges();

				Helper.ShowMessage("AdminService", "AddOrder(Order order)");
			}
		}

		public void SaveOrder(Order order)
		{
			if (order != null)
			{
				using (DB db = new DB())
				{
					db.Entry(order).State = EntityState.Modified;
					db.SaveChanges();

					Helper.ShowMessage("AdminService", "SaveOrder(Order order)");
				}
			}
		}

		public void DeleteOrder(int id)
		{
			using (DB db = new DB())
			{
				Order order = db.Orders.Find(id);
				if (order != null)
				{
					db.Orders.Remove(order);
					db.SaveChanges();
				}

				Helper.ShowMessage("AdminService", "DeleteOrder(int id)");
			}
		}
		#endregion

		#region === Trips ===
		public string GetAllTrips()
		{
			using (DB db = new DB())
			{
				var result = db.Trips
					.Include(t => t.Bus)
					.Include(t => t.Direction)
					.AsEnumerable()
					.ToList();

				string json = JsonConvert.SerializeObject(result,
					Formatting.Indented,
					new JsonSerializerSettings
						{
							ReferenceLoopHandling = ReferenceLoopHandling.Ignore
						});

				Helper.ShowMessage("AdminService", "GetAllTrips()");

				return json;
			}
		}

		public List<Trip> GetTripsByDate(DateTime date)
		{
			throw new NotImplementedException();
		}

		public void DeleteTrip(int tripId)
		{
			throw new NotImplementedException();
		}

		public void AddTrip(Trip trip)
		{
			throw new NotImplementedException();
		}

		public Trip GetTripById(int tripId)
		{
			throw new NotImplementedException();
		}

		public void SaveTrip(Trip trip)
		{
			throw new NotImplementedException();
		}

		public List<Direction> GetAvailableDirections()
		{
			throw new NotImplementedException();
		}

		public List<Bus> GetAvailableBuses(DateTime date)
		{
			throw new NotImplementedException();
		}
		#endregion


	}
}
