using System;

namespace Modul04
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[,] _table = {
				{"Ivan",     "Georgiev",  "19"},
				{"Vasil",    "Ivanov",    "23"},
				{"Milen",    "Georgiev",  "43"},
				{"Cvetan",   "Borisov",   "33"},
				{"Gergana",  "Todorova",  "56"},
				{"Ivana",    "Koleva",    "18"}
			};

			//Антетка на таблица
			Console.WriteLine ("Ime".PadRight(12) + "Faimilia".PadRight(12) + "Godini".PadRight(12) );
			Console.WriteLine ("=============================================");


			//Тяло на таблица
			//Пример с for
			//			for (int i = 0; i < _table.Length / 3; i++) {
			//				for (int j = 0; j < 3; j++) {
			//					Console.Write (_table [i, j].PadRight (12));
			//				}
			//				Console.WriteLine ();
			//			}
			//				
			//Пример с While
			//			int i = 0;
			//			while (i < _table.Length / 3)
			//			{
			//				Console.WriteLine (
			//					_table[i, 0].PadRight(12) + 
			//					_table[i, 1].PadRight(12) + 
			//					_table[i, 2].PadRight(12) 
			//				
			//				);
			//
			//				i++;
			//			}
			//Пример с do while
			int i = 0;
			do{
				//Koд
				Console.WriteLine (
					_table[i, 0].PadRight(12) + 
					_table[i, 1].PadRight(12) + 
					_table[i, 2].PadRight(12) 

				);
				i++;
			}while(i < _table.Length / 3);
		}
	}
}
