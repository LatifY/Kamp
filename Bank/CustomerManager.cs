using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
	class CustomerManager
	{
		public void Create(Customer customer)
		{
			Console.WriteLine("---------Musteri Olusturuldu---------");
			Console.WriteLine("Id: " + customer.Id);
			Console.WriteLine("Adi: " + customer.Name);
			Console.WriteLine("Soyadi: " + customer.Surname);
			Console.WriteLine("Ulkesi: " + customer.Country);
			Console.WriteLine("Bakiyesi: " + customer.Balance);
			Console.WriteLine("-------------------------------------");
		}
		public void Delete(Customer customer)
		{
			Console.WriteLine("---------Musteri Silindi---------");
			Console.WriteLine("Id: " + customer.Id);
			Console.WriteLine("Adi: " + customer.Name);
			Console.WriteLine("Soyadi: " + customer.Surname);
			Console.WriteLine("Ulkesi: " + customer.Country);
			Console.WriteLine("Bakiyesi: " + customer.Balance);
			Console.WriteLine("-------------------------------------");
		}
	}
}
