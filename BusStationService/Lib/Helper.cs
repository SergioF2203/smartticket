using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusStationService.Lib
{
	public static class Helper
	{
		public static void ShowMessage(string serviceName, string msg)
		{
			Console.ForegroundColor = ConsoleColor.DarkGreen;
			Console.WriteLine($"{serviceName} say >> {msg}");
			Console.ForegroundColor = ConsoleColor.White;
		}
	}
}