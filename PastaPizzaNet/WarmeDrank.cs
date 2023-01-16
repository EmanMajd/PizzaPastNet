﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PastaPizzaNet.FriesDrank;

namespace PastaPizzaNet
{
    public class WarmeDrank : Drank
    {
        List<Dranks> juisteDranks = new List<Dranks> { Dranks.thee, Dranks.koffie };

        public WarmeDrank() : this(Dranks.thee , 3) { }
        public WarmeDrank(Dranks naam, decimal prijs):base(naam, prijs) {
            if (!juisteDranks.Contains(base.Naam))
            {
                throw new geenJuisteWarmeDrankException("Dit drank bestaat niet : kies uit ( thee , koffie) ");
            }
        }


        public override decimal BerekenBedrag()
        {
            return (decimal)2.5;
        }
        public override string ToString()
        {
            return $"Drank: {base.Naam} ( {base.Prijs} euro ) \n";
        }

        public class geenJuisteWarmeDrankException : Exception
        {

            public geenJuisteWarmeDrankException(string message) : base(message)
            {


            }
        }
    }
}
