﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GandaloevMA.Sprint0.Task2.V0.Lib;
namespace Tyuiu.GandaloevMA.Sprint0.Task2.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.GetMessage("Мага"));
            Console.ReadKey();
        }
    }
}
