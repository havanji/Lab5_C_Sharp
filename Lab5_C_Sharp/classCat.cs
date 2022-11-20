using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

class Cat
{
    private string name;
    private double _energy;
    public string Name { get { return name; } }
    private enum gender { Male, Famale};
    /*public enum Gender
    {
        get { return gender { Male, Famale };
    }*/

    public double Energy
    {
        get { return _energy; }
        set
        {
            if (this._energy > MaxEnergy)
            {
                this._energy = MaxEnergy;
            }
            else if (this._energy < MinEnergy)
            {
                Console.WriteLine("Not enough energy to jump");
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

    public Cat(string Name/*, string gender*/)
    {
        this.name = Name;
        /*this.gender = gender;*/
        Energy = MaxEnergy;
    }

    public void Jump()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;

        Energy -= JumpEnergyDrain;

        Console.WriteLine($"{Name} стрибнув, його енергія: {Energy}");
    }

    public void Sleep()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;

        Energy += SleepEnergyGain;
        if (Energy > MaxEnergy)
        {
            Energy = MaxEnergy;
        }

        Console.WriteLine($"{Name} ляг спати і відновив енергію до: {Energy}");
    }

    public void CheckEnergy()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;

        Console.WriteLine($"В тебе ще {Energy} енергії");
    }
}

