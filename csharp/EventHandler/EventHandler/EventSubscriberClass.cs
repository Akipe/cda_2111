using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandler
{
    // Classe qui va abonner une de ces méthodes
    // à l'événement de la classe Person
    internal class EventSubscriberClass
    {
        public EventSubscriberClass(Person _person)
        {
            // On s'abonner à l'événement "EventStoreOnNameChanged"
            // de la classe Person
            _person.EventStoreOnNameChanged += ListenPersonEvent;
            _person.EventStoreOnNameChanged += SayToto;
        }

        // Méthode qui va s'abonner à l'événement
        public void ListenPersonEvent(object sender, PropertyChangedEventArgs e)
        {
            if (sender is Person person)
            {
                Console.WriteLine("Mon nom a changé : je m'appelle à présent " + person.Name);
            }
        }

        public void SayToto(object sender, PropertyChangedEventArgs e)
        {
            Console.WriteLine("toto");
        }
    }
}
