using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DesignPatternMemento.UML.ClasseImbrique.TextEditor;

namespace DesignPatternMemento.UML.ClasseImbrique
{
    public class Manager
    {
        private TextEditor _textEditor;
        private List<SnapshotTextEditor> _history;

        public Manager()
        {
            _textEditor = new TextEditor();
            _history = new List<SnapshotTextEditor>();
        }

        public void WriteSomething(string content)
        {
            _history.Add(_textEditor.MakeSnapshot());
            _textEditor.Content += content;
        }

        public void Undo()
        {
            _textEditor.RestoreSnapshot(_history.Last());
        }
    }
}
