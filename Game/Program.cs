using System;
using System.Collections.Generic;
using GameStore.Entities;
using GameStore.Managers;

namespace GameStore
{
	class Program
	{
		static void Main(string[] args)
		{
			Menu menu = new Menu();

			while (true)
			{
				menu.MainMenu();
			}
			/*
			User user1 = new User("LatifY", "Latif", "Yılmaz",new DateTime(2005,1,31), "123");
			User user2 = new User("EnginD", "Engin", "Demiroğ", new DateTime(1985,1,6), "321");
			userManager.Add(user1);
			userManager.Add(user2);

			Game game1 = new Game("GTAV", "Action-Adventure", 2013, 180);
			Game game2 = new Game("Undertale", "RPG", 2013, 24);
			gameManager.Add(game1);
			gameManager.Add(game2);

			userManager.GetUserList();
			gameManager.GetGameList();
			*/
		}
	}

	class Menu
	{
		public UserManager userManager = new UserManager();
		public GameManager gameManager = new GameManager();

		public void MainMenu()
		{
			string text = "1- Kullanıcılar\n2- Kullanıcı Ekle\n3- Kullanıcı Güncelle\n4- Kullanıcı Sil\n" +
				"5- Oyunlar\n6- Oyun Ekle\n7- Oyun Güncelle\n8- Oyun Sil\n" +
				"9- Çıkış";
			Print("Ana Menü",text);

			string choiceStr = Console.ReadLine();
			int choice = Convert.ToInt32(choiceStr);
			if (choice == 1 || choice == 2 || choice == 3 || choice == 4)
			{
				Users(choice);
			}
			else if (choice == 5 || choice == 6 || choice == 7 || choice == 8)
			{
				Games(choice);
			}
			else if (choice == 9)
			{
				Console.WriteLine("Byee :)");
				Console.ReadLine();
			}
			else
			{
				Print("Hata","Lütfen Geçerli Bir Değer Giriniz");
			}
		}

		public void Users(int choice)
		{
			List<User> users = userManager.GetUserList();
			string usersText = userManager.GetUserListText();
			if (choice == 1)
			{
				Print("Kullanıcılar", usersText);
			}
			else if (choice == 2)
			{
				Console.WriteLine("*****Kullanıcı Ekle******");
				Console.Write("Kullanıcı Adı: ");
				string userName = Console.ReadLine();
				Console.Write("Ad: ");
				string firstName = Console.ReadLine();
				Console.Write("Soyad: ");
				string lastName = Console.ReadLine();
				Console.Write("Doğum Yılı: ");
				string dateOfBirthStr = Console.ReadLine();
				int dateOfBirth = Convert.ToInt32(dateOfBirthStr);
				Console.Write("TC Kimlik NO: ");
				string nationalID = Console.ReadLine();
				User user = new User(userName,firstName,lastName,dateOfBirth,nationalID);
				userManager.Add(user);
				Console.WriteLine("Kullanıcı Başarıyla Eklendi");
				Console.WriteLine("*********************");
			}
			else if (choice == 3)
			{
				Console.WriteLine("*****Kullanıcı Güncelle******");
				Console.WriteLine(usersText);
				Console.Write("Seç: ");
				string chooseStr = Console.ReadLine();
				int choose = Convert.ToInt32(chooseStr);

				Console.Write("Kullanıcı Adı: ");
				string userName = Console.ReadLine();
				Console.Write("Ad: ");
				string firstName = Console.ReadLine();
				Console.Write("Soyad: ");
				string lastName = Console.ReadLine();
				Console.Write("Doğum Yılı: ");
				string dateOfBirthStr = Console.ReadLine();
				int dateOfBirth = Convert.ToInt32(dateOfBirthStr);
				Console.Write("TC Kimlik NO: ");
				string nationalID = Console.ReadLine();
				User user = new User(userName, firstName, lastName, dateOfBirth, nationalID);
				userManager.Update(user, choose-1);
				Console.WriteLine("Kullanıcı Başarıyla Güncellendi");
				Console.WriteLine("*********************");
			}
			else if (choice == 4)
			{
				Console.WriteLine("*****Kullanıcı Sil******");
				Console.WriteLine(usersText);
				Console.Write("Seç: ");
				string chooseStr = Console.ReadLine();
				int choose = Convert.ToInt32(chooseStr);
				userManager.Delete(users[choose-1]);
			}
			else
			{
				Console.WriteLine("Lütfen geçerli bir değer giriniz");
			}
			MainMenu();
		}

		public void Games(int choice)
		{
			List<Game> games = gameManager.GetGameList();
			string gamesText = gameManager.GetGameListText();
			if (choice == 5)
			{
				Print("Oyunlar", gamesText);
			}
			else if (choice == 6)
			{
				Console.WriteLine("*****Oyun Ekle******");
				Console.Write("Oyun Adı: ");
				string name = Console.ReadLine();
				Console.Write("Kategori: ");
				string category = Console.ReadLine();
				Console.Write("Yayın Tarihi: ");
				string releaseDateStr = Console.ReadLine();
				int releaseDate = Convert.ToInt32(releaseDateStr);
				Console.Write("Fiyat: ");
				string priceStr = Console.ReadLine();
				int price = Convert.ToInt32(priceStr);
				Game game = new Game(name, category, releaseDate, price);
				gameManager.Add(game);
				Console.WriteLine("Oyun Başarıyla Eklendi");
				Console.WriteLine("*********************");
			}
			else if (choice == 7)
			{
				Console.WriteLine("*****Oyun Güncelle******");
				Console.WriteLine(gamesText);
				Console.Write("Seç: ");
				string chooseStr = Console.ReadLine();
				int choose = Convert.ToInt32(chooseStr);

				Console.Write("Oyun Adı: ");
				string name = Console.ReadLine();
				Console.Write("Kategori: ");
				string category = Console.ReadLine();
				Console.Write("Yayın Tarihi: ");
				string releaseDateStr = Console.ReadLine();
				int releaseDate = Convert.ToInt32(releaseDateStr);
				Console.Write("Fiyat: ");
				string priceStr = Console.ReadLine();
				int price = Convert.ToInt32(priceStr);
				Game game = new Game(name, category, releaseDate, price);
				gameManager.Update(game, choose - 1);
				Console.WriteLine("Oyun Başarıyla Güncellendi");
				Console.WriteLine("*********************");
			}
			else if (choice == 8)
			{
				Console.WriteLine("*****Oyun Sil******");
				Console.WriteLine(gamesText);
				Console.Write("Seç: ");
				string chooseStr = Console.ReadLine();
				int choose = Convert.ToInt32(chooseStr);
				gameManager.Delete(games[choose - 1]);
			}
			else
			{
				Console.WriteLine("Lütfen geçerli bir değer giriniz");
			}
			MainMenu();
		}

		private void Print(string state,string text)
		{
			Console.WriteLine($"*****{state}******");
			Console.WriteLine(text);
			Console.WriteLine("*********************");
		}


	}
}
