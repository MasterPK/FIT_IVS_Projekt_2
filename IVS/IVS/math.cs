using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
	class math
	{
		/*
		 * @brief Secte dve cisla
		 * @param a,b Vstupy cisel
		 * @return soucet vstupu
		 */
		public static double Soucet(double a, double b)
		{
			return a + b;
		}
		public static double Rozdil(double a, double b)
		{
			return a - b;
		}
		public static double Nasob(double a, double b)
		{
			return a * b;
		}
		public static double Podil(double a, double b)
        {
			if (b == 0) {
				throw new DivideByZeroException();
			}
			return a / b;
		}

	}
}
