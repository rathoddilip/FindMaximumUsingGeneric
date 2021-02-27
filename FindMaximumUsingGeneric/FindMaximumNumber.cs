﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximumUsingGeneric
{
    public class FindMaximumNumber
    {
        public int FindMaximumNum(int num1, int num2, int num3)
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
        public float FindMaximumNum(float num1, float num2, float num3)
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
        public string FindMaximumString(string str1, string str2, string str3)
        {
            if (str1.CompareTo(str2) > 0 && str1.CompareTo(str3) > 0)
            {
                return str1;
            }
            else if (str2.CompareTo(str1) > 0 && str2.CompareTo(str3) > 0)
            {
                return str2;
            }
            else if (str3.CompareTo(str1) > 0 && str3.CompareTo(str2) > 0)
            {
                return str3;
            }
            throw new FindMaximumNumberException("All strings are Same");
        }
       
    }
}
