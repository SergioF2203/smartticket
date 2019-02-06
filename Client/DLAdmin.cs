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
	}
}
