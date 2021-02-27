using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt_1
{
    public class Vending
    {
        public string Name;
        public decimal Change;
        public Dictionary<string, List<int>> Snacks = new Dictionary<string, List<int>>();


        public void HelloVending()
        {
            Console.WriteLine(Name);
            Console.WriteLine("Wybierz przekąskę z listy poniżej.");
            Console.WriteLine("Automat przyjmuje monety 1,2 i 5 zł");
        }

        public void WhatSnacks()
        {
            string TheLongest = " ";
            foreach (KeyValuePair<string, List<int>> entry in Snacks)
            {
                if (entry.Key.Length > TheLongest.Length)
                {
                    TheLongest = entry.Key;
                }
            };
            foreach(KeyValuePair<string, List<int>> entry in Snacks)
            {
                Console.WriteLine("{0}{1} {2} zł {3}", entry.Key, new string (' ', (TheLongest.Length - entry.Key.Length)), entry.Value[1], new string('=', entry.Value[0]));
            }
            Console.WriteLine(Snacks.Keys);
        }
        public void BuySnack(string input)
        {
            if (Snacks.ContainsKey(input) && Snacks[input][0] > 0)
            {
                Console.WriteLine("{0} jest dostępny. Sztuk {1}. Cena {2} zł",input, Snacks[input][0], Snacks[input][1]);
            }
            else
            {
                Console.WriteLine("{0} jest niedostępny, wybierz inny produkt",input);
                return;
            }

            Console.WriteLine("Wrzuć monetę");

            int coin_int = 0;

            while (true)
            {
                coin_int += Int32.Parse(Console.ReadLine());

                if (coin_int < Snacks[input][1])
                {
                    Console.WriteLine("Wrzuciłeś za małą kwotę, brakuje {0} zł.", Snacks[input][1] - coin_int);                  
                }
                else if (coin_int > Snacks[input][1])
                {
                    Console.WriteLine("Reszta: {0}", coin_int - Snacks[input][1]);
                    Snacks[input][0] -= 1;
                    break;
                }
                else
                {
                    Console.WriteLine("Dziękuję!");
                    Snacks[input][0] -= 1;
                    break;
                }
            }
        }
    }
}
