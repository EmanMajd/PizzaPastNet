using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastaPizzaNet
{
    public abstract class Gerecht : IBedrag
    {
        public string Naam { get; init; }
        public decimal Prijs { get; set; }

        public Gerecht(string naam,decimal prijs) {
            this.Naam = naam;
            this.Prijs = prijs;
        }

        public override abstract string ToString();

        public abstract decimal BerekenBedrag();
        
    }
}
