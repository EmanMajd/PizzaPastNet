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

        public Pizza() : this("" , 0 , new List<string> { } ) { }
        public Pizza(string naam, decimal prijs, List<string> onderdelen): base(naam, prijs) 
        {
            this.Onderdelen= onderdelen;
            
        }
        

        public string alleOnderdelen(List<string> onderdelen)
        {

           
            if (onderdelen.Count != 0)
            {

                return String.Join(" - ", onderdelen);
            }
            else
            {
                return "Pizza met Basis onderdelen";
            }
        }
        public override string ToString()
        {
            return $"Gerecht : Pizza {base.Naam} " +
                   $" ( prijs {base.Prijs} EUR )" +
                   $" {alleOnderdelen(this.Onderdelen)} ";
        }

        public override decimal BerekenBedrag()
        {
            return this.Prijs;
        }
    }
}
