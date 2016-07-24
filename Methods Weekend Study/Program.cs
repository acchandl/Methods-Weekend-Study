using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Weekend_Study
{
    class Program
    {
        static void Main(string[] args)
        {

            
            string[] phrase = Phrasing(int amount);
            Reverse(phrase);
            PrintPhrase(phrase);

        }



       

        static string[] Phrasing(int amount)
        {
            
            string[] phrase = new string[amount];
            for (int i = 0; i < amount; i++)
            {
                phrase[i] = Console.ReadLine() + 1;
            }
            return phrase;
        }


        static void PrintPhrase(string[] phrase)
        {
            for (int i = 0; i < phrase.Length; i++)
            {
                Console.WriteLine(phrase[i] + "");
            }

            Console.WriteLine();

        }




        static void Reverse(string[] phrase)
        {
            int firstI = 0;
            int secondI = phrase.Length - 1;

            while (firstI < secondI)
            {
                string temp = phrase[firstI];
                phrase[firstI] = phrase[secondI];
                phrase[secondI] = temp;
            }

            firstI++;
            secondI++;
            

        }

    
    

        
    }
}
 