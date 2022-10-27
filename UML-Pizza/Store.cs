using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Pizza
{
    public class Store
    {

        public void Start()
        {
            /*
             * De tre Pizzaer
             */
            Pizza pizza1 = new Pizza(2, "vesio", "med lidt af hvert", 34);
            Pizza pizza2 = new Pizza(4, "quatro statione", "med fire foskellige fyld", 38);
            Pizza pizza3 = new Pizza(6, "BigMama", "med lidt af det hele", 45);


            /*
             * De tre kunder
             */
            Kunde kundeAnonym = new Kunde();
            Kunde kunde1 = new Kunde("Peter", "22334455");
            Kunde kunde2 = new Kunde("Jakob", "11223355");


            /*
             * De tre ordre
             */
            Ordre ordre1 = new Ordre(kunde1, pizza2);
            Ordre ordre2 = new Ordre(kundeAnonym, pizza1);
            Ordre ordre3 = new Ordre(kunde2, pizza3);


            /*
             * Udskrivning
             */

            Console.WriteLine("De tre pizzaer");
            Console.WriteLine(pizza1);
            Console.WriteLine(pizza2);
            Console.WriteLine(pizza3);
            Console.WriteLine(); // blank linje

            Console.WriteLine("De tre kunder");
            Console.WriteLine(kundeAnonym);
            Console.WriteLine(kunde1);
            Console.WriteLine(kunde2);
            Console.WriteLine(); // blank linje

            Console.WriteLine("De tre ordre");
            Console.WriteLine(ordre1);
            Console.WriteLine(ordre2);
            Console.WriteLine(ordre3);
            Console.WriteLine(); // blank linje




            /*
             * UML 2
             */

            // Kunde katalog
            CustomerFile kunder = new CustomerFile();
            kunder.Create(kundeAnonym);
            kunder.Create(kunde1);
            kunder.Create(kunde2);
            Console.WriteLine("      Alle i CustomerFile");
            Console.WriteLine(kunder.PrintMenu());

            kundeAnonym.Name = "Vibeke";
            kunder.Update(kundeAnonym);
            Console.WriteLine("      Update CustomerFile");
            Console.WriteLine(kunder.PrintMenu());

            kunder.Delete(kundeAnonym.Telefon);
            Console.WriteLine("      Delete/ReadAll CustomerFile");
            foreach(Kunde k in kunder.ReadAll())
            {
                Console.WriteLine(k);
            }



            // Pizza MenuKort
            PizzaMenu menuCard = new PizzaMenu();

            menuCard.Create(pizza1);
            menuCard.Create(pizza2);
            menuCard.Create(pizza3);
            Console.WriteLine("      Alle i Pizza Menu kortet");
            Console.WriteLine(menuCard.PrintMenu());

            pizza1.Pris = 101;
            menuCard.Update(pizza1);
            Console.WriteLine("      Update Pizza Menu kortet");
            Console.WriteLine(menuCard.PrintMenu());

            menuCard.Delete(pizza1.Nummer);
            Console.WriteLine("      Delete/ReadAll Pizza Menu kortet");
            foreach (Pizza p in menuCard.ReadAll())
            {
                Console.WriteLine(p);
            }

            Console.WriteLine();
            Pizza fundetPizza = menuCard.SearchPizza(6);
            Console.WriteLine("      Search Pizza Menu kortet - findes");
            Console.WriteLine(fundetPizza);
            
            Pizza ikkefundetPizza = menuCard.SearchPizza(16);
            Console.WriteLine("      Search Pizza Menu kortet - findes ikke");
            Console.WriteLine(ikkefundetPizza);

        }
    }
}
