using System;

namespace TableProject
{
	class MainClass
	{

		enum ti {Ime = 0, familia, godini};


		public static void Main (string[] args)
		{
			
			//Дефиниране на таблица
			string[,] table = new string[2, 3];

			//Въвеждане на първи ред
			table[0, (int) ti.Ime] = "Nikolai"; table[0, (int) ti.familia] = "Stoqnov"; table[0, (int) ti.godini] = "19"; 

			//Въвеждане на втори ред
			table[1, (int) ti.Ime] = "Stoqn"; table[1, (int) ti.familia] = "Nikolaev"; table[1, (int) ti.godini] = "29"; 

			//Печат
			Console.Write ("Koi red iskate da vidite: ");
			int _index = Convert.ToInt32 (Console.ReadLine ()) - 1;

			Console.WriteLine (
				(table[_index, (int) ti.Ime])[0] + ". " + 
				 table[_index, (int) ti.familia] + ", " + 
				 table[_index, (int) ti.godini] + " g. "
			);
			
		}
	}
}










//string[] row = new string[3];
//
//			row [0] = "Red1";
//			row [1] = "Red2";
//			row [2] = "Red3";
//
//			Console.WriteLine ("Masiv row: " + row [0] + ", " + row [1] + ", " + row [2] + "\n");
//
//			string[] parse = "1,2,3,4,5,6,7,8,9".Split (',');
//			Console.WriteLine ("Broqt na masiva: \n" + "1,2,3,4,5,6,7,8,9\n\ne:" + parse.Length );
//
//			string list1 = string.Join (";", parse);
//			Console.WriteLine ("Noviq string e:\n" + list1 + "\n\n");