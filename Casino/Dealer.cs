﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Casino
{
    public class Dealer
    {
        public string Name { get; set; }
        public  Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());
            string card = string.Format(Deck.Cards.First().ToString() + "/n");
            Console.WriteLine(card);

            //this is to log txt into a file
            // using (StreamWriter file = new StreamWriter("path where it is logged in", true))
            //{file.WriteLine(card);}

            using (StreamWriter file = new StreamWriter(@"c:\users\alpac\logs\log.txt", true))
            {
                file.WriteLine(DateTime.Now);
                file.WriteLine(card);
            }
            Deck.Cards.RemoveAt(0);
        }
    }
}
