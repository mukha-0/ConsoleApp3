using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Car
    {
        public string Name { get; set; } = "M5 COMP";
        public int NumberOfTires { get; set; } = 4;
        public string Color { get; set; } = "BLACK";
        public string Model { get; set; } = "BMW";
        public int Speed { get; set; } = 300;
        public int Gas { get; set; } = 50; //Litre
        public int Distance { get; set; } = 900; //Km
        public double RunoutofGasin { get; set; } = 2.5; //Hours
        public void GasKmp()
        {
            double Norma = Distance / Speed;
            double Sarf = Norma - RunoutofGasin;
            double GasKmp = (Sarf * Speed) / 3;
            Console.WriteLine(GasKmp);
        }
    }
}
