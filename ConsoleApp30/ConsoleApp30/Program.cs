using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace l4t33

{

    /*

    * Внутри класса Program создайте 5 целочисленных переменных, которые бы отвечали за:

    * 1) Количество положительных чисел (positive).

    * 2) Количество отрицательных чисел (negative).

    * 3) Количество четных чисел (even).

    * 4) Количество нечётных чисел (odd).

    * 5) Количество НЕ чисел (notNumber).

    * Создайте и реализуйте метод класса MyCustomCounter(), который должен считывать

    * 10 строк с клавиатуры, анализировать их и увеличивать значения соответствующих переменных класса Program.

    * Внутри метода Main() добавьте вызов метода MyCustomCounter(), после чего последовательно выведите на экран значения

    * всех созданных переменных класса Program в следующем формате:

    * Количество положительных чисел: ХХХ.

    * Количество отрицательных чисел: ХХХ.

    * Количество чётных чисел: ХХХ.

    * Количество нечётных чисел: ХХХ.

    * Количество НЕ чисел: ХХХ.

    * где ХХХ - значения соответствующих переменных класса Program после вызова метода MyCustomCounter().

    * Все элементы класса Program должны быть публичными.

    */

    public class Program

    {

        public static void Main(string[] args)

        {

            /* Добавьте свой код ниже */
            MyCustomCounter();

        }
        static int a = 0;
        static int b = 0;
        static int c = 0;
        static int e = 0;
        static int d = 0;
       static int number;
        public static void MyCustomCounter()
        {
            for (int i = 0; i < 10; i++)
            {
                string s = Console.ReadLine();

                bool result = int.TryParse( s, out number);
                if (result == true)
                {
                    if (number > 0)
                    {
                        a = a + 1;
                        if (number % 2 == 0)
                        {
                            c = c + 1;
                        }
                        else
                        {
                            e = e + 1;
                        }
                    }
                    else if (number < 0)
                    {
                        b = b + 1;
                        if (number % 2 == 0)
                        {
                            c = c + 1;
                        }
                        else
                        {
                            e = e + 1;
                        }
                    }
                    else
                    {

                    }
                }
                else
                {
                    d = d + 1;
                }
            }
            Console.WriteLine("Количество положительных чисел:" + a);
            Console.WriteLine("Количество отрицательных чисел:" + b);
            Console.WriteLine("Количество чётных чисел:" + c);
            Console.WriteLine("Количество нечётных чисел:" + e);
            Console.WriteLine("Количество НЕ чисел:" + d);

        }

    }

}