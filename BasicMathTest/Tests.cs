using BasicMaths;

namespace BasicMathTest
{
	[TestClass]
	public class Tests
	{
		[TestMethod]
		public void Test_AddMethod()
		{
			BasicMath calculate = new BasicMath();
			double result = calculate.add(23.1, 43.1);
			Assert.AreEqual(66.2, result);
		}
		[TestMethod]
		public void Test_DivideMethod()
		{
			BasicMath calculate = new BasicMath();
			double result = calculate.divide(26.6, 2);
			Assert.AreEqual(13.3, result);
		}
		[TestMethod]
		public void Test_MultiplyMethod()
		{
			BasicMath calculate = new BasicMath();
			double result = calculate.multiply(9, 9);
			Assert.AreEqual(81, result);
		}
		[TestMethod]
		public void Test_SubtractMethod()
		{
			BasicMath calculate = new BasicMath();
			double result = calculate.subtract(43, 23);
			Assert.AreEqual(20, result);
		}
	}
}