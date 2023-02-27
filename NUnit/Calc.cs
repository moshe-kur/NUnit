using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit
{
	public class Calc
	{
		public int Plus(int num1,int num2)
		{
			return num1 + num2;
		}
		public int Minus(int num1, int num2)
		{
			return num1 - num2;
		}
		public int Mult(int num1, int num2)
		{
			return num1 * num2;
		}
		public int Div(int num1, int num2)
		{
			try
			{
				return num1 / num2;
			}
			catch (Exception ex)
			{

				return 0;
			}
		}
		public int Print(int num1, int num2,string action)
		{
			return num1 + num2;
		}
	}
}
