using System;
using System.Collections.Generic;

namespace List1
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = new List<string>()
            {
                "Bülent ERSOY",
                "Ajda PEKKAN",
                "Ebru GÜNDEŞ",
                "Hadise",
                "Hande YENER",
                "Tarkan",
                "Funda ARAR",
                "Demet AKALIN"
            };

            Console.WriteLine("Davetlilerin isimleri:");

            foreach (string guest in guests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}