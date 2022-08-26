using DesignPatternCommand.TelecommandeSimple;
using DesignPatternCommand.TelecommandeSimple.Choses;
using DesignPatternCommand.TelecommandeSimple.Commandes;

// Pour la lampe :

TelecommandeSimple telecommande = new TelecommandeSimple();
Lampe lampe = new Lampe();
CommandeAllumerLampe allumerLampCmd = new CommandeAllumerLampe(lampe);

Console.WriteLine(lampe.Etat());

telecommande.SetCommande(allumerLampCmd);
telecommande.boutonPresse();

Console.WriteLine(lampe.Etat());


// Pour la porte de garage :

PorteGarage porteGarage = new PorteGarage();
CommandeOuvrirPorteGarage ouvrirPorteGarageCmd = new CommandeOuvrirPorteGarage(porteGarage);

Console.WriteLine(porteGarage.statusFerme());

telecommande.SetCommande(ouvrirPorteGarageCmd);
telecommande.boutonPresse();

Console.WriteLine(porteGarage.statusFerme());
