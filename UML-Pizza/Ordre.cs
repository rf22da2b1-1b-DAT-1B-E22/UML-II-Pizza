using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UML_Pizza
{
    public class Ordre
    {
        /*
         * ingen properties - men to instans felter til de to associeringer 
         */

        private Kunde _kunde;
        private Pizza _pizza;


        /*
         * Konstruktører
         */
        public Ordre()
        {
            _kunde = null;
            _pizza = null;
        }

        public Ordre(Kunde kunde, Pizza pizza)
        {
            _kunde = kunde;
            _pizza = pizza;
        }

        /*
         * Metode
         */
        public double CalculateTotalPrice()
        {
            double prisPizza = _pizza.Pris;
            double prisMedMoms = prisPizza * 1.25;
            double prisMedLevering = prisMedMoms + 40;

            return prisMedLevering;
        }




        /*
         * ToString
         */
        public override string ToString()
        {
            return $"Denne ordre har \nKunde= {_kunde} til denne \nPizza={_pizza}\nSamlet pris med levering er {CalculateTotalPrice()}";
        }


    }
}
