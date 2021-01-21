using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Bank
{
	class Customer
	{
		public int Id;
		public static int globalId;

		public string Name;
		public string Surname;
		public string Country;
		public long Balance;

		public Customer(string _name, string _surname, string _country, long _balance)
		{
			this.Name = _name;
			this.Surname = _surname;
			this.Country = _country;
			this.Balance = _balance;

			this.Id = Interlocked.Increment(ref globalId);
		}
	}
}
