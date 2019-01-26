﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.lib
{
	public class Customer
	{
		public Customer()
		{
			Orders = new List<Order>();
		}

		public int Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }

		public ICollection<Order> Orders { get; set; }
	}
}
