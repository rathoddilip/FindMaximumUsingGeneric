using NUnit.Framework;
using FindMaximumUsingGeneric;
namespace FindMaximumNumberNUnitTestProject
{
    public class Tests
    {
        FindMaximumNumber findMaximumNumber;
        [SetUp]
        public void Setup()
        {
            findMaximumNumber = new FindMaximumNumber();
        }
        /// <summary>
        /// TC 1.1 Max number at 1st position and return the same number 
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="num3"></param>
        [TestCase(88, 77, 66)]
        public void GivenFirstNumberMaxReturnMaximum(int num1, int num2, int num3)
        {
            Assert.AreEqual(num1, findMaximumNumber.FindMaximumNum(num1, num2, num3));
        }
        /// <summary>
        /// TC 1.2 Max number at 2nd position and return the same number 
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="num3"></param>
        [TestCase(77, 88, 66)]
        public void GivenSecondNumberMaxReturnMaximum(int num1, int num2, int num3)
        {
            Assert.AreEqual(num2, findMaximumNumber.FindMaximumNum(num1, num2, num3));
        }
        /// <summary>
        /// TC 1.3 Max number at 3rd position and return the same number 
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="num3"></param>
        [TestCase(77, 66, 88)]
        public void GivenThirdNumberMaxReturnMaximum(int num1, int num2, int num3)
        {
            Assert.AreEqual(num3, findMaximumNumber.FindMaximumNum(num1, num2, num3));
        }
        /// <summary>
        /// TC 2.1 Max number at 1st position and return the same number 
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="num3"></param>
        [TestCase(88.0f, 77.0f, 66.0f)]
        public void GivenFloatFirstNumberMaxReturnMaximum(float num1, float num2, float num3)
        {
            Assert.AreEqual(num1, findMaximumNumber.FindMaximumNum(num1, num2, num3));
        }
        /// <summary>
        /// TC 2.2 Max number at 2nd position and return the same number 
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="num3"></param>
        [TestCase(77.0f, 88.0f, 66.0f)]
        public void GivenFloatSecondNumberMaxReturnMaximum(float num1, float num2, float num3)
        {
            Assert.AreEqual(num2, findMaximumNumber.FindMaximumNum(num1, num2, num3));
        }
        /// <summary>
        /// TC 2.2 Max number at 2nd position and return the same number 
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="num3"></param>
        [TestCase(77.0f, 66.0f, 88.0f)]
        public void GivenFloatThirdNumberMaxReturnMaximum(float num1, float num2, float num3)
        {
            Assert.AreEqual(num3, findMaximumNumber.FindMaximumNum(num1, num2, num3));
        }
    }
}