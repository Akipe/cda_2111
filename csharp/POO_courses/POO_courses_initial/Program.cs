// See https://aka.ms/new-console-template for more information

using Vehicules;

// Instancier un objet de tpe voiture 
Voiture maVoiture = new Voiture("Toto");

Console.WriteLine(maVoiture);
maVoiture.Couleurv2 = "jaune";
maVoiture.Poids = 250;
maVoiture.Puissance = 100;
Console.WriteLine(maVoiture);
maVoiture.MoteurAllume = true;
maVoiture.Deplacer(50);
Console.WriteLine(maVoiture);
