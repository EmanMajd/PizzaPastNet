using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastaPizzaNet
{
    public class Bestelling : IBedrag
    {
        public Klant klant;
        public Drank drank = new FriesDrank();
        public Dessert dessert = new Dessert();
        public BesteldGerecht besteldgerecht;

        private decimal aantal;

       

       public Bestelling() {
            this.klant = new Klant();
            this.drank = new FriesDrank();
            this.dessert = new Dessert();
            this.besteldgerecht = new BesteldGerecht();
            this.aantal = 1;
        }

        public Bestelling(Klant klant, BesteldGerecht besteldGerecht, Drank drank, Dessert dessert , decimal aantal)
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
            if (drank == null)
            {
               return totaalKost = besteldgerecht.BerekenBedrag() + dessert.BerekenBedrag();
            }
            else
            {
                totaalKost = besteldgerecht.BerekenBedrag() + drank.BerekenBedrag() + dessert.BerekenBedrag();
                totaalKost = (totaalKost * this.Aantal);
                korting = (totaalKost * 10 )/ 100;

                return (totaalKost - korting);
            }
        }

        public override string ToString()
        {

            
            return klant.ToString() + besteldgerecht.ToString() + drank.ToString() + dessert.ToString() +
                    $" \nAantal: {this.Aantal} " +$"\nBedrag  van deze bestelling : {BerekenBedrag()} \n";
        }
    }
}
