using System;

namespace TableProject
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[] row = new string[3];

			row [0] = "Red1";
			row [1] = "Red2";
			row [2] = "Red3";

			Console.WriteLine ("Masiv row: " + row [0] + ", " + row [1] + ", " + row [2] + "\n");

			string[] parse = "1,2,3,4,5,6,7,8,9".Split (',');
			Console.WriteLine ("Broqt na masiva: \n" + "1,2,3,4,5,6,7,8,9\n\ne:" + parse.Length );

			string list1 = string.Join (";", parse);
			Console.WriteLine ("Noviq string e:\n" + list1 + "\n\n");
		}
	}
}
