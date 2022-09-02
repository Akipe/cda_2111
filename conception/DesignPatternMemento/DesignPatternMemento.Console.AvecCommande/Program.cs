using DesignPatternMemento.UML.AvecCommande;
using DesignPatternMemento.UML.AvecCommande.Commandes;

Editeur editeur = new Editeur();
Commande manager = new Commande(editeur);

CommandeEffacer cmdEffacer = new CommandeEffacer(editeur);

editeur.Contenu = "Ceci est un test de contenu";
Console.WriteLine("Contenu de l'editeur : " + editeur.Contenu);

manager.Executer(cmdEffacer);
Console.WriteLine("Contenu de l'editeur : " + editeur.Contenu);

manager.Annuler();

