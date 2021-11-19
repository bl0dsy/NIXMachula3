using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIXMachula3
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                {
                    Console.WriteLine("Занятие 2, Задание 1. Определить, сможете ли вы купить пирожков");
                    double a, b, x, y, n, luck, luck1, unluck, unluck1, k, m, z, c;
                    Console.WriteLine("Введите стоимость одного пирожка в гривнах");
                    a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите стоимость одного пирожка в копейках");
                    b = double.Parse(Console.ReadLine());
                    Console.WriteLine("Сколько у Вас есть гривен?");
                    x = double.Parse(Console.ReadLine());
                    Console.WriteLine("Сколько у Вас есть копеек?");
                    y = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите количество пирожков");
                    n = double.Parse(Console.ReadLine());

                    luck = a * n; /*Сколько будет стоить в грн. за n к-во*/
                    luck1 = b * n; /*Сколько будет стоить в коп. за n к-во*/

 
                    m = (y / 100) + x; /*Сколько есть денег переведя в гривны*/
                    k = (x * 100) + y; /*Сколько есть денег переведя в копейки*/

                    Console.WriteLine($"Итого с вас в гривнах = {luck}");
                    Console.WriteLine($"Итого с вас в копейках = {luck1}");

                    if (luck < x)
                    {
                        z = luck - x;
                        Console.WriteLine($"Возьмите сдачу = { z } гривен");
                    }
                    else if (luck1 < y)
                    {
                        c = luck1 - y;
                        Console.WriteLine($"Возьмите сдачу = { c } копеек");
                    }

                    else if (luck > x)
                    {
                        Console.WriteLine("Денег недостаточно");
                    }

                    else if (luck1 > y)
                    {
                        Console.WriteLine("Денег недостаточно");
                    }
                    else if ( x < 0 )
                    {
                        unluck = luck1 - k;
                        Console.WriteLine($"Возьмите сдачу { unluck } копеек");
                    }
                    else if (y < 0)
                    {
                        unluck1 = luck - m;
                        Console.WriteLine($"Возьмите сдачу { unluck1 } копеек");
                    }
                }

            }
        }
    }
}

