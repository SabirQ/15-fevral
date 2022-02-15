using System;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
           string sentence = "Everything I NeeD, is a CuP of CoFFee";


            Console.WriteLine(Reverse(sentence));

        }
        public static string Reverse(string words)
        {
            char[] letters = words.ToCharArray();
            for (int i = 0; i < letters.Length; i++)
            {
                if (char.IsUpper(letters[i]))
                {
                    letters[i]=char.ToLower(words[i]);
                }
                else
                {
                    letters[i] = char.ToUpper(words[i]);
                }
                words = new string(letters);
            }
            
            return words;

        }
    }
}
