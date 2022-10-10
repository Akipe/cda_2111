using EventHandler;

Console.WriteLine("Hello, World!");

// On créer notre personne
Person toto = new Person("Toto");

// Methode qui execute toutes les methodes
// abonnés à l'événement :
//      toto.OnNameChangedEvent()

// Attribut pour s'abonner à l'événement :
//      toto.EventStoreOnNameChanged

EventSubscriberClass eventSubscriberClass = new EventSubscriberClass(toto);

// Methode que l'on abonne à l'événement :
//      eventClass.ListenPersonEvent()

// Chaque changement de nom execute
// les événements abonnés à
// toto.EventStoreOnNameChanged
toto.Name = "Charle";
toto.Name = "Xoxo";
toto.Name = "Xoxoxo";

Console.ReadLine();