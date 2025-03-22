using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMaths
{
	public class BasicMath
	{
		public double add(double x, double y) { return x + y; }
		public double subtract(double x, double y) { return x - y; }
		public double divide(double x, double y) { return x / y; }
		public double multiply(double x, double y) { return x * y; }
		public BasicMath() { }
		public static void Main()
		{
			BasicMath s = new BasicMath();
		}
	}
}
