using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximumUsingGeneric
{
   public class FindMaximumGenericClass<T> where T : IComparable
    {
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

    }
}
