using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Pizza
{
    public class CustomerFile
    {
        // instance field - liste af kunder
        private readonly List<Kunde> _kunder = new List<Kunde>();

        public void Create(Kunde kunde)
        {
            _kunder.Add(kunde);
        }

        public List<Kunde> ReadAll()
        {
            return new List<Kunde>(_kunder);
        }

        public Kunde ReadKunde(string tlf)
        {
            foreach(Kunde k in _kunder)
            {
                if (k.Telefon == tlf)
                {
                    return k;
                }
            }

            return null;
        }

        public void Update(Kunde kunde)
        {
            Kunde fundetKunde = ReadKunde(kunde.Telefon);
            if (fundetKunde is not null)
            {
                fundetKunde.Name = kunde.Name;
            }
            // else ingen opdatering
        }

        public Kunde Delete(string tlf)
        {
            Kunde fundetKunde = ReadKunde(tlf);
            if (fundetKunde is not null)
            {
                _kunder.Remove(fundetKunde);
                return fundetKunde;
            }

            return null;
        }

        public string PrintMenu()
        {
            String str = "";

            foreach(Kunde k in _kunder)
            {
                str = str + k.ToString() + "\n"; // indsætte ny linje mellem kunderne
            }


            return str;
        }
    }
}
