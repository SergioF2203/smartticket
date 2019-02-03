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
	}
}
