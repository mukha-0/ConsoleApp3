using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class tasks
    {
        public void Task22(int a, int b)
        {
            int miut1 = a * 24 * 60;
            int minut2 = b * 60;
            Console.WriteLine(miut1 + minut2);

        }
        public void task23(int S)
        {
            Console.WriteLine(S / 7);
        }
        public void task24(int a, int b)
        {
            int hafta = a * 7 * 24;
            int soat = b * 60;
            Console.WriteLine(hafta + soat);
        }
        public void task25(double a = 750, double b = 1.8)
        {
            double kbs = b * 1024 * 1024;
            Console.WriteLine(kbs / a);
        }
        public void task26(double a)
        {
            Console.WriteLine(a / 3600);
        }
        public void task27(double a)
        {
            double day = a / 86400;
            double oclock = (a % 86400) / 3600;
            double minute = (a % 3600) / 60;
            double second = a % 60;
            Console.WriteLine(day + oclock + minute + second);
        }
        public void task28(int a)
        {
            int yuz = a / 100;
            int on = a % 100 / 10;
            int bir = a % 100 % 10 / 1;
            Console.WriteLine(yuz * on * bir);
        }
        public void task29(double r)
        {
            double pi = 3.14;
            double l = 2 * pi * r;
            Console.WriteLine(l);
        }
        public void task30(double kb)
        {
            double a = kb * 1024;
            Console.WriteLine(a / 2);
        }
        public void task32(int a)
        {
            if (1000 <= a && a <= 9999 || -9999 <= a && a <= -1000)
            {
                int ming = a / 1000;
                int yuz = a % 1000 / 100;
                int on = a % 1000 % 100 / 10;
                int bir = a % 1000 % 100 % 10 / 1;
                if (ming == 3 || yuz == 3 || on == 3 || bir == 3)
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
            }
            Console.WriteLine(false);

        }
        public void task33(int a)
        {
            if (1000 <= a && a <= 9999 || -9999 <= a && a <= -1000)
            {
                int ming = a / 1000;
                int yuz = a % 1000 / 100;
                int on = a % 1000 % 100 / 10;
                int bir = a % 1000 % 100 % 10 / 1;
                if (ming == yuz || ming == on || ming == bir || yuz == on || yuz == bir || on == bir)
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
            }
            Console.WriteLine(false);
        }
        public void task34(int a)
        {
            if (1000 <= a && a <= 9999 || -9999 <= a && a <= -1000)
            {
                int ming = a / 1000;
                int yuz = a % 1000 / 100;
                int on = a % 1000 % 100 / 10;
                int bir = a % 1000 % 100 % 10 / 1;
                if (ming == 1 || yuz == 1 || on == 1 || bir == 1)
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
            }
            Console.WriteLine(false);
        }

    }

}
