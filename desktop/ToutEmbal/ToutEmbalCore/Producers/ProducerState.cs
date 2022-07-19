using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToutEmbalCore.Producers
{
    public class ProducerState : IProducerState
    {
        public static readonly ProducerState CREATED = new ProducerState("Initialisé");
        public static readonly ProducerState STOPPED = new ProducerState("Suspendu");
        public static readonly ProducerState STARTED = new ProducerState("Démarré");
        public static readonly ProducerState SHUTDOWN = new ProducerState("Terminé");

        public string Name { get; init; }

        public ProducerState(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
