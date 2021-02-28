using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximumUsingGeneric
{
    public class FindMaximumGenericClass<T> where T : IComparable
    {


        public T variable1, variable2, variable3;
        public T[] valueArray;
        /// <summary>
        /// Parameterised Constructor
        /// </summary>
        /// <param name="variable1"></param>
        /// <param name="variable2"></param>
        /// <param name="variable3"></param>
        public FindMaximumGenericClass(T variable1, T variable2, T variable3)
        {
            this.variable1 = variable1;
            this.variable2 = variable2;
            this.variable3 = variable3;
        }
        public FindMaximumGenericClass(T[] valueArray)
        {
            this.valueArray = valueArray;
        }
        public FindMaximumGenericClass()
            {

            }
        /// <summary>
        /// Generic method
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="num3"></param>
        /// <returns></returns>
        public T FindMaximumNum(T num1, T num2, T num3)
        {
            if (num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0)
            {
                return num1;
            }
            else if (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0)
            {
                return num2;
            }
            else if (num3.CompareTo(num1) > 0 && num3.CompareTo(num2) > 0)
            {
                return num3;
            }
            else
                throw new FindMaximumNumberException("All number are same");
        }
        /// <summary>
        /// Finding max 
        /// </summary>
        /// <returns></returns>
        public T TestMaximum()
        {
            return FindMaximumNum(this.variable1, this.variable2, variable3);
        }
        /// <summary>
        /// Sorting random array
        /// </summary>
        /// <returns></returns>
        public T MaximumArray()
        {
            Array.Sort(valueArray);
            return valueArray[valueArray.Length - 1];
        }
        public T PrintMax()
        {
            return TestMaximum();
        }
    }
}
