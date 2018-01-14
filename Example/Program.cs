using System;
using LetterCounter;
using System.Collections.Generic;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert text: ");
          

            /* 
            * Send your text to library
            */
         
            LCounter.paragraph = Console.ReadLine();

            /* 
            * Print all Result  
            */
             Console.WriteLine(LCounter.printCounter());

            /* 
             * Save result in dictionary 
             */

            Dictionary<string, int> dict = LCounter.getDictionary();

             /* 
              * Validators
              */

            Console.WriteLine("Exist E: "+LCounter.existLetter("E"));
            Console.WriteLine("Concurrence E: " + LCounter.concurrenceLetter("E"));

        }
    }
}
