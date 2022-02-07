using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigns
{
    class Encrypts
    {
        public static string Encrypt(string text)
        {
            int letterInt = 0;
            char letter = ' ';
            string textEncrypted = "";
            for (int i = 0; i < text.Length; i++)
            {
                letterInt = (int)text[i] + 1;
                letter = (char)letterInt;
                textEncrypted += letter.ToString();
            }
            return textEncrypted;
        }

        public static string Decrypt(string text)
        {
            int letterInt = 0;
            char letter = ' ';
            string textDecrypted = "";
            for (int i = 0; i < text.Length; i++)
            {
                letterInt = (int)text[i] - 1;
                letter = (char)letterInt;
                textDecrypted += letter.ToString();
            }
            return textDecrypted;
        }
    }
    class TextEncrypted
    {
        static void Main()
        {
            bool value = true;

            string newText = Encrypts.Encrypt("Sathish");
            Console.WriteLine("Text encripted: {0}", newText);
            string TextDescrypted = Encrypts.Decrypt(newText);
            Console.WriteLine("Text Decrypted: {0}", TextDescrypted);

            if (value)
                Console.ReadLine();
        }
    }
}
