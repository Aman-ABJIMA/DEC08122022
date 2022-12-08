﻿using System;
using System.Diagnostics.CodeAnalysis;

namespace PARAM
{
    class PARAM
    {
        static void Main(string[] args)
        {
            int result = Process(10, 20, 30, 40, 50);
            Console.WriteLine(result);

        }
      
        static int Process(params int[] a) //use of params: It will allow the fuction to take multiple values 
        {
            int sum = 0;
            foreach(int i in a)
            {
              sum=sum+i; 
            }
            return sum;
        }

       
    }
}
