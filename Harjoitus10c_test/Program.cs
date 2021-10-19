using System;
using System.Collections.Generic;

namespace Harjoitus10c_test
{
    class Program
    {
        static void Main(string[] args)
        {
            bool jatkuu;
            List<Opiskelija> opiskelijat = new List<Opiskelija>();
            do
            {
                Console.Write("Nimi: ");
                string oNimi = Console.ReadLine();
                Console.Write("Osoite: ");
                string oOsoite = Console.ReadLine();
                Console.Write("Opintojen aloitus: ");
                DateTime oAloitus;
                string annettu = Console.ReadLine();
                while (!DateTime.TryParse(annettu, out oAloitus))
                {
                    Console.Write("Ei sallittu arvo, yritä uudelleen: ");
                    annettu = Console.ReadLine();
                }
                //Nyt kaikki tarvittava on olemassa!
                //Ekaksi olio:
                Opiskelija opiskelija = new Opiskelija(oNimi, oOsoite, oAloitus);
                //Sitten lisäys kokoelmaan:
                opiskelijat.Add(opiskelija);


                Console.Write("Lisää opiskelijoita (K/E): ");
                string vastaus = Console.ReadLine().ToUpper();
                if (vastaus.StartsWith("K"))
                    jatkuu = true;
                else
                    jatkuu = false;
            } while (jatkuu);
            //Mitä siellä kokoelmassa on jäseniä:
            foreach (var item in opiskelijat)
            {
                //Console.WriteLine("Nimi: " + item.Nimi + ", Osoite: " +
                //    item.Osoite + "\nOpintojen aloitus: " +
                //    item.OpintojenAloitus.ToLongDateString());
                Console.WriteLine(item);
            }
        }
    }
}

