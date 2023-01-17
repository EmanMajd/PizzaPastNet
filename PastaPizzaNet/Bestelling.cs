using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PastaPizzaNet
{
    public class Bestelling : IBedrag
    {
        public Klant klant;
        public Drank drank;
        public Dessert dessert;
        public BesteldGerecht besteldgerecht;

        private decimal aantal;





        public Bestelling(Klant klant = null, BesteldGerecht besteldGerecht = null, Drank drank = null, Dessert dessert = null, decimal aantal = 0)
        {
            this.klant = klant;
            this.drank = drank;
            this.dessert = dessert;
            this.besteldgerecht = besteldGerecht;
            this.aantal = aantal;
        }

        public decimal Aantal { get => aantal; set => aantal = 1; }

        public decimal BerekenBedrag()
        {
            decimal totaalKost = 0;
            decimal korting = 0;
            
            totaalKost = (besteldgerecht is null ? 0 : besteldgerecht.BerekenBedrag()) + (drank is null ? 0 : drank.BerekenBedrag()) + (dessert is null? 0 : dessert.BerekenBedrag());
            totaalKost = (totaalKost * this.Aantal);
            
            if (besteldgerecht != null && drank != null && dessert != null)
            {
                korting = (totaalKost * 10) / 100;
                return (totaalKost - korting);
            }
            return (totaalKost - korting);

        }

        public override string ToString()
        {

                    return klant.ToString() + 
                         (besteldgerecht is null ? "" : besteldgerecht.ToString() )+ 
                         (drank is null ? "" : drank.ToString()) + 
                         (dessert is null ? "" :  dessert.ToString()) +
                           $" \nAantal: {this.Aantal} " + $"\nBedrag  van deze bestelling : {this.BerekenBedrag()} \n";

            
        }
    }
}



