using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MathLibrary;

namespace Smerodatna_odhylka
{
	class Program
	{
		static void Main(string[] args)
		{
			//Console.WriteLine(args.Length);
			//Console.WriteLine("Vypocet odchylky\nZadejte cisla oddelena ';' napr: '1,1;2;3;4;5;6'");
			//string text = Console.ReadLine();

			if (args.Length < 1)
			{
				Console.WriteLine("Chyba vstupu!", "Chyba");
				return;
			}

			List<double> pole = new List<double>();
			int pocet_cisel = 0;
			foreach (string x in args)
			{
				try
				{
					pole.Add(Convert.ToDouble(x));
				}
				catch (FormatException ex)
				{
					Console.WriteLine("Chyba: " + ex.Message, "Chyba");
					return;
				}
				pocet_cisel++;
			}
			try
			{
				Console.WriteLine(math.odchylka_s(pocet_cisel, pole).ToString());
			}
			catch (Exception ex)
			{
				Console.WriteLine("Chyba: " + ex.Message, "Chyba");
				return;
			}
			//Console.WriteLine("Odchylka = "+text);
			//Console.WriteLine("Stisknutim jakekoliv klavesy ukoncite program...");
			Console.ReadLine();
		}

	}
}
