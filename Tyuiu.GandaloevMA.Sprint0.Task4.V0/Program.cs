﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GandaloevMA.Sprint0.Task4.V0.Lib;
namespace Tyuiu.GandaloevMA.Sprint0.Task4.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Метод сложения Addition
            Console.WriteLine(DataService.Addition(1, 5));
            //Метод вычетания Subtraction
            Console.WriteLine(DataService.Subtraction(10, 5));
            //Метод умножения Multiplication
            Console.WriteLine(DataService.Multiplication(3, 5));
            //Метод деления Division
            Console.WriteLine(DataService.Division(10, 5));
            // Задержка экрана 
            Console.ReadKey();
        }
    }
}
