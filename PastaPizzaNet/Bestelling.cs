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

        public decimal Aantal { get => aantal; set => aantal = 1; }

        public decimal BerekenBedrag()
        {
            decimal totaalKost = besteldgerecht.BerekenBedrag() + drank.BerekenBedrag() + dessert.BerekenBedrag();

            return totaalKost;
        }

        public override string ToString()
        {
            return klant.ToString() + besteldgerecht.ToString() + drank.ToString() + dessert.ToString() +
                   $" \n Totaal Kost : {BerekenBedrag()}";
        }
    }
}
