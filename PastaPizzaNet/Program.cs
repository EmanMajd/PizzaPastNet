namespace PastaPizzaNet
{
    public class Program
    {
        static void Main(string[] args)
        {
            Bestelling bestelling = new Bestelling( new Klant(1,"Eman"),
                new BesteldGerecht( new Pizza("Margaritta",10,new List<string> { "dvfv","vvf","vvf"}),Groote.Groot,new List<Extras> { Extras.look}),
                   new FriesDrank(Dranks.cocacola,2) , new Dessert(Desserten.Tiramisu,3));

            Console.WriteLine(bestelling.ToString());
        }
    }
}