﻿using System;

namespace CalculateOpdracht2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //we gaan nu dingen kopen

            int controllersInMandje = 0;
            controllersInMandje = controllersInMandje + 2;


            //koop 2 controllers


            //hij is in voorraad snel kopen!
            int ps5 = 0;
            ps5 = ps5 + 1;

            //koop 1 ps5


            //koop de games:

            int eldenRing = 0;
            eldenRing = eldenRing + 1;

            int shantae = 0;
            shantae = shantae + 1;

            int spongebob = 0;
            spongebob = spongebob + 1;


            //hmmm weten we het zeker?
            //haal 1 game weg met -- of -= 1
            shantae -= 1;
            //nu nog de prijs


            double ps5Prijs = 499.99;
            double controllerPrijs = 69.99;
            double gamePrijs = 59.99;


            double totaalControllerPrijs = controllerPrijs * controllersInMandje;// controllersInMandje keer controllerPrijs
            double totaalGamePrijs = gamePrijs * (eldenRing + shantae + spongebob);// game1 keer gamePrijs  + game2 keer gamePrijs (let op je haakjes!)



            double totaalPrijs = totaalControllerPrijs + totaalGamePrijs + ps5Prijs;// tel hier alles bij elkaar op
            Console.WriteLine(totaalPrijs);

            //er moet nu 759.95 staan
        }
    }
}