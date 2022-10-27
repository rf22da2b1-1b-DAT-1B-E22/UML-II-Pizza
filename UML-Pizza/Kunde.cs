using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Pizza
{
    public class Kunde
    {
        /*
         * Properties
         */
        public String Name { get; set; }
        public String Telefon { get; set; }


        /*
         * Konstruktører
         */
        public Kunde()
        {
            Name = "Anonym";
            Telefon = "";
        }

        public Kunde(string navn, string telefon)
        {
            Name = navn;
            Telefon = telefon;
        }


        /*
         * ToString
         */
        public override string ToString()
        {
            return $"Name= {Name}, Telefon= {Telefon} ";
        }
    }
}
