﻿using System;

namespace ReadFromCommandLine
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Дефиниране на променливи
			int a = 5, b = 0; 

			//Въвеждане на входни параметри
			Console.Write ( "Molq vuvedete a: " );
			b = Convert.ToInt32	 ( Console.ReadLine () );


			//Печат на резултат
			Console.WriteLine ( "Rezultata a + b e " +  (a + b).ToString () + "\n\n\n");
		}
	}
}
