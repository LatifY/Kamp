using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
	class MyDictionary<Key, Value>
	{
		Key[] keys;
		Value[] values;
		public MyDictionary()
		{
			keys = new Key[0];
			values = new Value[0];
		}

		public void Add(Key key, Value value)
		{
			Key[] tempKeys = keys;
			Value[] tempValues = values;
			keys = new Key[keys.Length + 1];
			values = new Value[values.Length + 1];

			for (int i = 0; i < tempValues.Length; i++)
			{
				keys[i] = tempKeys[i];
				values[i] = tempValues[i];
			}
			keys[keys.Length - 1] = key;
			values[values.Length - 1] = value;

			Console.WriteLine($"Eklendi: ({key}: {value})");
		}

		public int Length
		{
			get { return keys.Length; }
		}

		public void ShowAll()
		{
			for (int i = 0; i < keys.Length; i++)
			{
				Console.WriteLine($"{i}- {keys[i]}: {values[i]}");
			}
		}

		public void Show(int index)
		{
			Console.WriteLine($"{index}- {keys[index]}: {values[index]}");
		}
	}
}
