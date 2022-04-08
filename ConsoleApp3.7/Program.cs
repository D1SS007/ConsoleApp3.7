using System;

namespace ConsoleApp3._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] parts = line.Split(); 
            
            for (int i = 0; i < parts.Length; i++)
            {
                Console.WriteLine(parts[i]);
            }  
        }
    }
}
