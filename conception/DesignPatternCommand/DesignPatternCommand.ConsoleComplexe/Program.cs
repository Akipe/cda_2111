using DesignPatternCommand.TelecommandeComplexe;
using DesignPatternCommand.TelecommandeComplexe.Choses;
using DesignPatternCommand.TelecommandeComplexe.Commandes;



// Télécommande complexe
Console.WriteLine("\n");
Console.WriteLine("Télécommande complexe");
Console.WriteLine("\n");

TelecommandeComplexe telecommande = new TelecommandeComplexe();

Lampe lampe = new Lampe();
StereoAvecCD stereo = new StereoAvecCD();

CommandeAllumerLampe allumerLampeCmd = new CommandeAllumerLampe(lampe);
CommandeEteindreLampe eteindreLampeCmd = new CommandeEteindreLampe(lampe);

telecommande.SetCommande(
    1,
    allumerLampeCmd,
    eteindreLampeCmd
);

CommandeAllumerStereo allumerStereoCmd = new CommandeAllumerStereo(stereo);
CommandeEteindreStereo eteindreStereoCmd = new CommandeEteindreStereo(stereo);

telecommande.SetCommande(
    2,
    allumerStereoCmd,
    eteindreStereoCmd
);

Console.WriteLine(telecommande);

Console.WriteLine(lampe.Etat());
telecommande.ActionnerBoutonMarche(1);
Console.WriteLine(lampe.Etat());
telecommande.ActionnerBoutonEteindre(1);
Console.WriteLine(lampe.Etat());



// Annulation simple
Console.WriteLine("\n");
Console.WriteLine("Annulation simple");
Console.WriteLine("\n");

telecommande.ActionnerBoutonMarche(1);
Console.WriteLine(lampe.Etat());
telecommande.AnnulerDerniereAction();
Console.WriteLine(lampe.Etat());



// Annulation complexe
Console.WriteLine("\n");
Console.WriteLine("Annulation conplexe");
Console.WriteLine("\n");

Ventilateur ventilateur = new Ventilateur();
CommandeVentilateurRapide ventilateurRapideCmd = new CommandeVentilateurRapide(ventilateur);
CommandeEteindreVentilateur eteindreVentilateurCmd = new CommandeEteindreVentilateur(ventilateur);

telecommande.SetCommande(3, ventilateurRapideCmd, eteindreVentilateurCmd);

Console.WriteLine(ventilateur.GetVitesse());
telecommande.ActionnerBoutonMarche(3);
Console.WriteLine(ventilateur.GetVitesse());
telecommande.AnnulerDerniereAction();
Console.WriteLine(ventilateur.GetVitesse());

ventilateur.VitesseMoyen();

Console.WriteLine(ventilateur.GetVitesse());
telecommande.ActionnerBoutonMarche(3);
Console.WriteLine(ventilateur.GetVitesse());
telecommande.AnnulerDerniereAction();
Console.WriteLine(ventilateur.GetVitesse());



// Commandes groupées
Console.WriteLine("\n");
Console.WriteLine("Commandes groupées");
Console.WriteLine("\n");

ICommande[] allumageGroupe = new ICommande[]
{
    allumerLampeCmd,
    allumerStereoCmd,
    ventilateurRapideCmd
};

ICommande[] extinsionGroupe = new ICommande[]
{
    eteindreLampeCmd,
    eteindreStereoCmd,
    eteindreVentilateurCmd
};

MacroCommandes macroAllumageGroupe = new MacroCommandes(allumageGroupe);
MacroCommandes macroExtinsionGroupe = new MacroCommandes(extinsionGroupe);

telecommande.SetCommande(4, macroAllumageGroupe, macroExtinsionGroupe);

Console.WriteLine("Etat d'origine :");
Console.WriteLine(lampe.Etat());
Console.WriteLine(ventilateur.GetVitesse());
Console.WriteLine("Actionner les commandes :");
telecommande.ActionnerBoutonMarche(4);
Console.WriteLine(lampe.Etat());
Console.WriteLine(ventilateur.GetVitesse());
Console.WriteLine("Annuler les commandes :");
telecommande.AnnulerDerniereAction();
Console.WriteLine(lampe.Etat());
Console.WriteLine(ventilateur.GetVitesse());
Console.WriteLine("Eteindre les commandes :");
telecommande.ActionnerBoutonEteindre(4);
Console.WriteLine(lampe.Etat());
Console.WriteLine(ventilateur.GetVitesse());
