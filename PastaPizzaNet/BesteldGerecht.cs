using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastaPizzaNet
{
    public class BesteldGerecht : IBedrag
    {
        public Gerecht gerecht;
        public Groote groote;
        public List<Extras> extras;

        public BesteldGerecht() : this(new Pizza(), Groote.Klein , new List<Extras> { })
        {
          
        }
        public BesteldGerecht(Gerecht gerecht , Groote groote , List<Extras> extras) 
        {
            this.gerecht = gerecht;
            this.groote = groote;
            this.extras = extras;
        }



        public string alleExtras(List<Extras> extras)
        {
            if (extras.Count != 0)
            {
                
                return String.Join("  ", extras);
            }
            else
            {
                return "";
            }
        }

        public decimal BerekenBedrag()
        {
          decimal gerechtkost = gerecht.BerekenBedrag();
            if (groote == Groote.Groot)
            {
                gerechtkost += 3;
            }

            if(extras.Count != 0)
            {
                int extracout = extras.Count;
                gerechtkost += extracout;
                
            }

            return gerechtkost;
        }

        public override string ToString()
        {
            return  this.gerecht.ToString() +
                    $"( {this.groote} )" +
                    $" extra : {alleExtras(this.extras)} " +
                    $"( bedrag: {this.BerekenBedrag()} euro) \n";
        }

    }
}
