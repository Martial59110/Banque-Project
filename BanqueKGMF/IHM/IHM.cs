using Banque.Class;

class IHM
{
    CompteBancaire monCompte = new CompteBancaire();
    public int ListChoice()
    {
        int choiceInput;

        do
        {
            Console.WriteLine($"======= Gérer le compte =======");
            Console.WriteLine("1. Consulter le solde");
            Console.WriteLine("2. Effectuer un dépôt");
            Console.WriteLine("3. Effectuer un retrait");
            Console.WriteLine("4. Afficher l'historique des transactions");
            Console.WriteLine("5. Quitter");
            Console.WriteLine("\nRentrez 1, 2, 3, 4 ou 5");

            string? userInput = Console.ReadLine();

            if (int.TryParse(userInput, out choiceInput) && choiceInput >= 1 && choiceInput <= 5)
            {
                break;
            }
            else
            {
                Console.WriteLine("Erreur : Veuillez saisir un nombre entier valide entre 1 et 5.");
            }

        } while (true);

        Console.Clear();
        return choiceInput;
    }
    public void ViewSolde(CompteCourant c1, CompteEpargne e1)
    {

        int choiceInput;

        do
        {
            Console.WriteLine($"Choisissez un compte : \n1) Compte courant ({c1.id})\n2) Compte épargne ({e1.id})");

            Console.WriteLine("\nRentrez 1 ou 2 pour choisir un compte.");

            string? userInput = Console.ReadLine();

            if (int.TryParse(userInput, out choiceInput) && choiceInput >= 1 && choiceInput <= 2)
            {
                Console.Clear();
                if (choiceInput == 1)
                {
                    Console.WriteLine($"La solde actuelle est de : {c1.solde} euros");
                }
                else
                {
                    Console.WriteLine($"La solde actuelle est de : {e1.solde} euros");
                }
                break;
            }
            else
            {
                Console.WriteLine("Erreur : Veuillez saisir un nombre entier valide entre 1 et 2.");
            }

        } while (true);


    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="compteCourant"></param>
    /// <param name="compteEpargne"></param>
    public void Virement(CompteCourant compteCourant, CompteEpargne compteEpargne)
    {
        int choiceInput;

        do
        {
            Console.WriteLine($"Choisissez un compte : \n1) Compte courant ({compteCourant.id})\n2) Compte épargne ({compteEpargne.id})");
            Console.WriteLine("\nRentrez 1 ou 2 pour choisir un compte.");

            string? userInput = Console.ReadLine();

            if (!int.TryParse(userInput, out choiceInput) || choiceInput < 1 || choiceInput > 2)
            {
                Console.WriteLine("Erreur : Veuillez saisir un nombre entier valide entre 1 et 2.");
            }
            else
            {
                Console.Clear();
                if (choiceInput == 1)
                {
                    ChoisirMontantEffectuerVirement(compteCourant);
                    break;
                }
                
                if (choiceInput == 2)
                {
                    ChoisirMontantEffectuerVirement(compteEpargne);
                    break;
                }

                Console.WriteLine("Erreur : Veuillez saisir 1 ou 2.");

                break;
            }

        } while (true);
    }

    private void ChoisirMontantEffectuerVirement(CompteBancaire compteCourant)
    {
        Console.WriteLine("Entrez le montant du dépôt : ");
        string? montantStr = Console.ReadLine();

        if (double.TryParse(montantStr, out double montant))
        {
            compteCourant.EffectuerVirement(montant);
        }
        else
        {
            Console.WriteLine("Erreur : Veuillez saisir un montant valide.");
        }
    }

    public void Retrait(CompteCourant c1, CompteEpargne e1)
    {
        int choiceInput;

        do
        {
            Console.WriteLine($"Choisissez un compte : \n1) Compte courant ({c1.id})\n2) Compte épargne ({e1.id})");
            Console.WriteLine("\nRentrez 1 ou 2 pour choisir un compte.");

            string? userInput = Console.ReadLine();

            if (int.TryParse(userInput, out choiceInput) && choiceInput >= 1 && choiceInput <= 2)
            {
                Console.Clear();
                if (choiceInput == 1)
                {
                    Console.WriteLine("Entrez le montant du retrait : ");
                    string? montantStr = Console.ReadLine();

                    if (double.TryParse(montantStr, out double montant))
                    {
                        c1.EffectuerRetrait(montant);

                    }
                    else
                    {
                        Console.WriteLine("Erreur : Veuillez saisir un montant valide.");
                    }
                }
                else if (choiceInput == 2)
                {
                    Console.WriteLine("Entrez le montant du retrait : ");
                    string? montantStr = Console.ReadLine();

                    if (double.TryParse(montantStr, out double montant))
                    {
                        e1.EffectuerRetrait(montant);

                    }
                    else
                    {
                        Console.WriteLine("Erreur : Veuillez saisir un montant valide.");
                    }
                }
                else
                {
                    Console.WriteLine("Erreur : Veuillez saisir 1 ou 2.");
                }

                break;
            }
            else
            {
                Console.WriteLine("Erreur : Veuillez saisir un nombre entier valide entre 1 et 2.");
            }

        } while (true);
    }
    public void selectChoice(int? choice, CompteCourant compteCourant, CompteEpargne compteEpargne)
    {
        switch (choice)
        {
            case 1:
                ViewSolde(compteCourant, compteEpargne);
                break;
            case 2:
                Virement(compteCourant, compteEpargne);
                break;
            case 3:
                Retrait(compteCourant, compteEpargne);
                break;
            case 4:
                if (compteCourant != null)
                {
                    compteCourant.AfficherHistorique();
                }
                else if (compteEpargne != null)
                {
                    compteEpargne.AfficherHistorique();
                }
                break;
            case 5:
                return;
            default:
                break;
        }
    }
}