using System;
using System.Collections.Generic;

namespace Labb1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Be användaren att mata in en text.
            Console.WriteLine("Skriv in en jäkligt lång sträng: ");
            
            //Spara texten i en string.
            string userInput = Console.ReadLine().ToLower().Trim();

            //Skapa en variabel för att kunna summera:
            long sumOfNumbers = 0;

            //Två loopar, söker igenom alla index. 
            for (int i = 0; i < userInput.Length; i++)
            {
                //Skapa bool för att komma ur loopar längre fram.. 
                bool number = true;

                for (int j = i + 1; j < userInput.Length; j++)
                {
                //  Sök efter delsträngar där första och sista indexet i delsträngen är samma siffra.
                    if (userInput[i] == userInput[j])
                    {
                        string subString1 = userInput.Substring(0, i);
                        string subString2 = userInput.Substring(i, j-i+1);
                        string subString3 = userInput.Substring(j+1);

                        //Kolla igenom efter bokstäver i den substräng som skall markeras med annan färg i eventuell utskrift.
                        for (int c = 0; c < subString2.Length; c++)
                        {
                            //Om strängen har har bokstav i sig, gör inget.
                            if (!char.IsDigit(subString2[c]))
                            {
                                number = false;
                            }
                        }
                        if (number)
                        {
                            // Annars, Skriv ut hela input-strängen.Delsträngen skall vara i annan färg.
                            Console.Write(subString1);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(subString2);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(subString3);

                            //Addera ihop alla tal.
                            sumOfNumbers += long.Parse(subString2);
                        }
                        break;
                    }
                }
            }
            //Skapa rum mellan övningarna i utskriften.
            Console.WriteLine();

            //Skriv ut summan i konsolen.
            Console.WriteLine($"Summan av de inskrivna talen är: {sumOfNumbers}.");

         }
        
        
    }

}
