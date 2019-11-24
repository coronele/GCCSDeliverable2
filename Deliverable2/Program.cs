// Erwin Coronel
// coronele@hotmail.com
// Grand Circus C#.NET Boot Camp Unit 1 Lab - Deliverable 2

using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            int checksum=0;
            string message="";

            Console.Write("What is your message? ");
            string input = Console.ReadLine();
            input = input.ToUpper();
            
            // Parse characters in string and convert to code values
            for(int chr=0; chr <= (input.Length-1); chr++)
            {
                // Implicit conversion converts char to decimal integer value
                int uValue = input[chr];
                checksum = checksum + uValue;

                // Add new character value to existing message
                // If Unicode "A" is 65, subtract 64 to get code value of 1 for "A"
                if (chr==(input.Length-1))
                {
                    message = message + (uValue-64);
                } else
                {
                    message = message + (uValue-64) + "-";
                }
            }   /* end for loop */
            
            // Output encoded message and checksum
            Console.WriteLine("Your encoded message is " + message);
            Console.WriteLine("Message checksum is " + checksum);
        }
    }
}
