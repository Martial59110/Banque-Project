# BanqueKGMF

# Introduction
Bienvenue dans l'application bancaire console ! En tant que membre de l'équipe de développement de l'application, vous contribuez à la création d'une expérience bancaire numérique de pointe. L'objectif principal de ce projet est de développer une application bancaire basée sur la console pour rationaliser les processus internes de gestion des comptes et de suivi des transactions.

![Banque (1)](https://github.com/simplon-lille-csharp-dotnet/BanqueKGMF/assets/150059186/5b5fbfd1-dc8d-4bbd-aede-3524fce19c7e)

![util](https://github.com/simplon-lille-csharp-dotnet/BanqueKGMF/assets/150059186/1f280b7f-5488-4d1a-a190-a594fab1e1b0)

<br/><br/>


# Objectifs du Projet

## 1. Gestion Interne des Comptes
   
L'application, nommée "Application Bancaire Console DevBank," vise à améliorer la gestion interne des comptes pour les employés de la banque. Les fonctionnalités clés comprennent :

* Consultation du Solde du Compte : Les employés peuvent vérifier le solde d'un compte spécifique.

* Dépôts et Retraits : L'application facilite les dépôts et les retraits des comptes clients.

* Suivi des Transactions : Elle permet aux employés de suivre et de consulter l'historique des transactions des clients.

## 2. Prototype pour les Futurs Services Client
   
Bien qu'initialement conçue pour un usage interne, l'application sert de prototype pour le développement futur d'interfaces destinées aux clients. Cela pose les bases d'une expérience bancaire numérique fluide et conviviale pour les clients de DevBank.

# Pour Commencer

Pour commencer avec l'Application Bancaire Console DevBank, suivez ces étapes :

* Clonez le dépôt sur votre machine locale.
* Ouvrez le projet dans Visual Studio Code.
* Exécutez dotnet run dans le terminal.

 # Aperçu du Code
L'application est développée en utilisant C# et Visual Studio Code. Voici un bref aperçu des principaux composants du code :

* CompteBancaire (Gestion des Comptes)
La classe CompteBancaire gère les opérations de base sur les comptes, notamment la vérification du solde, les dépôts, les retraits et l'affichage de l'historique des transactions.

* IHM (Interface Utilisateur)
La classe IHM est responsable de l'interface utilisateur, offrant des options pour gérer les comptes, consulter les soldes, effectuer des dépôts et des retraits, et afficher l'historique des transactions.

* CompteCourant (Compte Courant)
La classe CompteCourant étend CompteBancaire pour inclure des fonctionnalités spécifiques à un compte courant, telles qu'une autorisation de découvert.

* Transaction (Historique des Transactions)
La classe Transaction représente une transaction bancaire, stockant des détails tels que le type, le montant, la date et la description.

* Itransactionnel (Interface de CompteBancaire)
L'interface Itransactionnel définit les méthodes pour effectuer des retraits et des dépôts, assurant une cohérence entre différents types de comptes.

* Program (Point d'Entrée de l'Application)
La classe Program contient la méthode principale et orchestre le flux de l'application console.

# Utilisation
* Exécutez l'application.
* Choisissez parmi les options du menu pour effectuer diverses opérations bancaires.
* Suivez les invites à l'écran pour effectuer des transactions et consulter les informations du compte.

# Directives de Contribution
Nous accueillons les contributions de l'équipe de développement DevBank. Si vous avez des suggestions, des rapports de bugs ou de nouvelles fonctionnalités à ajouter, veuillez suivre les normes de codage établies et créer une pull request.

Joyeux codage ! 🚀
