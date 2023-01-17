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
                Console.WriteLine("***************************************************************");

                var jans = from bestelling1 in bestellings
                           where bestelling1.klant.Name == "Jan Janssens"
                           select bestelling1;

                decimal Jansbedrag = 0;
                Console.WriteLine($"Bestellings van kalnt Jan Janssens: \n");
                foreach (var bestelling1 in jans)
                {
                    Jansbedrag += bestelling1.BerekenBedrag();
                    Console.WriteLine(bestelling1.ToString(), bestelling1.BerekenBedrag());

                }
                Console.WriteLine($"Het totaal bedraag van alle bestellings van klanh-t Jan Janssens is : {Jansbedrag} euro \n");
                Console.WriteLine("***************************************************************");

                var groupd = from bestelling2 in bestellings
                             group bestelling2 by bestelling2.klant.Name
                             into groupdByName
                             orderby groupdByName.Key descending
                             select groupdByName;


                decimal totaalbedraag = 0;
                
                foreach (var bekendklant in groupd)
                {
                    if (bekendklant.Key != "")
                    {
                        Console.WriteLine("Bekende Klanten \n");

                    }
                    else
                    {
                        Console.WriteLine("OnBekende Klanten \n");

                    }
                    foreach (var n in bekendklant)
                    {
                        totaalbedraag += n.BerekenBedrag();
                        Console.WriteLine(n.ToString());
                    }
                    if (bekendklant.Key != "")
                    {
                        Console.WriteLine($"Totaal bedraag voor klant {bekendklant.Key} : {totaalbedraag} euro");
                        totaalbedraag = 0;
                    }
                    
                    Console.WriteLine("***************************************************************");

                }


            }
            catch (FriesDrank.geenJuisteFriesDrankException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (WarmeDrank.geenJuisteWarmeDrankException ex)
            {
                Console.WriteLine(ex.Message);
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}