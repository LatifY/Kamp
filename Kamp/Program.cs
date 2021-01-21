using System;

namespace MyDictionary
{
	class Program
	{
		static void Main(string[] args)
		{
			MyDictionary<string, string> myDictionary = new MyDictionary<string, string>();

			myDictionary.Add("apple","elma");
			myDictionary.Add("pencil","kalem");
			myDictionary.Add("computer","bilgisayar");
			myDictionary.Add("milk","süt");

			myDictionary.Show(2);

			myDictionary.ShowAll();
		}
	}
}
