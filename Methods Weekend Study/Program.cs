using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phrases
{
    class Program
    {
        static void Main(string[] args)


        //Problem 1
        {

            Phrasing("PRETTY PONIES AND RAINBOWS");
        }
        static void Phrasing(string value)
        {



            string reverse = string.Empty;

            char chSplit = ' ';

            string[] words = value.Split(new char[] { chSplit }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in words)

            {
                reverse = word + chSplit + reverse;

            }
            Console.WriteLine(reverse);
            Console.ReadKey();


        }

            



        

        //Problem 2

        {
            Project("ALEXIS", "JUNE");



    }

    static string Project(string name, string month)
    {





        switch (month)
        {
            case "FEBRUARY":
                Console.WriteLine(name + " IS A " + month + " BABY!");
                break;
            case "MARCH":
                Console.WriteLine(name + " IS A " + month + " BABY!");
                break;
            case "MAY":
                Console.WriteLine(name + " IS A " + month + " BABY!");
                break;
            case "JUNE":
                Console.WriteLine(name + " IS A " + month + " BABY!");
                break;
            case "JULY":
                Console.WriteLine(name + " IS A " + month + " BABY!");
                break;
            case "SEPTEMBER":
                Console.WriteLine(name + " IS A " + month + " BABY!");
                break;
            case "NOVEMBER":
                Console.WriteLine(name + " IS A " + month + " BABY!");
                break;
            case "DECEMBER":
                Console.WriteLine(name + " IS A " + month + " BABY!");
                break;
            case "APRIL":
                Console.WriteLine(name + " IS AN " + month + " BABY!");
                break;
            case "AUGUST":
                Console.WriteLine(name + " IS AN " + month + " BABY!");
                break;
            case "OCTOBER":
                Console.WriteLine(name + " IS AN " + month + " BABY!");
                break;


        }

        string final = name + month;
        return final;

    }

        


        //Problem 3
        
        {
            Name("alexis ", "chandler");
}


static string Name(string first, string last)
{
    first = first[0].ToString().ToUpper() + first.Substring(1, first.Length - 1);
    last = last[0].ToString().ToUpper() + last.Substring(1, last.Length - 1);
    Console.WriteLine(first + last);
    string final = first + last;

    return final;



}

    

        //Problem 4


        {
            RemoveRandom("it's Fr0iday!");
        }

        static string RemoveRandom(string princess)
{
    if (princess.Contains("0"))
    {
        princess = princess.Replace("0", "");
        Console.Write(princess);
    }

    else
    {
        Console.WriteLine("This string is ok!");
    }


    string queen = princess;
    return queen;

}
    




//problem 1 the correct way

//made into string array. then split it, then reverse it. then foreach





    
    

        
    }
}
 