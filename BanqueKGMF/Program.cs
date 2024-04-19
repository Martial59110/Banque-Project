
using Banque.Class;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CompteBancaire monCompte = new CompteBancaire();
            CompteCourant c1 = new CompteCourant();
            CompteEpargne e1 = new CompteEpargne();

            IHM ihm = new IHM();
            
            while (true)
            {
                int? choice = ihm.ListChoice();
                
                if (choice == 5)
                {
                   
                    break;
                }

                ihm.selectChoice(choice, c1, e1);

                
                Console.WriteLine("\nAppuyez sur une touche pour revenir au menu...");
                Console.ReadKey();
                
                Console.Clear(); 
            }
        }
    }
}