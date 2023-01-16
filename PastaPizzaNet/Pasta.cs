using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastaPizzaNet
{
    public class Pasta : Gerecht
    {
        private string omschrijving;

        
        public Pasta( string naam, decimal prijs, string omschrijving) : base(naam,prijs){
            this.Omschrijving = omschrijving;
        }

        public string Omschrijving { get => omschrijving; set => omschrijving = value; }

        public override decimal BerekenBedrag()
        {
            return this.Prijs;
        }

        public override string ToString()
        {
            return $"Pasta {this.Naam}" +
                   $"({this.Prijs} euro )" +
                   $" {this.Omschrijving} ";
        }
    }
}
