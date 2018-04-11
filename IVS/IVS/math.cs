using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
	public class math
	{
		/// <summary>
		/// Testuje jestli zadane cislo je cele
		/// </summary>
		/// <param name="a"></param>
		/// <returns>Vraci True pokud je cislo cele, jinak false</returns>
		private static bool Test_Int(double a)
		{
			if ((a % 1) == 0)
				return true;
			else
				return false;
		}
		/// <summary>
		/// Soucet dvou cisel na vstupu
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns>Soucet vstupu</returns>
		public static double Soucet(double a, double b)
		{
			return a + b;
		}
		/// <summary>
		/// Rozdil dvou cisel na vstupu
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns>Rozdil vstupu</returns>
		public static double Rozdil(double a, double b)
		{
			return a - b;
		}
		/// <summary>
		/// Nasobeni dvou cisel na vstupu
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns>Nasobeni vstupu</returns>
		public static double Nasob(double a, double b)
		{
			return a * b;
		}
		/// <summary>
		/// Deleni dvou cisel na vstupu
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <exception cref="DivideByZeroException">Nastavi pri deleni nulou</exception>
		/// <returns>Deleni vstupu</returns>
		public static double Podil(double a, double b)
		{
			if (b == 0) {
				throw new DivideByZeroException();
			}
			return a / b;
		}
		/// <summary>
		/// Vypocita faktorial ze zadaneho cisla
		/// </summary>
		/// <param name="a"></param>
		/// <exception cref="ArgumentException">Pokud vstup neni prirozene cislo</exception>
		/// <returns>Faktorial vstupu</returns>
		public static int Faktorial(double a)
		{
			if (Test_Int(a) == false || a < 0) {
				throw new ArgumentException();
			}
			if (a == 0 || a == 1) {
				return 1;
			}
			int f = 1;
			for (int i = 1; i <= a; i++) {
				f *= i;
			}
			return f;
		}
		/// <summary>
		/// Vypocita mocninu vstupniho cisla x umocneneho prirozenym cislem n
		/// </summary>
		/// <param name="x">Zaklad</param>
		/// <param name="n">Mocnitel</param>
		/// <exception cref="ArgumentException">N musi byt prirozene cislo</exception>
		/// <returns>Vraci N-tou mocninu vstupu</returns>
		public static double Umocnit(double x, double n)
		{
			if (Test_Int(n) == false || n < 0) {
				throw new ArgumentException();
			}
			if (n == 0) {
				return 1;
			}
			double vysledek=x;
			for (int i = 0; i < n-1; i++) {
				vysledek = math.Nasob(vysledek,x);
			}
			return vysledek;
		}
		/// <summary>
		/// Pocita N-tou odmocninu pomoci kraceni mezi, presnost urcuje pocet iteraci
		/// </summary>
		/// <param name="x">Zaklad</param>
		/// <param name="n">N-ta odmocnina</param>
		/// <param name="iter">Iteraci</param>
		/// <returns>Vraci odmocninu</returns>
		public static double Odmocnina(double x, int n, int iter)
		{
			if (Test_Int(n) == false || n < 0 || x<0) {
				throw new ArgumentException();
			}
			double horni_mez = x;
			double dolni_mez = 0;

			double vysledek = x / 2;
			double k = math.Umocnit(vysledek, n);
			for (int i = 0; i < iter; i++) {
				if (k > x) {
					horni_mez = vysledek;
					vysledek = vysledek - ((horni_mez - dolni_mez) / 2);
				}
				else {
					dolni_mez = vysledek;
					vysledek = vysledek + ((horni_mez - dolni_mez) / 2);
				}
				k = math.Umocnit(vysledek, n);
			}
			return vysledek;
		}
		/// <summary>
		/// Vypocita Tangens pomoci metody zretezeneho zlomku
		/// </summary>
		/// <param name="x">Uhel v radianech</param>
		/// <returns>´Vraci tangens s presnosti mensi jak 10^-8</returns>
		public static double Tangens(double x)
		{
			//TODO definicni obor
			double cf = 0;
			double b = 1;
			for (int i = 15; i > 0; i--) {
				double a = (2 * i - 1) / x;
				cf = b / (a - cf);
			}
			return cf;
		}
	}
}
