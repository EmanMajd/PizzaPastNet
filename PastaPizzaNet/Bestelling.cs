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
        public Drank drank;
        public Dessert dessert;
        public BesteldGerecht besteldgerecht;

        private decimal aantal;

        public Bestelling(Klant klant, BesteldGerecht besteldGerecht, Drank drank, Dessert dessert) {
            this.klant = klant;
            this.drank = drank;
            this.dessert = dessert;
            this.besteldgerecht = besteldGerecht;
        }

        public Bestelling(Klant klant, BesteldGerecht besteldGerecht, Drank drank)
        {
            this.klant = klant;
            this.drank = drank;
            this.besteldgerecht = besteldGerecht;
        }

        public Bestelling(Klant klant, BesteldGerecht besteldGerecht,Dessert dessert)
        {
            this.klant = klant;
            this.dessert = dessert;
            this.besteldgerecht = besteldGerecht;
        }
        public Bestelling(Klant klant, BesteldGerecht besteldGerecht)
        {
            this.klant = klant;
            this.besteldgerecht = besteldGerecht;
        }

        public decimal Aantal { get => aantal; set => aantal = 1; }

        public decimal BerekenBedrag()
        {
            decimal totaalKost = 0;
            if (drank == null)
            {
               return totaalKost = besteldgerecht.BerekenBedrag() + dessert.BerekenBedrag();
            }
            else
            {
                totaalKost = besteldgerecht.BerekenBedrag() + drank.BerekenBedrag() + dessert.BerekenBedrag();
                totaalKost = totaalKost - (totaalKost * 10 / 100);

                return totaalKost;
            }
        }

        public override string ToString()
        {

            if(drank == null)
            return klant.ToString() + besteldgerecht.ToString() + dessert.ToString() +$" \n Totaal Kost : {BerekenBedrag()}";
            return klant.ToString() + besteldgerecht.ToString() + drank.ToString() + dessert.ToString() +
                   $"\nTotaal Kost : {BerekenBedrag()} \n";
        }
    }
}
