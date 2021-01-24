using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using GameStore.Entities;

namespace GameStore.Managers
{
	public class GameManager
	{
		List<Game> games = new List<Game>();

		public void Add(Game game)
		{
			games.Add(game);
		}

		public void Delete(Game game)
		{
			games.Remove(game);
		}

		public void Update(Game newGame, int id)
		{
			int gameIndex = games.FindIndex(game => game.ID == id);
			games[gameIndex] = newGame;
		}

		public List<Game> GetGameList()
		{
			return games;
		}


		public string GetGameListText()
		{
			if (games.Count == 0)
			{
				return "\nHenüz oyun bulunmuyor!\n";
			}
			string text = "";
			for (int i = 0; i < games.Count; i++)
			{
				Game game = games[i];
				string _text = ($"{game.ID}: {game.Name} - {game.Category} /{game.Price}TL/ ({game.ReleaseDate})");
				text += _text + "\n";
			}
			return text;
		}
	}
}
