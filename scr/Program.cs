using static System.Console;
using System;
using POO_Csharp.scr.enties;


class Program
{
    static void Main()
    {
        Knigth Arus = new Knigth("Jubileu", 19, "Knigth", 501.5, 100);
        Wizard Wizard = new Wizard("Jenica", 23, "White Wizard", 200, 455);
        BlackWizard Darkness = new BlackWizard("Darkness", 30, "Black Wizard", 50, 900);
        Ninja Uzui = new Ninja("Uzui", 20, "Ninja", 302.65, 300);


        WriteLine(Arus); 
        WriteLine(Wizard);
        WriteLine(Darkness);
        WriteLine(Uzui);


        
        WriteLine($"{Arus.Attack(1)} x {Uzui.Attack(3)}");
        WriteLine($"{Wizard.Attack(7)} x {Darkness.Attack(2)}");
    }
}