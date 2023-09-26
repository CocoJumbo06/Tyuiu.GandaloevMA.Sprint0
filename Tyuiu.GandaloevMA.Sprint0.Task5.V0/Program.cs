using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GandaloevMA.Sprint0.Task5.V0.Lib;
namespace Tyuiu.GandaloevMA.Sprint0.Task5.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Метод сложения Addition
            Console.WriteLine("A+B="+DataService.Addition(1, 5));
            //Метод вычетания Subtraction
            Console.WriteLine("A-B=" + DataService.Subtraction(10, 5));
            //Метод умножения Multiplication
            Console.WriteLine("A*B=" + DataService.Multiplication(3, 5));
            //Метод деления Division
            Console.WriteLine("A/B=" + DataService.Division(10, 5));
            // Задержка экрана 
            Console.ReadKey();
        }
    }
}
