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
            Pizza g = new Pizza("Margaritta", 8, new List<string> { "Tommaten sauce", "Mozarella" });
            BesteldGerecht bg = new BesteldGerecht(g, Groote.Groot, new List<Extras>{ Extras.kaas,Extras.brood});
            Drank drank = new WarmeDrank( Dranks.thee, 2 );
            Dessert dessert = new Dessert(Desserten.Ijs, 3);

            Bestelling bestelling1 = new Bestelling(Jan, bg,drank,dessert,2);



            Klant Piet = new Klant
            {
                Id = 2,
                Name = "Piet Peer"
            }; 
            Gerecht g1 = new Pasta("Gehakt Pasta", 15, "Pasta met gehakt en tommaten sauce");
            BesteldGerecht bg1 = new BesteldGerecht(g, Groote.Klein, new List<Extras> { });
            Drank drank1 = new FriesDrank(Dranks.water, 2);
            Dessert dessert1 = new Dessert(Desserten.Tiramisu, 3);

            Bestelling bestelling2 = new Bestelling(Piet, bg1, drank1, dessert1,1);

            Klant onbekend = new Klant{ Id = 3, Name = "" };
            Gerecht g2 = new Pizza("Pizza Napoli", 10, new List<string> { "tommat sauce","Mozarilla" ,"Ansjovis" , "Kappers" , "Olijven"});
            BesteldGerecht bg2 = new BesteldGerecht(g2, Groote.Groot, new List<Extras> { });
            Drank drank2 = new WarmeDrank(Dranks.thee, (decimal)2.5);
            Dessert dessert2 = new Dessert(Desserten.Ijs, 3);

            Bestelling bestelling3 = new Bestelling(Piet,bg2,drank2,dessert2,1);
           

            Bestelling bestelling4 = new Bestelling(Piet, bg2, drank2, dessert2, 1);


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
