using NUnit.Framework;
using FindMaximumUsingGeneric;
namespace FindMaximumNumberNUnitTestProject
{
    public class Tests
    {

        FindMaximumNumber findMaximumNumber;
        FindMaximumGenericClass<int> findMaximumGenericClassInt;
        FindMaximumGenericClass<float> findMaximumGenericClassFlaot;
        FindMaximumGenericClass<string> findMaximumGenericClassString;
        FindMaximumGenericClass<int> findMaximumGenericClassPara;
        FindMaximumGenericClass<int> findMaximumGenericClassArray;
        [SetUp]
        public void Setup()
        {
            findMaximumNumber = new FindMaximumNumber();
            findMaximumGenericClassInt = new FindMaximumGenericClass<int>();
            findMaximumGenericClassFlaot = new FindMaximumGenericClass<float>();
            findMaximumGenericClassString = new FindMaximumGenericClass<string>();
            findMaximumGenericClassPara = new FindMaximumGenericClass<int>(66,77, 88);
            findMaximumGenericClassArray= new FindMaximumGenericClass<int>(new int[]{66,44,77,55,33 });
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
        /// TC 2.3 Max number at 3rd position and return the same number 
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="num3"></param>
        [TestCase(77.0f, 66.0f, 88.0f)]
        public void GivenFloatThirdNumberMaxReturnMaximum(float num1, float num2, float num3)
        {
            Assert.AreEqual(num3, findMaximumNumber.FindMaximumNum(num1, num2, num3));
        }
        /// <summary>
        /// TC 3.1 Max string at 1st position and return the same number
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <param name="str3"></param>
        [TestCase("Peach", "Apple", "Banana")]
        public void GivenFirstStringMaxReturnMaximum(string str1, string str2, string str3)
        {
            Assert.AreEqual(str1, findMaximumNumber.FindMaximumString(str1, str2, str3));
        }
        /// <summary>
        /// TC 3.2 Max string at 2nd position and return the same number
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <param name="str3"></param>
        [TestCase("Apple", "Peach", "Banana")]
        public void GivenSecondStringMaxReturnMaximum(string str1, string str2, string str3)
        {
            Assert.AreEqual(str2, findMaximumNumber.FindMaximumString(str1, str2, str3));
        }
        /// <summary>
        /// TC 3.3 Max string at 3rd position and return the same number
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <param name="str3"></param>
        [TestCase("Apple", "Banana", "Peach")]
        public void GivenThirdStringMaxReturnMaximum(string str1, string str2, string str3)
        {
            Assert.AreEqual(str3, findMaximumNumber.FindMaximumString(str1, str2, str3));
        }
        //---------------------------------------------------------------------------------------------------------------------------------
        // Generic class and generic method test
        //UC-3 Refactor1
        /// <summary>
        /// TC 1.1 Max number at 1st position and return the same number 
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="num3"></param>
        [TestCase(88, 77, 66)]
        public void GivenFirstNumberMaxReturnMaximumGeneric(int num1, int num2, int num3)
        {
            Assert.AreEqual(num1, findMaximumGenericClassInt.FindMaximumNum(num1, num2, num3));
        }
        /// <summary>
        /// TC 1.2 Max number at 2nd position and return the same number 
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="num3"></param>
        [TestCase(77, 88, 66)]
        public void GivenSecondNumberMaxReturnMaximumGeneric(int num1, int num2, int num3)
        {
            Assert.AreEqual(num2, findMaximumGenericClassInt.FindMaximumNum(num1, num2, num3));
        }
        /// <summary>
        /// TC 1.3 Max number at 3rd position and return the same number 
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="num3"></param>
        [TestCase(77, 66, 88)]
        public void GivenThirdNumberMaxReturnMaximumGeneric(int num1, int num2, int num3)
        {
            Assert.AreEqual(num3, findMaximumGenericClassInt.FindMaximumNum(num1, num2, num3));
        }
        /// <summary>
        /// TC 2.1 Max number at 1st position and return the same number 
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="num3"></param>
        [TestCase(88.0f, 77.0f, 66.0f)]
        public void GivenFloatFirstNumberMaxReturnMaximumGeneric(float num1, float num2, float num3)
        {
            Assert.AreEqual(num1, findMaximumGenericClassFlaot.FindMaximumNum(num1, num2, num3));
        }
        /// <summary>
        /// TC 2.2 Max number at 2nd position and return the same number 
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="num3"></param>
        [TestCase(77.0f, 88.0f, 66.0f)]
        public void GivenFloatSecondNumberMaxReturnMaximumGeneric(float num1, float num2, float num3)
        {
            Assert.AreEqual(num2, findMaximumGenericClassFlaot.FindMaximumNum(num1, num2, num3));
        }
        /// <summary>
        /// TC 2.3 Max number at 3rd position and return the same number 
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="num3"></param>
        [TestCase(77.0f, 66.0f, 88.0f)]
        public void GivenFloatThirdNumberMaxReturnMaximumGeneric(float num1, float num2, float num3)
        {
            Assert.AreEqual(num3, findMaximumGenericClassFlaot.FindMaximumNum(num1, num2, num3));
        }
        /// <summary>
        /// TC 3.1 Max string at 1st position and return the same number
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <param name="str3"></param>
        [TestCase("Peach", "Apple", "Banana")]
        public void GivenFirstStringMaxReturnMaximumGeneric(string str1, string str2, string str3)
        {
            Assert.AreEqual(str1, findMaximumGenericClassString.FindMaximumNum(str1, str2, str3));
        }
        /// <summary>
        /// TC 3.2 Max string at 2nd position and return the same number
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <param name="str3"></param>
        [TestCase("Apple", "Peach", "Banana")]
        public void GivenSecondStringMaxReturnMaximumGeneric(string str1, string str2, string str3)
        {
            Assert.AreEqual(str2, findMaximumGenericClassString.FindMaximumNum(str1, str2, str3));
        }
        /// <summary>
        /// TC 3.3 Max string at 3rd position and return the same number
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <param name="str3"></param>
        [TestCase("Apple", "Banana", "Peach")]
        public void GivenThirdStringMaxReturnMaximumGeneric(string str1, string str2, string str3)
        {
            Assert.AreEqual(str3, findMaximumGenericClassString.FindMaximumNum(str1, str2, str3));
        }
        //-------------------------------------------------------------------------------------------------------------------------------------
        //UC-3 Refactor2
        [Test]
        public void GiveGenericParaClassReturnMax()
        {
            Assert.AreEqual(88, findMaximumGenericClassPara.TestMaximum());
        }
        /// <summary>
        /// UC-4 taken random array and sort it and find max
        /// </summary>
        [Test]
        public void GivenRandomArrayReturnMax()
        {
            Assert.AreEqual(77, findMaximumGenericClassArray.MaximumArray());
        }
        /// <summary>
        /// UC-5 Called other generic method jnternally
        /// </summary>
        [Test]
        public void CalledInternallyTestMaxMethodReturnMax()
        {
            Assert.AreEqual(88, findMaximumGenericClassPara.PrintMax());
        }
    }
}