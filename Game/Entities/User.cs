using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace GameStore.Entities
{
	public class User
	{
		public int ID;
		public static int globalID;

		public string UserName;
		public string FirstName;
		public string LastName;
		public int DateOfBirth;
		public string NationalID;
		public Game[] Games;

		public User(string userName, string firstName, string lastName,int dateOfBirth, string nationalID)
		{
			this.UserName = userName;
			this.FirstName = firstName;
			this.LastName = lastName;
			this.DateOfBirth = dateOfBirth;
			this.NationalID = nationalID;

			this.ID = Interlocked.Increment(ref globalID);
		}
	}
}
