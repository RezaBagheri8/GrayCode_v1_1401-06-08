﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrayCode
{
    public class Solution
    {
        public IList<int> GrayCode(int n)
        {
            string[] x = { "", "" };
            int c = 1;
            string[] result = new string[2];
            int counter = 1;

            int faekN = n;
            while (faekN > 0)
            {
                int j = 0;
                for (int i = 0; i < result.Length / 2; i++)
                {
                    result[j] = "0" + x[i];
                    j++;
                    c++;
                }

                int k = c / 2;
                for (int i = x.Length - 1; k < c; i--)
                {
                    result[k] = "1" + x[i];
                    k++;
                }

                x = new string[result.Length];
                for (int i = 0; i < result.Length; i++)
                {

                    x[i] = result[i];
                }

                counter++;
                result = new string[Convert.ToInt32(Math.Pow(2, counter))];
                faekN--;
            }

            int[] decimalNumbers = new int[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                decimalNumbers[i]  = Convert.ToInt32(x[i], 2);
            }

            return decimalNumbers;
        }
        
        //Best solution for this question
        //public IList<int> GrayCode(int n)
        //{
            //List<int> grayCode = new List<int>() { 0, 1 };
            //int ithBit = 0;
            //while (++ithBit < n)
                //for (int i = grayCode.Count - 1; i >= 0; i--)
                //{
                    //string x = Convert.ToString(1 << ithBit, toBase: 2);
                    //int y = grayCode[i] | int.Parse(Convert.ToString(x));
                    //grayCode.Add(grayCode[i] | 1 << ithBit);
                //}
            //return grayCode;
        //}
    }
}
