using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastaPizzaNet
{
    public class WarmeDrank : Drank
    {
        public WarmeDrank(Dranks naam, decimal prijs):base(naam, prijs) { }


        public override decimal BerekenBedrag()
        {
            return (decimal)2.5;
        }
        public override string ToString()
        {
            return base.Naam == Dranks.koffie || base.Naam == Dranks.thee ? $"Drank {base.Naam} ( prijs {base.Prijs} ) \n" : " verkeerde dranknaam \n";
        }
    }
}
