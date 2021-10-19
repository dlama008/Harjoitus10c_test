using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus10c_test
{
    class Opiskelija
    {
        public Opiskelija(string nimi, string osoite, DateTime opintojenAloitus)
        {
            Nimi = nimi;
            Osoite = osoite;
            OpintojenAloitus = opintojenAloitus;
        }
        public string Nimi { get; set; }
        public string Osoite { get; set; }
        public DateTime OpintojenAloitus { get; set; }

        public override string ToString()
        {
            return ("Nimi: " + Nimi + ", Osoite: " +
                    Osoite + "\nOpintojen aloitus: " +
                    OpintojenAloitus.ToLongDateString();
        }
    }
}

