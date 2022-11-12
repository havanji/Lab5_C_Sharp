using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Cat
{
    public class Cat
    {
        enum Lab5 { Male = 1, Famale = 2 };
        public string Name { get; }
        public string Gender { get; }
        private double _energy;
  
        public double Energy
        {
            get { return _energy; }
            set
            {
                if (this._energy < MinEnergy)
                {
                    Console.WriteLine("Not enough energy to jump");
                }
                if (this._energy > MaxEnergy)
                {
                    this._energy = MaxEnergy;
                }
                else
                {
                    this._energy = value;
                }
            }
        }

        public static readonly double MaxEnergy = 20;
        public static readonly double MinEnergy = 0;
        public static readonly double SleepEnergyGain = 10;
        public static readonly double JumpEnergyDrain = 0.5;

        public void Jump()
        {
            Console.WriteLine($"{this.Name} стрибнув, його енергія: {this.Energy - JumpEnergyDrain}");
        }

        public void Sleep() 
        {
            Console.WriteLine($"{this.Name} ляг спати і відновив енергію до: {this.Energy + SleepEnergyGain}");
        }





    }
}
