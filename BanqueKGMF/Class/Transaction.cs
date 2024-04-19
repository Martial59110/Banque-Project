namespace BanqueKGMF.Class;
public class Transaction
{
    public enum TypeTransaction
    {
        VIREMENT,
        CARTE_BANCAIRE,
        PRELEVEMENT,
        RETRAIT,
        FRAIS_OPERATION
    }

    public DateTime Date { get; set; }
    public string Description { get; set; }
    public TypeTransaction Type { get; set; }
    public double Montant { get; set; }
    public Transaction(TypeTransaction type, double montant)
    {
        Type = type;
        Montant = montant;
         Date = DateTime.Now;
        Description = "Opération";
    }


}