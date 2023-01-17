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
                throw new geenJuisteFriesDrankException("Dit drank bestaat niet : kies uit (cocacola, water, limonade) ");
            }
        }

        public override decimal BerekenBedrag()
        {
            return this.Prijs;
        }

        public override string ToString()
        {
            return $"Drank: {base.Naam} ( {base.Prijs} euro ) \n";

        }

        public class geenJuisteFriesDrankException : Exception
        {

            public geenJuisteFriesDrankException(string message ) : base(message) {

     
            }
        }
    }
}
