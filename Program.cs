using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("1 - Ввести запрос\n2 - Посмотреть запросы\n3 - Удалить запрос");
			string pick = Console.ReadLine();

			string request = "NoNe";


			switch(pick)
			{
				case "1":
					Console.WriteLine("Введите запрос");
					request = Console.ReadLine();
					Main(args);
					break;

				case "2":
					Console.WriteLine(request);
					Main(args);
					break;

				case "3":
					request = "";
					Main(args);
					break;

				default:
					Console.WriteLine("Выбери одно из трех, свинья");
					Main(args);
					break;
			}

			Console.ReadLine();

		}
	}
