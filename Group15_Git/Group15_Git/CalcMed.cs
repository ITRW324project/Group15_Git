﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group15_Git
{
    class CalcMed
    {
        public double calcMed(int i)
        {
            Random n = new Random();
            int[] array = new int[i];

            for (int j = 0; j < i; j++)
            {
                array[j] = n.Next(1, 50);
            }

            return array[i / 2];
        }
    }
}
