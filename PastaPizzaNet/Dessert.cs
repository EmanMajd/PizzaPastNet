using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastaPizzaNet
{
    public class Dessert : IBedrag
    {
        private Desserten naam;
        private decimal prijs;

        

        public Dessert(Desserten naam, decimal prijs)
        {
            Naam = naam;
            Prijs = prijs;
            
        }

        public Desserten Naam { get => naam; set => naam = value; }
        public decimal Prijs { get => prijs;set => prijs = value; }

        public decimal BerekenBedrag()
        {

            return this.prijs;

        }
        public override string ToString()
        {
           
                return $"Dessert : {this.Naam} ({this.Prijs} euro)";
            
        }
    }
}
