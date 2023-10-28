using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace _02_00
{
    public class IfStuff
    {
        static void Main(string[] args)
        {

            string faction = string.Empty;
            string race = string.Empty;
            string cls = string.Empty;
            string gender = string.Empty;

            Console.WriteLine("Pick your faction");

            Console.WriteLine("1. Horde\n2. Alliance");

            int input = int.Parse(Console.ReadLine());

            switch (input)
            {

                case 1:
                    faction = "Horde";
                    break;
                case 2:
                    faction = "Alliance";
                    break;
            }

            Console.WriteLine("Pick your race");

            Console.WriteLine("1. Troll\n2. Human \n3. Orc \n4. Elf \n5. Gnome");

            input = int.Parse(Console.ReadLine());

            switch (input)
            {

                case 1:
                    race = "Troll";
                    break;
                case 2:
                    race = "Human";
                    break;
                case 3:
                    race = "Orc";
                    break;
                case 4:
                    race = "Elf";
                    break;
                case 5:
                    race = "Gnome";
                    break;
            }
        }
    }
}