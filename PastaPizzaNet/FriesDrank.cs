using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastaPizzaNet
{
    public class FriesDrank : Drank
    {
        List<Dranks> juisteDranks = new List<Dranks>{ Dranks.cocacola,Dranks.water,Dranks.limonade};
        public FriesDrank(Dranks naam , decimal prijs):base(naam,prijs)
        {
            if (!juisteDranks.Contains(base.Naam)){
               base.Naam = Dranks.serveNiet;
                this.Prijs = 0;

            }
        }

        public override decimal BerekenBedrag()
        {
            return 2;
        }

        public override string ToString()
        {
            //return base.Naam == Dranks.water || base.Naam == Dranks.limonade || base.Naam == Dranks.cocacola ? $"Drank : {base.Naam} ( prijs {base.Prijs} ) \n" : " verkeerde dranknaam \n";       
            return $"Drank : {base.Naam} ( prijs {base.Prijs} ) \n";

        }
    }
}
