using System;
using System.Collections.Generic;
using System.ComponentModel; // pour PropertyChangedEventHandler
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandler
{
    internal class Person
    {
        // Attribut stockant une collection d'événements
        public event PropertyChangedEventHandler EventStoreOnNameChanged;
        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                // On execute toutes les methodes abonnées
                // à l'événement "EventStoreOnNameChanged"
                OnNameChangedEvent();
            }
        }

        public Person(string name)
        {
            Name = name;
        }

        // La methode qui va executer tous les événements abonnées
        public void OnNameChangedEvent()
        {
            if (EventStoreOnNameChanged != null)
            {
                // L'execution des événements
                EventStoreOnNameChanged(this, new PropertyChangedEventArgs(nameof(Name)));
            }
        }
    }
}
