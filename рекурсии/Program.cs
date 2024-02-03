using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace рекурсии
{
    internal class Program
    {
        static void Main()
        {
            //Задача 1: Задайте значения M и N.Напишите программу, которая выведет все натуральные числа в промежутке
            //от M до N. Использовать рекурсию, не использовать циклы.
            int m, n;
            m = 10; n = 13;
            RecNatural(m, n);
            Console.WriteLine("\n\n");
            //Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
            m = 2; n = 3;
            Console.WriteLine(Ackermann(m, n)+ "\n\n");
            //Задача 3: Задайте произвольный массив.Выведете его элементы, начиная с конца.Использовать рекурсию, не использовать циклы.
            int[] arr = { 1, 3, 1, 5, 7, 999, 15, 1000, 34, 12, 32, 12, 3, 2 };
            Console.WriteLine(String.Join("," ,Revert(arr)));
        }
        static void RecNatural(int a,int b)
        {
            if (a == b +1)
                return;
            Console.WriteLine(a);
            RecNatural(a + 1,b);
        }
        static double Ackermann(double m, double n)
        {
            if (m > 0)
            {
                if (n > 0)
                    return Ackermann(m - 1, Ackermann(m, n - 1));
                else 
                    return Ackermann(m - 1, 1);
            }
            else if (m == 0)
            {
                if (n >= 0)
                    return n + 1;
                else
                    return 0;
            }
            else
                return 0;
        }
        static int[] Revert(int[] array)
        {
            int len = array.Length;
            int i = 0;
            Count(i, len, array);
            return array;
        }
        static int[] Count(int pos,int len, int[] array)
        {
            if (pos < len / 2)
            {
                int point = array[pos];
                array[pos] = array[len - 1 - pos];
                array[len - 1 - pos] = point;
                pos++;
                Count(pos,len, array);
                return array;
            }
            else
            {
                return array;
            }
        }
    }
}
