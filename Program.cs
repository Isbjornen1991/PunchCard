namespace StampCardApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Fjern // foran linjen under når dere har laget klassen StampCard i StampCard.cs.
            // using StampCardApp;

            // Del 2: Vis at reglene virker.
            // Lag et kort, gi det stempler, og prøv å løse inn gratis kaffe.
            // Skriv ut resultatet med Console.WriteLine, slik at det er lett å se hva som skjer.

            StampCard stampCard = new StampCard("Lars");

            Console.WriteLine($"{stampCard.Stamps}");

            stampCard.AddStamp();
            stampCard.AddStamp();
            stampCard.AddStamp();

            Console.WriteLine($"{stampCard.Stamps}");



            // var card = new StampCard("Kari");


            // Del 3: Bryt reglene.
            // Når dere har fått koden til en annen gruppe, skriver dere forsøkene her.
            // Ikke endre StampCard.cs. Prøv bare herfra.


        }
    }
}
