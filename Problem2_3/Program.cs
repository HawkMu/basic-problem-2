﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* int a = 1, b = 2, c = 3, d = 4, e = 5;
                 a = a + 2; // aに2を加える
                 b = b - 1; // bから1を引く
                 c = c * 3; // cに3をかける
                 d = d / 2; // dを2で割る
                 e = e % 2; // eに、eを2で割った余りを代入する
                 Console.WriteLine("a = {0}", a);
                 Console.WriteLine("b = {0}", b);
                 Console.WriteLine("c = {0}", c);
                 Console.WriteLine("d = {0}", d);
                 Console.WriteLine("e = {0}", e); 
           */
            int a = 1, b = 2, c = 3, d = 4, e = 5; 
                a += 2;
                b -= 1;
                c *= 3;
                d /= 2;
                e %= 2;
                Console.WriteLine("a = {0}", a);
                Console.WriteLine("b = {0}", b);
                Console.WriteLine("c = {0}", c);
                Console.WriteLine("d = {0}", d);
                Console.WriteLine("e = {0}", e);
        }
    }
}
