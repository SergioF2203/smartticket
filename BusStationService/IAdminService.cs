﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BusStationService
{
	[ServiceContract]
	public interface IAdminService
	{
		[OperationContract]
		string DoWork();
	}
}