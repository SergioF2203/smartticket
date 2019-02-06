using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BusStationService.Lib;

namespace BusStationService
{
	[ServiceContract]
	public interface IAdminService
	{
		[OperationContract]
		void AddBus(Bus bus);

		[OperationContract]
		Bus GetBusById(int id);

		[OperationContract]
		void SaveBus(Bus bus);

		[OperationContract]
		List<Bus> GetAllBusses();

		[OperationContract]
		void DeleteBus(int id);


		[OperationContract]
		List<Direction> GetAllDirections();

		[OperationContract]
		void SaveDirections(List<Direction> directions);


		[OperationContract]
		List<Customer> GetAllCustomers();

		[OperationContract]
		Customer GetCustomerById(int id);

		[OperationContract]
		void AddCustomer(Customer customer);

		[OperationContract]
		void SaveCustomer(Customer customer);

		[OperationContract]
		void DeleteCustomer(int id);


		[OperationContract]
		List<Order> GetAllOrders();

		[OperationContract]
		Order GetOrderById(int id);

		[OperationContract]
		void AddOrder(Order order);

		[OperationContract]
		void SaveOrder(Order order);

		[OperationContract]
		void DeleteOrder(int id);


		//[OperationContract]
		//List<Direction> GetAvailableDirections();

		//[OperationContract]
		//List<Bus> GetAvailableBuses();


	}
}
