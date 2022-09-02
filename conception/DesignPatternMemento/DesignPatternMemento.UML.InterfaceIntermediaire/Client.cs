namespace DesignPatternMemento.UML.InterfaceIntermediaire
{
    public class Client
    {
        internal Originator Originator
        {
            get => default;
            set
            {
            }
        }

        public DesignPatternMemento.UML.InterfaceIntermediaire.IMemento[] history
        {
            get => default;
            set
            {
            }
        }

        public void undo()
        {
            throw new System.NotImplementedException();
        }
    }
}