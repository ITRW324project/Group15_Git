﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group15_Git
{
    class Stats
    {
        public int count(int i)
        {
            Random n = new Random();

            int[] array = new int[i];

            for (int j = 0; j < i; j++)
            {
                array[j] = n.Next(1, 50);
            }

            return array[i];
        }

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

        public double calcMinimum(int i)
        {
            Random n = new Random();
            int[] array = new int[i];
            int smallest = 50;
            for (int j = 0; j < i; j++)
            {
                array[j] = n.Next(10, 50);
                smallest = array[j];
                if (array[j] < smallest)
                {
                    smallest = array[j];
                }
            }
            return smallest;
        }
    }
}
