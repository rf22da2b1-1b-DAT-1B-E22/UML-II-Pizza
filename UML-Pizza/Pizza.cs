using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Pizza
{
    public class Pizza
    {

        /*
         * Properties
         */

        public int Nummer { get; set; }
        public string Name { get; set; }
        public String Beskrivelse { get; set; }
        public double Pris { get; set; }


        /*
         * Konstruktører
         */

        // default
        public Pizza()
        {
            Nummer = 0;
            Name = "";
            Beskrivelse = "";
            Pris = 0;
        }

        // med parametre
        public Pizza(int nummer, string navn, string beskrivelse, double pris)
        {
            Nummer = nummer;
            Name = navn;
            Beskrivelse = beskrivelse;
            Pris = pris;
        }


        /*
         * ToString
         */
        public override string ToString()
        {
            return $"Nummer = {Nummer}, Name = {Name}, Beskrivelse = {Beskrivelse}, Pris = {Pris} ";
        }




    }
}
