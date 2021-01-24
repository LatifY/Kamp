using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace GameStore.Entities
{
	public class Game
	{
		public int ID;
		public static int globalID;

		public string Name;
		public string Category;
		public int ReleaseDate; //yyyy
		public float Price;

		public Game(string name, string category, int releaseDate, float price)
		{
			this.Name = name;
			this.Category = category;
			this.ReleaseDate = releaseDate;
			this.Price = price;

			this.ID = Interlocked.Increment(ref globalID);
		}
	}
}
