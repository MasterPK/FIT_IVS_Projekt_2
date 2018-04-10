using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
	class math
	{
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
		
	}
}
