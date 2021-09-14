using System;
using System.Collections.Generic;

namespace Labb1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Be användaren att mata in en text.
            Console.WriteLine("Knappa loss på tangentbordet. Avsluta med ENTER: ");
            
            //Spara texten i en string.
            string userInput = Console.ReadLine();

            //Skapa en variabel för att kunna summera längre fram:
            long sumOfNumbers = 0;

            //Två loopar, som söker igenom och jämför alla index. 
            for (int i = 0; i < userInput.Length; i++)
            {
                //Skapa bool för att komma ur loop längre fram.. Sätt den i början av första for-loopen för att "nollställa" den vid varje jämförelse.
                bool number = true;

                for (int j = i + 1; j < userInput.Length; j++)
                {
                    //Skapa delsträng där första och sista indexet i delsträngen är samma siffra.
                    if (userInput[i] == userInput[j])
                    {
                        string subString1 = userInput.Substring(0, i);
                        string subString2 = userInput.Substring(i, j-i+1);
                        string subString3 = userInput.Substring(j+1);

                        //Leta efter bokstäver i den delsträng som skall markeras med annan färg i eventuell utskrift.
                        for (int c = 0; c < subString2.Length; c++)
                        {
                            //Om strängen har har bokstav i sig, gör inget (= Ändra bool för att inte gå in i nästa if-sats.)
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
            Console.WriteLine($"Summan av de rödmarkerade talen är: {sumOfNumbers}.");

         }
        
        
    }

}
