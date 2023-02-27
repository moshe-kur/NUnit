using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NUnit.Test
{
	[TestFixture]
	internal class TastCalc
	{
		[Test]
		[Category("Calc Testing")]
		[Order(0)]
		public void RunTest()
		{
			int a = 10;
			int b = 11;
			int c = a + b;
			NUnit.Calc nUnit = new NUnit.Calc();
			Assert.That( nUnit.Plus(a, b), Is.InRange(10,100));
			Assert.That(nUnit.Plus(a, b), Is.LessThan(50));
			Assert.AreEqual(c, nUnit.Plus(a,b));


		}

		[Test , Ignore("Not finish")]
		[Category("Calc Testing")]
		[Order(5)]
		public void RunTest1()
		{
			int a = 10;
			int b = 11;
			int c = a + b;
			NUnit.Calc nUnit = new NUnit.Calc();
			Assert.AreEqual(c, nUnit.Plus(a, b),"Sould be Equal");
		}
		[Test]
		[Order(4)]

		public void RunTest2()
		{
			int a = 10;
			int b = 11;
			int c = a - b;
			NUnit.Calc nUnit = new NUnit.Calc();
			Assert.AreEqual(c, nUnit.Minus(a, b));
		}
		[Test]
		[Order(3)]
		public void RunTest3()
		{
			int a = 10;
			int b = 11;
			int c = a * b;
			NUnit.Calc nUnit = new NUnit.Calc();
			Assert.AreEqual(c, nUnit.Mult(a, b));
		}
		[Test]
		[Order(2)]

		public void RunTest4()
		{
			int a = 12;
			int b = 9;
			int c;
			try
			{
				 c = a / b;
			}
			catch (Exception ex)
			{

				c = 0;
			}
			NUnit.Calc nUnit = new NUnit.Calc();
			Assert.AreEqual(c, nUnit.Div(a, b));
		}
	}
}
