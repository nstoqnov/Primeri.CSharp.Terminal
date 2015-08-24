using System;

namespace Modul02
{
	class MainClass
	{
		public static void Main (string[] args)
		{
		    //Дефиниране на променливи
			int a = 0, b = 0;
			int sum = 0;
			string program_name = "Modul02 - primeri";
			string program_version = "1.0";

			//Събиране на числа
			a = 10;
			b = 5;
			sum = a + b;

			//Данни за програмата
			Console.WriteLine ( program_name );
			Console.WriteLine ( "Versiq: " + program_version + "\n\n" );

			//Писане в конзола
			Console.Write ( a );
			Console.Write (" + ");
			Console.Write ( b );
			Console.Write (" = ");
			Console.WriteLine ( sum );

			//Допълнителни оператори
			Console.WriteLine ("\nIzpolzvane na +=");
			a += b;
			Console.WriteLine ( a );
	
			Console.WriteLine ("\nIzpolzvane na -=");
			a -= b;
			Console.WriteLine ( a );

			Console.WriteLine ("\nIzpolzvane na *=");
			a *= b;
			Console.WriteLine ( a );

			Console.WriteLine ("\nIzpolzvane na ++");
			a++;
			Console.WriteLine ( a );

			a = 15; b = 10;

			Console.WriteLine ("\nStandartno delene");
			Console.WriteLine ( a / b);    //1

			Console.WriteLine ("\nHvashtane na ostatuk");
			Console.WriteLine ( a % b );   //5, 1.5


		}
	}
}

