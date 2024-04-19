namespace Banque.Class;

 public class CompteEpargne : CompteBancaire
    {
        private double tauxInteret;
        Random random = new Random();
        public int id = new Random().Next(0, 1000);

        public CompteEpargne()
        {
             this.id = new Random().Next(MINVALUECOMPTEID, MAXVALUECOMPTEID);
        }

        public void CalculerInteret()
        {
            double interet = solde * tauxInteret / 100;
            Console.WriteLine($"Intérêt calculé : {interet:F2}€");
        }
    }

