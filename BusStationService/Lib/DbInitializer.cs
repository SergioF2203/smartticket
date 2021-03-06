﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BusStationService.Lib
{
    public class DbInitializer : DropCreateDatabaseAlways<DB>
    {
        protected override void Seed(DB db)
        {
			db.Buses.AddRange(new List<Bus>
				{
					new Bus {RegNumber = "АР6012ВА", Capacity = 47, Model = "Wolksvagen"},
					new Bus {RegNumber = "АР3476ВА", Capacity = 47, Model = "Mercedes"},
					new Bus {RegNumber = "АР5478ВА", Capacity = 47, Model = "Wolksvagen"}
				});

			db.Directions.AddRange(new List<Direction>
                {
                    new Direction {City = "Uzhorod", Distance = 1321, Price = 65.0, Coordinates = "{x:16,y:204}", IsActive = false},
                    new Direction {City = "Lutsk", Distance = 913, Price = 580.0, Coordinates = "{x:116,y:71}", IsActive = false},
                    new Direction {City = "Lviv", Distance = 1090, Price = 580.0, Coordinates = "{x:89,y:126}", IsActive = false},
                    new Direction {City = "Frank", Distance = 1009, Price = 650.0, Coordinates = "{x:49,y:183}", IsActive = false},
                    new Direction {City = "Ternopil", Distance = 932, Price = 650.0, Coordinates = "{x:124,y:144}", IsActive = false},
                    new Direction {City = "Chernivtsy", Distance = 896, Price = 650.0, Coordinates = "{x:149,y:226}", IsActive = false},
                    new Direction {City = "Rivne", Distance = 841, Price = 650.0, Coordinates = "{x:190,y:96}", IsActive = false},
                    new Direction {City = "Khmel", Distance = 764, Price = 650.0, Coordinates = "{x:185,y:161}", IsActive = false},
                    new Direction {City = "Vinnitsya", Distance = 679, Price = 650.0, Coordinates = "{x:273,y:184}", IsActive = false},
                    new Direction {City = "Zhitomyr", Distance = 552, Price = 650.0, Coordinates = "{x:254,y:123}", IsActive = false},
                    new Direction {City = "Odesa", Distance = 555, Price = 650.0, Coordinates = "{x:336,y:342}", IsActive = true},
                    new Direction {City = "Kiev", Distance = 514, Price = 650.0, Coordinates = "{x:365,y:99}", IsActive = true},
                    new Direction {City = "Chernihiv", Distance = 619, Price = 650.0, Coordinates = "{x:376,y:50}", IsActive = false},
                    new Direction {City = "Cherkassy", Distance = 344, Price = 650.0, Coordinates = "{x:376,y:184}", IsActive = false},
                    new Direction {City = "Mykholaiv", Distance = 385, Price = 650.0, Coordinates = "{x:423,y:316}", IsActive = true},
                    new Direction {City = "Kherson", Distance = 325, Price = 650.0, Coordinates = "{x:450,y:356}", IsActive = false},
                    new Direction {City = "Simf", Distance = 374, Price = 650.0, Coordinates = "{x:506,y:455}", IsActive = false},
                    new Direction {City = "Poltava", Distance = 261, Price = 650.0, Coordinates = "{x:524,y:167}", IsActive = false},
                    new Direction {City = "Kirovograd", Distance = 310, Price = 650.0, Coordinates = "{x:402,y:221}", IsActive = false},
                    new Direction {City = "Sumy", Distance = 457, Price = 650.0, Coordinates = "{x:523,y:80}", IsActive = false},
                    new Direction {City = "Dnepr", Distance = 85, Price = 650.0, Coordinates = "{x:545,y:218}", IsActive = true},
                    new Direction {City = "Kharkiv", Distance = 303, Price = 650.0, Coordinates = "{x:585,y:139}", IsActive = true},
                    new Direction {City = "Donetsk", Distance = 229, Price = 650.0, Coordinates = "{x:667,y:252}", IsActive = false},
                    new Direction {City = "Lugansk", Distance = 396, Price = 650.0, Coordinates = "{x:704,y:219}", IsActive = false},

                });

	        db.Trips.AddRange(new List<Trip>
	        {
		        new Trip {DirectionId = 21, BusId = 1, Departure = new DateTime(2019, 02, 05, 10, 00, 00)},
				new Trip {DirectionId = 21, BusId = 2, Departure = new DateTime(2019, 02, 05, 12, 00, 00)},
			});

			db.Customers.AddRange(new List<Customer>
			{
				new Customer {Name = "Ivan", Email = "hgfhgf@mail.ru", Phone = "0956542145"},
			});


			db.SaveChanges();

			Order order = new Order
			{
				TripId = 1,
				CustomerId = 1,
				PlaceNumber = 1
			};
			db.Orders.Add(order);
			db.SaveChanges();
		}
    }
}