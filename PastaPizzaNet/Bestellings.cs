using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastaPizzaNet
{
    public class Bestellings
    {
        public List<Bestelling> GetBestellings()
        {
            Klant Jan = new Klant
            {
                Id = 1,
                Name = "Jan Janssens"
            }; 
            Pizza g = new Pizza("Margaritta", 10, new List<string> { "tommat sauce", "groenten" });
            BesteldGerecht bg = new BesteldGerecht(g, Groote.Groot, new List<Extras>{ Extras.kaas,Extras.brood});
            Drank drank = new FriesDrank( Dranks.thee, 2 );
            Dessert dessert = new Dessert(Desserten.Tiramisu, 3);

            Bestelling bestelling1 = new Bestelling(Jan, bg,drank,dessert);



            Klant Piet = new Klant
            {
                Id = 2,
                Name = "Piet Peer"
            }; 
            Gerecht g1 = new Pasta("Gehakt Pasta", 15, "Pasta met gehakt en tommaten sauce");
            BesteldGerecht bg1 = new BesteldGerecht(g1, Groote.Groot, new List<Extras> { Extras.kaas});
            Drank drank1 = new FriesDrank(Dranks.cocacola, 2);
            Dessert dessert1 = new Dessert(Desserten.Ijs, 3);

            Bestelling bestelling2 = new Bestelling(Piet, bg1, drank1, dessert1);

            Klant onbekend = new Klant{ Id = 3, Name = "" };
            Gerecht g2 = new Pizza("Tonijn Pizza", 15, new List<string> { "tommat sauce","tonijn" ,"groenten" });
            BesteldGerecht bg2 = new BesteldGerecht(g2, Groote.Groot, new List<Extras> { Extras.kaas });
            Drank drank2 = new FriesDrank(Dranks.limonade, 2);
            Dessert dessert2 = new Dessert(Desserten.Cake, 3);

            Bestelling bestelling3 = new Bestelling(onbekend, bg2, dessert2);

            Bestelling bestelling4 = new Bestelling(Piet, bg2, drank2, dessert2);


            // var gg = new Pizza { pizzaNaam = "Margaritta", pizzaPrijs = 10, Onderdelen = new List<string> { "tommat sauce", "groenten" } };
            Klant klnt = new Klant
            {
                Id = 1,
                Name = "Adel"
            };
            return new List<Bestelling> {bestelling1 , bestelling2 , bestelling3 , bestelling4};
        }
    }
}
