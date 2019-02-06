using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BusStationService.Lib;
using System.Data.Entity;

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
			throw new NotImplementedException();
		}

		public Order GetOrderById(int id)
		{
			throw new NotImplementedException();
		}

		public void AddOrder(Order order)
		{
			throw new NotImplementedException();
		}

		public void SaveOrder(Order order)
		{
			throw new NotImplementedException();
		}

		public void DeleteOrder(int id)
		{
			throw new NotImplementedException();
		}
		#endregion
	}
}
