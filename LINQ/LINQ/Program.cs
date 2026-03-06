using System;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kutsume esile LINQ meetodit(Sisesta numbritest 1-8)");
            Console.WriteLine("1. Filtreerimine ");
            Console.WriteLine("2. Sorteerimine ");
            Console.WriteLine("3. Andmete Projitseerimine ");
            Console.WriteLine("4. Andmete Vahelejätmine ");
            Console.WriteLine("5. Võtmine tingimuse alusel ");
            Console.WriteLine("6. Üksiku elemendi Leidmine ");
            Console.WriteLine("7. Statistika ");
            Console.WriteLine("8.TingimuslikKontoll ");
            Console.WriteLine("----------------------------");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Filtreerimine();//lõpetamata
                    break;

                case 2:
                    Sorteerimine();//lõpetamata
                    break;

                case 3:
                    AndmeteProjitseerimine();// Tehtud
                    break;

                case 4:
                    AndmeteVaheleJätmine();// Tehtud
                    break;

                case 5:
                    VõtmineTingimuseAlusel();// Tehtud
                    break;

                case 6:
                    ÜksikuElemendiLeidmine();// Tehtud
                    break;

                case 7:
                    Statistika();// poolik
                    break;

                case 8:
                    TingimuslikKontoll();// Tehtud
                    break;

                default:
                    Console.WriteLine("Vale valik");
                    break;
            }
        }
        public static void Filtreerimine()//leia kõik kliendid, kes eleavad tallinnas
        {

            //foreach
            {

            }
        }
        public static void Sorteerimine()//Sorteeri tooded hinna järgi kasvavalt
        // orderBy, thenBy, ThenByDescending
        {
            
            //foreach
            {

            }
        }
        public static void AndmeteProjitseerimine()
        {
            var result = ClientData.Client
                .Select(x => new
                {
                    Id = x.Id,
                    Name = x.Name
                });
            foreach (var item in result)
            {
                Console.WriteLine("Nimi: " + item.Name + ", Id: " + item.Id);
            }
        }
        public static void AndmeteVaheleJätmine()
        {
            Console.WriteLine("----------[ Skip ]----------");
            //kasuta skip'i ja jäta kolm tükki vahele
            var skip = ProductData.Product.SkipWhile(x => x.Price <= 20);

            foreach (var item in skip)
            {
                Console.WriteLine(item.Price);
            }
        }
        public static void VõtmineTingimuseAlusel()
        {
            Console.WriteLine("-------[ TakeWhile ]--------");

            var takeWhileResult = ProductData.Product.TakeWhile(x => x.Price < 50);

            foreach (var item in takeWhileResult)
            {
                Console.WriteLine(item.Id + " " + item.Name + " " + item.Price);
            }
        }
        public static void ÜksikuElemendiLeidmine()
        {
            string ClientId = ClientData.Client
                  .FirstOrDefault(x => x.Id == 2).Name;

                Console.WriteLine("Klient Id-ga 3: '{0}'.", ClientId);
        }
        public static void Statistika()
        {
            var MinPrice = ProductData.Product
            .Min(x => x.Price);

            Console.WriteLine("Kõige odavam toode on " + MinPrice + ".");

            //pole 'kogu laoväärtus', mitu toodet kuulub katekooriatesse'
        }
        public static void TingimuslikKontoll()
        {
            bool result = ProductData.Product.Any(x => x.Amount > 0);
            Console.WriteLine("Kas kõik tooted on laos olemas?");
            Console.WriteLine(result);
        }
    }//end
}

