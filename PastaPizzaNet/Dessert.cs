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
        public decimal Prijs { get => prijs;set => prijs = BerekenBedrag(); }

        public decimal BerekenBedrag()
        {

            if (this.Naam == Desserten.Tiramisu) {
                return 3;
            } else if (this.Naam == Desserten.Ijs){
                return 3;
            }else if(this.Naam == Desserten.Cake)
            {
                return 2;
            }
            else
            {
                return this.prijs;
            }
       
        }

        public override string ToString()
        {
            return $"Dessert : {this.Naam} (prijs {this.Prijs}) \n";
        }
    }
}
