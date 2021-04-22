using System;
using System.Collections.Generic;
namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
        System.Console.WriteLine("Gimme 5 numbers!! :");
        string a = Console.ReadLine();
        string b = Console.ReadLine();
        string c = Console.ReadLine();
        string d = Console.ReadLine();
        string e = Console.ReadLine();


        int num1 = int.Parse(a);
        int num2 = int.Parse(b);
        int num3 = int.Parse(c);
        int num4 = int.Parse(d);
        int num5 = int.Parse(e);
        

        System.Console.WriteLine("Now Give me a 6th number");
        string f = Console.ReadLine();
        int num6 = int.Parse(f);

        List<int> intNum = new List<int>();
        intNum.Add(num1);
        intNum.Add(num2);
        intNum.Add(num3);
        intNum.Add(num4);
        intNum.Add(num5);
        intNum.Add(num6);

        if (num1 == num6) {
            System.Console.WriteLine("First number = " + num1 + " Matches with the last digit");}
        else {Console.Write("");}

         if (num2 == num6) {
            System.Console.WriteLine("Second number = " + num2 + " Matches with the last digit");}
        else {Console.Write("");}
        
        if (num3 == num6) {
            System.Console.WriteLine("Third number = " + num3 + " Matches with the last digit");}
        else {Console.Write("");}

         if (num4 == num6) {
            System.Console.WriteLine("Forth number = " + num4 + " Matches with the last digit");}
        else {Console.Write("");}

         if (num5 == num6) {
            System.Console.WriteLine("Fifth number = " + num5 +  " Matches with the last digit");
        }
        else {Console.Write("");}
        
        Console.ReadLine();
        }
    }
}
