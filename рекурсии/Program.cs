using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace рекурсии
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 1: Задайте значения M и N.Напишите программу, которая выведет все натуральные числа в промежутке
            //от M до N. Использовать рекурсию, не использовать циклы.
            //Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
            //Задача 3: Задайте произвольный массив.Выведете его элементы, начиная с конца.Использовать рекурсию, не использовать циклы.
            int m, n;
            m = 10; n = 40;
            RecNatural(m, n);
        }
        static void RecNatural(int a,int b)
        {
            if (a == b +1)
                return;
            Console.WriteLine(a);
            RecNatural(a + 1,b);
        }

    }
}
