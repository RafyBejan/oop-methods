﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopMethods
{
    internal static class MathHelper
    {
        public static int Factorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("You must specify a positive numeric value");
            }

            if (n <= 1)
            {
                return 1;
            }

            return n * Factorial(n - 1);
        }
    }
}