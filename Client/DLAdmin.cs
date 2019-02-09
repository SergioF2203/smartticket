using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Client.AdminService;


namespace Client
{
	public class DLAdmin
	{
		public AdminServiceClient adminProxy;
		public DLAdmin()
		{
			adminProxy = new AdminServiceClient();
		}

		// FUNCTIONS
		// === Buses ===
		public void AddBus(Bus bus)
		{
			adminProxy.AddBus(bus);
		}

		public Bus GetBusById(int id)
		{
			Bus bus = adminProxy.GetBusById(id);
			return bus;
		}

		public void SaveBus(Bus bus)
		{
			if (bus != null)
			{
				adminProxy.SaveBus(bus);
			}
		}

		public ObservableCollection<Bus> GetAllBuses()
		{
			List<Bus> importData = adminProxy.GetAllBusses().ToList();
			ObservableCollection<Bus>result = new ObservableCollection<Bus>();
			foreach (var bus in importData)
			{
				result.Add(bus);
			}

			return result;
		}

		public void DeleteBus(int id)
		{
			adminProxy.DeleteBus(id);
		}


		// === Directions ===
		public ObservableCollection<Direction> GetAllDirections()
		{
			List<Direction> importData = adminProxy.GetAllDirections().ToList();
			ObservableCollection<Direction> directions = new ObservableCollection<Direction>();
			foreach (var d in importData)
			{
				directions.Add(d);
			}

			return directions;
		}

		public void SaveDirections(List<Direction> directions)
		{
			adminProxy.SaveDirections(directions.ToArray());
		}

        // === Customers ===
        public void AddCustomer(Customer customer)
		{
			adminProxy.AddCustomer(customer);
		}

		public Customer GetCustomerById(int id)
		{
			Customer customer = adminProxy.GetCustomerById(id);
			return customer;
		}

		public void SaveCustomer(Customer customer)
		{
			if (customer != null)
			{
				adminProxy.SaveCustomer(customer);
			}
		}

		public ObservableCollection<Customer> GetAllCustomers()
		{
			List<Customer> importData = adminProxy.GetAllCustomers().ToList();
			ObservableCollection<Customer> result = new ObservableCollection<Customer>();
			foreach (var customer in importData)
			{
				result.Add(customer);
			}

			return result;
		}

		public void DeleteCustomer(int id)
		{
			adminProxy.DeleteCustomer(id);
		}

		// === Orders ===
		public void AddOrder(Order order)
		{
			adminProxy.AddOrder(order);
		}

		public Order GetOrderById(int id)
		{
			Order order = adminProxy.GetOrderById(id);
			return order;
		}

		public void SaveOrder(Order order)
		{
			if (order != null)
			{
				adminProxy.SaveOrder(order);
			}
		}

		public ObservableCollection<Order> GetAllOrders()
		{
			List<Order> importData = adminProxy.GetAllOrders().ToList();
			ObservableCollection<Order> result = new ObservableCollection<Order>();
			foreach (var order in importData)
			{
				result.Add(order);
			}

			return result;
		}

		public void DeleteOrder(int id)
		{
			adminProxy.DeleteOrder(id);
		}
	}
}
