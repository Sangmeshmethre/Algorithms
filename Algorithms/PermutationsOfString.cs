using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class PermutationsOfString
    {
       public static void Permute(string enteredString, int leftindex, int rightindex)
        {
            //If lesftIndex and rightIndex are Pointing to the same index of the EnteredString, Simple Print the EnteredString
            if (leftindex==rightindex)
            {
                Console.WriteLine(enteredString);
            }
            //otherwise
            else
            {
                //we start from the leftindex here 1st index go till the rightindex here endof the enteredstring to compute
                for (int i= leftindex; i < rightindex; i++)
                {
                    //swapping the leftindex char with the i'th index char i.e current and the next to compute for the next string 
                    enteredString = Swap(enteredString, leftindex, i);
                }
            }
        }
        public static string Swap(string eneteredString, int leftindex, int rightindex)
        {
            // Creating a character array named tempstring to perform swapping operation 
            char[] tempstring = eneteredString.ToCharArray();

            //create a temporary variable temp for swpping opartion 
            //swap logic to swap LeftIndex to the Rightindex
            char temp = tempstring[leftindex];
            tempstring[leftindex] = tempstring [rightindex];
            tempstring[rightindex] = temp;

            // Converting tempString array back to string 
            string toReturn = new string(tempstring);

            //Finally return the string witch we Converted from the Array 
            return toReturn;
        }
        public void Driver()
        {
            Console.WriteLine("Enter the string to find all of it's permutations :");
            string enteredString = Console.ReadLine();
            Console.WriteLine("Permutation of the string " + enteredString + "are :");
            Permute(enteredString, 0, enteredString.Length - 1);
        }
    }
}
