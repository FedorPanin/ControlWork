﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите элементы массива через запятую:");
            string input = Console.ReadLine();
            string[] array = input.Split(',');

            string[] newArray = new string[array.Length];
            int newIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= 3)
                {
                    newArray[newIndex] = array[i];
                    newIndex++;
                }
            }
        }
    }
}
