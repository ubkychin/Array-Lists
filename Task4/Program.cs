using System;
using System.Collections.Generic;
namespace Task4
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

        int counter = 0;

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
           counter++;}
        else {Console.Write("");}

         if (num2 == num6) {
            counter++;}
        else {Console.Write("");}
        
        if (num3 == num6) {
            counter++;}
        else {Console.Write("");}

         if (num4 == num6) {
            counter++;}
        else {Console.Write("");}

         if (num5 == num6) {
            counter++;}
        else {Console.Write("");}
        
        Console.WriteLine("You have repeated a number " + counter + " times");
        }
    }
}

