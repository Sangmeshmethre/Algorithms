using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAnagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\tWelcome to Algorithms Program");
            while (true)
            {
                Console.WriteLine(" 1. Anagram Detection");
                Console.WriteLine(" 0. Exit");
                Console.Write("Enter your choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AnagramDetection anagramDetection = new AnagramDetection();
                        anagramDetection.Anagram();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Please choose the correct option");
                        break;
                }
            }
        }
    }
}
