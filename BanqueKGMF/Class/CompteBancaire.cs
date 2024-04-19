using System;
using System.Collections.Generic;
using Banque.Interface;
using BanqueKGMF.Class;

namespace Banque.Class;
public class CompteBancaire : Itransactionnel
{
    protected const int MINVALUECOMPTEID = 1000000;
    protected const int MAXVALUECOMPTEID = 100000000;
    private const double MONTANTMINIMUM = 0.01;
    private const int PRECISIONMAX = 2;
    private const double FRAIS_OPERATION = 0.5; 
private const double FRAIS_OPERATION_PERCENTAGE = 0.01;
    public double FraisOperation { get; private set; }
    private  int id;
    public double solde;
    protected List<Transaction> transactions;
    public int Id { get; private set; }

     public void AppliquerFraisOperation(double montant)
    {
         double frais = montant * FRAIS_OPERATION_PERCENTAGE;
        solde -= frais;
         EnregistrerTransaction(Transaction.TypeTransaction.FRAIS_OPERATION, frais);
        Console.WriteLine($"Frais d'opération appliqués : {frais:F2} Euros");
    }

    public CompteBancaire()
{
    this.id = new Random().Next(MINVALUECOMPTEID, MAXVALUECOMPTEID);
    this.solde = 0.0;
    this.transactions = new List<Transaction>();
    FraisOperation = 5;
    this.Id = this.id; 
}

    public void ConsulterSolde()
    {
        Console.WriteLine($"Numéro de compte : {id}");
        Console.WriteLine($"Solde actuel : {solde:F2}Euros");
    }

   public void EffectuerVirement(double montant)
    {
        try
        {
            if (montant > MONTANTMINIMUM && Math.Round(montant, PRECISIONMAX) == montant)
            {
                Console.WriteLine($"Solde avant le virement : {solde:F2}Euros");
                solde += montant;
                EnregistrerTransaction(Transaction.TypeTransaction.VIREMENT, montant);
                Console.WriteLine($"Solde après le virement : {solde:F2}Euros");
                Console.WriteLine($"Le virement a été effectué avec succès.");
                AppliquerFraisOperation(montant);
            }
            else
            {
                throw new InvalidOperationException("Erreur : Montant de virement invalide");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"{ex.Message}");
        }
    }

    public void EffectuerRetrait(double montant)
    {
        try
        {
            if (montant > MONTANTMINIMUM && Math.Round(montant, PRECISIONMAX) == montant && solde >= montant)
            {
                Console.WriteLine($"Solde avant le retrait : {solde:F2}Euros");
                solde -= montant;
                EnregistrerTransaction(Transaction.TypeTransaction.RETRAIT, montant);
                Console.WriteLine($"Solde après le retrait : {solde:F2}Euros");
                Console.WriteLine($"Le retrait a été effectué avec succès.");
                AppliquerFraisOperation(montant);
            }
            else
            {
                throw new InvalidOperationException("Erreur : Montant de retrait invalide");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"{ex.Message}");
        }
    }
 public void AfficherHistorique()
    {
        Console.WriteLine($"======= Historique des transactions =======");
        foreach (var transaction in transactions)
        {
            Console.WriteLine($"{transaction.Type} - Montant : {transaction.Montant:F2} Euros");
        }
    }
     private void EnregistrerTransaction(Transaction.TypeTransaction type, double montant)
        {
            transactions.Add(new Transaction(type, montant));
        }
}
