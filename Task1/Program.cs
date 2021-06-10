using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
        
            string[] names = new string[5];
            System.Console.WriteLine("Gimme 5 names: ");
            names[0] = Console.ReadLine();
            names[1] = Console.ReadLine();
            names[2] = Console.ReadLine();
            names[3] = Console.ReadLine();
            names[4] = Console.ReadLine();


            
            
        
            // Holy mackeral I made a comment!
            foreach(string s in names){
                Console.WriteLine("HELLO!!! " + s);
            }
        }
    }
}
