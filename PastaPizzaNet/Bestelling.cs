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
            if (besteldgerecht != null && drank == null && dessert != null)
            {
                totaalKost = besteldgerecht.BerekenBedrag() + dessert.BerekenBedrag();
                totaalKost = (totaalKost * this.Aantal);

            }else if (besteldgerecht != null && drank != null && dessert == null)
            {
                totaalKost = besteldgerecht.BerekenBedrag() + drank.BerekenBedrag();
                totaalKost = (totaalKost * this.Aantal);

            }
            else if (drank == null && dessert == null)
            {
                totaalKost = besteldgerecht.BerekenBedrag();
                totaalKost = (totaalKost * this.Aantal);
            }else if(besteldgerecht == null)
            {
                if (drank == null && dessert != null)
                {
                    totaalKost = dessert.BerekenBedrag();
                    totaalKost = (totaalKost * this.Aantal);

                }
                else if (drank != null && dessert == null)
                {
                    totaalKost = drank.BerekenBedrag();
                    totaalKost = (totaalKost * this.Aantal);

                }
            }
            else { 

            totaalKost = besteldgerecht.BerekenBedrag() + drank.BerekenBedrag() + dessert.BerekenBedrag();
            totaalKost = (totaalKost * this.Aantal);
            korting = (totaalKost * 10) / 100;
        }
            return (totaalKost - korting);

        }

        public override string ToString()
        {

            if (besteldgerecht != null && drank == null && dessert != null)
            {
                return klant.ToString() + besteldgerecht.ToString() + dessert.ToString() +
                   $" \nAantal: {this.Aantal} " + $"\nBedrag  van deze bestelling : {BerekenBedrag()} \n";
            }else if (besteldgerecht != null && drank != null && dessert == null)
            {
                return klant.ToString() + besteldgerecht.ToString() + drank.ToString() +
                   $" \nAantal: {this.Aantal} " + $"\nBedrag  van deze bestelling : {BerekenBedrag()} \n";
            }
            else if (drank == null && dessert == null)
            {
                return klant.ToString() + besteldgerecht.ToString() +
                   $" \nAantal: {this.Aantal} " + $"\nBedrag  van deze bestelling : {BerekenBedrag()} \n";
            }
            else if (besteldgerecht == null)
            {
                if (drank == null && dessert != null)
                {
                    return klant.ToString() + dessert.ToString() +
                   $" \nAantal: {this.Aantal} " + $"\nBedrag  van deze bestelling : {BerekenBedrag()} \n";

                }
                else if (drank != null && dessert == null)
                {
                    return klant.ToString() + drank.ToString() +
                   $" \nAantal: {this.Aantal} " + $"\nBedrag  van deze bestelling : {BerekenBedrag()} \n";

                }
                return "";
            }
            else
            {

                return klant.ToString() + besteldgerecht.ToString() + drank.ToString() + dessert.ToString() +
                    $" \nAantal: {this.Aantal} " + $"\nBedrag  van deze bestelling : {BerekenBedrag()} \n";
            }
        }
    }
}



