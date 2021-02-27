using System;
using System.Collections.Generic;

namespace Projekt_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Vending vending = new Vending();
            vending.Name = "Maszyna z przekąskami";
            vending.Change = 20;
            vending.Snacks.Add("Mars", new List<int>() {4, 2 });  //name,amount,price
            vending.Snacks.Add("Snickers", new List<int>() { 5, 3 });
            vending.Snacks.Add("Pepsi", new List<int>() { 5, 4 });
            vending.Snacks.Add("Lays", new List<int>() { 7, 2 });

            vending.HelloVending();
            vending.WhatSnacks();

            while (true)
            {
                vending.BuySnack(Console.ReadLine());
                vending.WhatSnacks();
            }
            

        }
        

    }
}
