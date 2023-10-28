using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int first = 1;
        int second = 2;

        second = int.Parse(Console.ReadLine());
        int result = first + second;

        Console.WriteLine(result);
    }

}