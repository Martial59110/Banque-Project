using BanqueKGMF.Class;

namespace Banque.Class;

 public class CompteCourant : CompteBancaire
    {
        private double decouvertAutorise;
        Random random = new Random();
        public int id = new Random().Next(0, 1000);
        public CompteCourant()
        {
             this.id = new Random().Next(MINVALUECOMPTEID, MAXVALUECOMPTEID);
        }
      

        public new void EffectuerRetrait(double montant)
        {
            if (montant > 0.01 && Math.Round(montant, 2) == montant && this.solde - montant >= -decouvertAutorise)
            {
                Console.WriteLine($"Solde avant le retrait : {solde:F2}Euros");
                this.solde -= montant;
                Console.WriteLine($"Solde après le retrait : {solde:F2}Euros");
                transactions.Add(new Transaction( Transaction.TypeTransaction.RETRAIT, montant));
                Console.WriteLine($"Le retrait a été effectué avec succès.");
                AppliquerFraisOperation(montant);
            }
            else
            {
                Console.WriteLine("Erreur : Montant de retrait invalide ou découvert dépassé");
            }
        }}

