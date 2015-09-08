using System;

namespace BoolExplore2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] _i = new int[] { 4, 3, 2 };

			int _ui = 0; 
			string _input = "0";

			Console.WriteLine ("Molq vuvedete indeks:");
			_input = Console.ReadLine ();

			bool _check01 = int.TryParse (_input, out _ui);

//			_ui = (_ui <= _i.Length ) ? _ui : 3;
//			_ui = (_ui > 0 ) ? _ui : 1; 


			switch (_ui){
			case 1:
				{
					Console.WriteLine ("1vi element ot masiva: ");
					Console.WriteLine (_i [_ui - 1]);
					break ;
				}

				case 2:
				{
					Console.WriteLine ("2ri element ot masiva: ");
					Console.WriteLine (_i [_ui - 1]);
					break ;
				}
				case 3:
				{
					Console.WriteLine ("3ti element ot masiva: ");
					Console.WriteLine (_i [_ui - 1]);
					break ;
				}
				default:
				{
					Console.WriteLine ("Masiva nqma stoinost za tozi indeks. \nOpitaite s indeks mejdu 1 i 3.\n\n ");
					break ;
				}
			}
		}
	}
}





//			if (_check01) {
//				Console.WriteLine (_i [_ui - 1]);
