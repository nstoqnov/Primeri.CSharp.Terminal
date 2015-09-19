using System;

namespace ClassExplorer
{
	public class person
	{
		public string simplestring = "Testova promenliva ot klas";

		public person ()
		{
			simplestring = "Promqna na promelniva pri inicializaciq.";
		}
	}



	class MainClass
	{

		public static void Main (string[] args)
		{
			//Дефиниране на клас
			person _person = new person();

			//Достъпване на клас
			Console.WriteLine ( _person.simplestring );
		}
	}
}
