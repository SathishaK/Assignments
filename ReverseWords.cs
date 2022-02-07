using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assigns
{
    class ReverseWords
    {
        static void Main(string [] args)
        {
            reverseword();
        }
        static void reverseword()
        {
            Console.WriteLine("Enter Your Words:");
            string word = Console.ReadLine();
            string[] words = word.Split(' ');

            for (int i = words.Length - 1; i >= 0; i--)
            {
                Console.Write(words[i] + " ");
            }
        }
    }
}
