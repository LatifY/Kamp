using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using GameStore.Entities;

namespace GameStore.Managers
{
	public class UserManager
	{
		List<User> users = new List<User>();

		public void Add(User user)
		{
			users.Add(user);
		}

		public void Delete(User user)
		{
			users.Remove(user);
		}

		public void Update(User newUser, int userIndex)
		{
			users[userIndex].UserName = newUser.UserName;
			users[userIndex].FirstName = newUser.FirstName;
			users[userIndex].LastName = newUser.LastName;
			users[userIndex].DateOfBirth = newUser.DateOfBirth;
			users[userIndex].NationalID = newUser.NationalID;
		}

		public List<User> GetUserList()
		{
			return users;
		}

		public string GetUserListText()
		{
			if (users.Count == 0)
			{
				return "\nHenüz kullanıcı bulunmuyor!\n";
			}
			string text = "";
			for (int i = 0; i < users.Count; i++)
			{
				User user = users[i];
				string _text = ($"{user.ID}: {user.UserName} - ({user.FirstName} {user.LastName}) - {user.DateOfBirth} - {user.NationalID}");
				text += _text + "\n";
			}
			return text;
		}

	}
}
