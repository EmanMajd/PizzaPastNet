using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastaPizzaNet 
{
    public class Pizza : Gerecht
    {
        public List<string> Onderdelen { get; set; }

        public Pizza(string naam, decimal prijs, List<string> onderdelen): base(naam, prijs) 
        {
            this.Onderdelen= onderdelen;
        }

        public string alleOnderdelen(List<string> onderdelen)
        {
            if (onderdelen.Count != 0)
            {
                string ingredienten = "";
                foreach (string onderdeel in onderdelen)
                {
                    ingredienten += $"{onderdeel} , ";
                }
                return ingredienten;
            }
            else
            {
                return "Pizza met Basis onderdelen";
            }
        }
        public override string ToString()
        {
            return $"Gerecht : Pizza {this.Naam} " +
                   $" (prijs {this.Prijs} EUR )" +
                   $" Onderdelen : {alleOnderdelen(this.Onderdelen)} ";
        }

        public override decimal BerekenBedrag()
        {
            return this.Prijs;
        }
    }
}
