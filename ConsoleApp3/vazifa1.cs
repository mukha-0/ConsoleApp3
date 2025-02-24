using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class vazifa1
    {
        private int result;

        public int Task2(int number)
        {
            return number * 2;
        }


        public string Task3(double number)
        {
            if (number < 0)
            {
                return "Manfiy son";
            }
            else if (number > 0)
            {
                return "Musbat son";
            }
            else
            {
                return "Nolga teng";
            }

        }

        public double Task4(double number)
        {
            return Math.Round(number);
        }



        public double Task5(double number)
        {
            return Math.Pow(number, 2);
        }



        public double Task6(double number)
        {
            double radian = number * Math.PI / 180;
            return radian;
        }


        public double Task7(double number1, double number2)
        {
            return number1 + number2;
        }


        public double Task8(double number1, double number2)
        {
            if (number1 > number2)
            {
                return number1;
            }
            else
            {
                return number2;
            }
        }


        public bool Task9(int number)
        {
            while (true)
            {

            }
        }


        public string Task10(string text)
        {
            return text.Length.ToString();
        }



        public string Name { get; set; }
        public int Age { get; set; }
        public void SayHello()
        {
            Name = "Oybek";
            Age = 20;
            Console.WriteLine($"Salom, mening ismim {Name}, Mening yoshim {Age} da");
        }


        public int Task12(int number)
        {
            return number;
        }


        public void Task13(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write("x");
            }
        }


        public void Task15(string text)
        {
            for (int i = text.Length - 1; i >= 0; i--)
            {
                Console.Write(text[i]);
            }
        }


        public double Task16(double Kelvin)
        {
            double Celsius = Kelvin - 273.15;
            return Celsius;
        }



        public bool Task17(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsUpper(text[i]))
                {
                    return true;
                }
                else if (char.IsLower(text[i]))
                {
                    return false;
                }
            }
            return false;
        }



        public double Task18(double number1, double number2)
        {
            if (number1 > number2)
            {
                return number1;
            }
            else
            {
                return number2;
            }
        }



        public void Task19(int number1, int number2)
        {
            if (number1 % 2 == 0 && number2 % 2 == 0)
            {
                Console.WriteLine("Ikkovixam juft");
            }
            else if (number1 % 2 != 0 && number2 % 2 != 0)
            {
                Console.WriteLine("Ikkovixam toq");
            }
            else if (number1 % 2 == 0 && number2 % 2 != 0)
            {
                Console.WriteLine("Number1 juft Number2 toq");
            }
            else if (number1 % 2 != 0 && number2 % 2 == 0)
            {
                Console.WriteLine("Number1 toq Number2 juft");
            }

        }


        public void Task20(int number1)
        {
            int result = 1;
            for (int i = number1; i >= 1; i--)
            {
                result *= i;
                
            }
           Console.Write($"{result} ");
        }

    }
}
 
Console.WriteLine("Salom, Dunyoooooo")
