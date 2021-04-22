using System;
using System.Collections.Generic;
using System.Collections;
namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
        string input;

        System.Console.WriteLine("Guess da word :");
        input = Console.ReadLine();
        List<string> Word = new List<string>();

        while (input != "Stop") {  
        Word.Add(input);
        input = Console.ReadLine();
        } 
        Console.WriteLine("Good Job");
        
        Word.Reverse();

        Console.WriteLine();
        foreach(string List in Word)
        {
            Console.WriteLine(List);
        }
        }
    }
}