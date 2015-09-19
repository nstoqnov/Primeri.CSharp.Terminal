using System;

namespace ClassExplorer
{
	public class person
	{
		public string simpleString = "Testova promenliva ot klas";
		public string user = "";

		private string hiddenString = "";

		public person (string _ini)
		{
			if (_ini == "password1") hiddenString = "Potrebitel1";
			if (_ini == "password2") hiddenString = "Potrebitel2";

			user = hiddenString;

			if ( hiddenString.Length > 0 )
				simpleString = "Dobre doshli otnovo!,  " + user + "!";
			else 
				simpleString = "Vie nqmate dostyp do tazi programa";

		
		}
	}



	class MainClass
	{

		public static void Main (string[] args)
		{
			Console.Write ("Parola:"); string _user = Console.ReadLine ();

			//Дефиниране на клас
			person _person = new person(_user);

			//Достъпване на клас
			Console.WriteLine ( _person.simpleString );
		}
	}
}
