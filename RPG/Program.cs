using System;
using RPG.SRC.Entities;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {           
            Knight Arus = new Knight("Arus", 59,"Knight");
            Wizard Wizard = new Wizard("Jennica", 47, "White Wizard");
            Ninja Ninja = new Ninja("Jiraya", 48, "Ninja");
            BlackWizard BlackWizard = new BlackWizard("Gorpo", 51, "BlackWizard");

            System.Console.WriteLine("\n");
            Console.WriteLine(BlackWizard.Attack());
            System.Console.WriteLine("\n");
            Console.WriteLine(Ninja.Attack());
            System.Console.WriteLine("\n");
            Console.WriteLine(Arus.Attack());
            System.Console.WriteLine("\n");
            Console.WriteLine(Wizard.Attack());
            System.Console.WriteLine("\n");
        }
    }
}