namespace PastaPizzaNet
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {

                var bestellings = new Bestellings().GetBestellings();
                var allebestellings = from bestelling in bestellings select bestelling;
                int index = 0;
                foreach (var bestelling in allebestellings)
                {
                    index++;
                    Console.WriteLine($"Bestelling {index} : \n");
                    Console.WriteLine(bestelling.ToString(), bestelling.BerekenBedrag());

                }

                var jans = from bestelling1 in bestellings
                           where bestelling1.klant.Name == "Jan Janssens"
                           select bestelling1;


                Console.WriteLine($"Bestelling van Jan Janssens: \n");
                foreach (var bestelling1 in jans)
                {

                    Console.WriteLine(bestelling1.ToString(), bestelling1.BerekenBedrag());

                }

                var groupd = from bestelling2 in bestellings
                             group bestelling2 by bestelling2.klant.Name != "";


                decimal bedraag = 0;
                Console.WriteLine("Bekende Klanten");

                foreach (var bekend in groupd)
                {
                    foreach (var bekendklant in bekend)
                    {
                        if (bekend.Key)
                        {
                            Console.WriteLine(bekendklant.ToString(), bekendklant.BerekenBedrag());
                            bedraag += bekendklant.BerekenBedrag();
                        }


                    }
                }
                Console.WriteLine("Totaal bedraag voor bekende klanten is : " + bedraag + " Euro");



            }
            catch (FriesDrank.geenJuisteFriesDrankException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (WarmeDrank.geenJuisteWarmeDrankException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}