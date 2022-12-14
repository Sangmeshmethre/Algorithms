using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alogorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\tWelcome to Algorithms Program");
            while (true)
            {
                Console.WriteLine("\n 1. Program to return all permutations of a string");
                Console.WriteLine(" 2. Binary Search the word from word list");
                Console.WriteLine(" 0. Exit");
                Console.Write("Enter your choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        PermutationsOfString permute = new PermutationsOfString();
                        permute.Driver();
                        break;
                    case 2:
                        BinarySearchWord binarySearchWord = new BinarySearchWord();
                        binarySearchWord.DriverMethod();
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