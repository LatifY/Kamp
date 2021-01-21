using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Customer> customers = new List<Customer>();
			CustomerManager customerManager = new CustomerManager();

			Customer customer1 = new Customer("Latif", "Yilmaz", "Turkey", 1200);
			Customer customer2 = new Customer("Engin", "Demirog", "Turkey", 3600);
			Customer customer3 = new Customer("Elon", "Musk", "USA", 195000000000);
			customers.AddRange(new List<Customer> { customer1, customer2, customer3 });
			foreach (var customer in customers)
			{
				customerManager.Create(customer);
			}

			customerManager.Delete(customers[0]);
		}
	}
}
