using System;
using System.Linq;
namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
        int[] number = new int[10];
        number[0] = 34;
        number[1] = 5;
        number[2] = 67;
        number[3] = 1;
        number[4] = 99;
        number[5] = 34;
        number[6] = 44;
        number[7] = 78;
        number[8] = 34;
        number[9] = 0;     
    

      Console.WriteLine("Total is: " + number.Sum());
        
        }
    }
}