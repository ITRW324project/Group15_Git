﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group15_Git
{
    class DehanSum
    {
        public double generate_number(int i)
        {
            Random ran = new Random();
            int[] amount = new int[50];
            for (int j = 0; j < i; j++)
                amount[j] = ran.Next(1, 50);
            return amount.Max();

        }
    }
}
