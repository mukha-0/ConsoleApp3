
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Methods
    {
        public int Task22(int a, int b)
        {
            int miut1 = a * 24 * 60;
            int minut2 = b * 60;
            return miut1 + minut2;
        }
        public int task23(int S)
        {
            return S / 7;
        }
        public int task24(int a, int b)
        {
            int hafta = a * 7 * 24;
            int soat = b * 60;
            return hafta + soat;
        }
        public double task25(double a = 750, double b = 1.8)
        {
            double kbs = b * 1024 * 1024;
            return kbs / a;
        }
        public double task26(double a)
        {
            return a / 3600;
        }
        public double task27(double a)
        {
            double day = a / 86400;
            double oclock = (a % 86400) / 3600;
            double minute = (a % 3600) / 60;
            double second = a % 60;
            return day + oclock + minute + second;
        }
        public int task28(int a)
        {
            int yuz = a / 100;
            int on = a % 100 / 10;
            int bir = a % 100 % 10 / 1;
            return yuz * on * bir;
        }
        public double task29(double r)
        {
            double pi = 3.14;
            double l = 2 * pi * r;
            return l;
        }
        public double task30(double kb)
        {
            double a = kb * 1024;
            return 1024 / a;
        }
        public bool task32(int a)
        {
            if (1000 <= a && a <= 9999 || -9999 <= a && a <= -1000)
            {
                int ming = a / 1000;
                int yuz = a % 1000 / 100;
                int on = a % 1000 % 100 / 10;
                int bir = a % 1000 % 100 % 10 / 1;
                if (ming == 3 || yuz == 3 || on == 3 || bir == 3)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}
