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
			if (b == 0)
			{
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
			if (Test_Int(a) == false || a < 0)
			{
				throw new ArgumentException();
			}
			if (a == 0 || a == 1)
			{
				return 1;
			}
			int f = 1;
			for (int i = 1; i <= a; i++)
			{
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
			if (Test_Int(n) == false || n < 0)
			{
				throw new ArgumentException();
			}
			if (n == 0)
			{
				return 1;
			}
			double vysledek = x;
			for (int i = 0; i < n - 1; i++)
			{
				vysledek = math.Nasob(vysledek, x);
			}
			return vysledek;
		}
		/// <summary>
		/// Pocita N-tou odmocninu pomoci kraceni mezi, presnost je 50 iteraci
		/// </summary>
		/// <param name="x">Zaklad</param>
		/// <param name="n">N-ta odmocnina</param>
		/// <returns>Vraci odmocninu</returns>
		public static double Odmocnina(double x, int n)
		{
			if (Test_Int(n) == false || n < 0 || x < 0)
			{
				throw new ArgumentException();
			}
			double horni_mez = x;
			double dolni_mez = 0;

			double vysledek = x / 2;
			double k = math.Umocnit(vysledek, n);
			for (int i = 0; i < 500; i++)
			{
				if (k > x)
				{
					horni_mez = vysledek;
					vysledek = vysledek - ((horni_mez - dolni_mez) / 2);
				}
				else
				{
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
			double cf = 0;
			double b = 1;
			for (int i = 15; i > 0; i--)
			{
				double a = (2 * i - 1) / x;
				cf = b / (a - cf);
			}
			return cf;
		}
		/// <summary>
		/// Zpracovava jednoduchy vyraz (+-*/) podle matematickych priorit
		/// </summary>
		/// <param name="vyraz">vyraz typu string</param>
		/// <returns>vraci vysledek jako jedno cislo typu string (pro kompatibilitu s dalsimi funkcemi)</returns>
		public static string Zpracovat_Vyraz(string vyraz)
		{
			//vyraz = "0" + vyraz;
			while (vyraz.Contains('*'))
			{
				int index = vyraz.IndexOf('*');

				string target = "+-*/";
				char[] anyOf = target.ToCharArray();

				int indexL = vyraz.Substring(0, index).LastIndexOfAny(anyOf);
				double cislo1;
				if (indexL == -1)
				{
					cislo1 = Convert.ToDouble(vyraz.Substring(indexL + 1, index - indexL - 1));
				}
				else
				{
					if (vyraz[indexL] == '-' || vyraz[indexL] == '+')
					{
						cislo1 = Convert.ToDouble(vyraz.Substring(indexL, index - indexL));
						indexL--;
					}
					else
					{
						cislo1 = Convert.ToDouble(vyraz.Substring(indexL + 1, index - indexL - 1));
					}
				}

				string tmp = vyraz.Substring(index, vyraz.Length - index);
				int indexR;
				if (tmp[1] == '-' || tmp[1] == '+')
				{
					indexR = tmp.IndexOfAny(anyOf, 2);
				}
				else
				{
					indexR = tmp.IndexOfAny(anyOf, 1);
				}
				
				if (indexR == -1)
					indexR = tmp.Length;
				tmp = tmp.Substring(1, indexR - 1);
				double cislo2 = Convert.ToDouble(tmp);
				vyraz = vyraz.Remove(indexL + 1, indexR + index - indexL - 1);
				vyraz = vyraz.Insert(indexL + 1, (cislo1 * cislo2).ToString());
				if ((cislo1 / cislo2) >= 0)
				{
					vyraz = vyraz.Insert(indexL + 1, "+");
				}
			}
			while (vyraz.Contains('/'))
			{
				int index = vyraz.IndexOf('/');

				string target = "+-*/";
				char[] anyOf = target.ToCharArray();

				int indexL = vyraz.Substring(0, index).LastIndexOfAny(anyOf);
				double cislo1;
				if (indexL == -1)
				{
					cislo1 = Convert.ToDouble(vyraz.Substring(indexL + 1, index - indexL - 1));
				}
				else
				{
					if (vyraz[indexL] == '-' || vyraz[indexL]=='+')
					{
						cislo1 = Convert.ToDouble(vyraz.Substring(indexL, index - indexL));
						indexL--;
					}
					else
					{
						cislo1 = Convert.ToDouble(vyraz.Substring(indexL + 1, index - indexL - 1));
					}
				}



				string tmp = vyraz.Substring(index, vyraz.Length - index);
				int indexR;
				if (tmp[1] == '-' || tmp[1]=='+')
				{
					indexR = tmp.IndexOfAny(anyOf, 2);
				}
				else
				{
					indexR = tmp.IndexOfAny(anyOf, 1);
				}


				if (indexR == -1)
					indexR = tmp.Length;
				tmp = tmp.Substring(1, indexR - 1);
				double cislo2 = Convert.ToDouble(tmp);
				vyraz = vyraz.Remove(indexL + 1, indexR + index - indexL - 1);

				vyraz = vyraz.Insert(indexL + 1, (cislo1 / cislo2).ToString());
				if ((cislo1 / cislo2) >= 0)
				{
					
					vyraz = vyraz.Insert(indexL + 1, "+");
				}
			}
			while (vyraz.Contains('+'))
			{
				string target = "+-*/";
				char[] anyOf = target.ToCharArray();
				int index = vyraz.IndexOf('+');
				if (index == 0)
				{
					vyraz = vyraz.Remove(0, 1);
					continue;
				}

				int indexL = vyraz.Substring(0, index).LastIndexOfAny(anyOf);
				double cislo1;
				if (indexL == -1)
				{
					cislo1 = Convert.ToDouble(vyraz.Substring(indexL + 1, index - indexL - 1));
				}
				else
				{
					if (vyraz[indexL] == '-' || vyraz[indexL] == '+')
					{
						cislo1 = Convert.ToDouble(vyraz.Substring(indexL, index - indexL));
						indexL--;
					}
					else
					{
						cislo1 = Convert.ToDouble(vyraz.Substring(indexL + 1, index - indexL - 1));
					}
				}



				string tmp = vyraz.Substring(index, vyraz.Length - index);
				int indexR;
				if (tmp[1] == '-' || tmp[1] == '+')
				{
					indexR = tmp.IndexOfAny(anyOf, 2);
				}
				else
				{
					indexR = tmp.IndexOfAny(anyOf, 1);
				}

				if (indexR == -1)
					indexR = tmp.Length;
				tmp = tmp.Substring(1, indexR - 1);
				double cislo2 = Convert.ToDouble(tmp);
				vyraz = vyraz.Remove(indexL + 1, indexR + index - indexL - 1);

				vyraz = vyraz.Insert(indexL + 1, (cislo1 + cislo2).ToString());
				if ((cislo1 + cislo2) >= 0)
				{

					vyraz = vyraz.Insert(indexL + 1, "+");
				}


			}
			while (vyraz.Contains('-'))
			{
				int index = vyraz.IndexOf('-');
				int count = vyraz.Split('-').Length - 1;

				if (index == 0)
				{
					index = vyraz.IndexOf('-', index + 1);
				}

				if (count == 1 && vyraz[0] == '-')
					return vyraz;
				string target = "+-*/";
				char[] anyOf = target.ToCharArray();

				if (index == 0)
				{
					vyraz = vyraz.Remove(0, 1);
					continue;
				}

				int indexL = vyraz.Substring(0, index).LastIndexOfAny(anyOf);
				double cislo1;
				if (indexL == -1)
				{
					cislo1 = Convert.ToDouble(vyraz.Substring(indexL + 1, index - indexL - 1));
				}
				else
				{
					if (vyraz[indexL] == '-' || vyraz[indexL] == '+')
					{
						cislo1 = Convert.ToDouble(vyraz.Substring(indexL, index - indexL));
						indexL--;
					}
					else
					{
						cislo1 = Convert.ToDouble(vyraz.Substring(indexL + 1, index - indexL - 1));
					}
				}



				string tmp = vyraz.Substring(index, vyraz.Length - index);
				int indexR;
				if (tmp[1] == '-' || tmp[1] == '+')
				{
					indexR = tmp.IndexOfAny(anyOf, 2);
				}
				else
				{
					indexR = tmp.IndexOfAny(anyOf, 1);
				}

				if (indexR == -1)
					indexR = tmp.Length;
				tmp = tmp.Substring(1, indexR - 1);
				double cislo2 = Convert.ToDouble(tmp);
				vyraz = vyraz.Remove(indexL + 1, indexR + index - indexL - 1);

				vyraz = vyraz.Insert(indexL + 1, (cislo1 - cislo2).ToString());
				if ((cislo1 - cislo2) >= 0)
				{

					vyraz = vyraz.Insert(indexL + 1, "+");
				}

			}
			return vyraz;
		}

	}
}
