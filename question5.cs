﻿using System;


namespace assignment
{
    internal class ques5
    {

        static void Main(string[] args)
        {

            Console.WriteLine(first_last("Apple"));

        }
        public static string first_last(string ustr)
        {
            return ustr.Length > 1
                ? ustr.Substring(ustr.Length - 1) + ustr.Substring(1, ustr.Length - 2) + ustr.Substring(0, 1) : ustr;
        }

    }
}