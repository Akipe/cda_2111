namespace DesignPatternMemento.UML.ClasseImbrique
{
    public class TextEditor
    {
        public string Content { get; set; }
        public int CursorPosX { get; set; }
        public int CursorPosY { get; set; }
        public string FontDefined { get; set; }
        public bool BoldActivate { get; set; }

        public TextEditor()
        {
            Content = String.Empty;
            CursorPosX = 0;
            CursorPosY = 0;
            FontDefined = "Serial";
            BoldActivate = false;
        }

        public SnapshotTextEditor MakeSnapshot()
        {
            return new SnapshotTextEditor(
                Content,
                CursorPosX,
                CursorPosY,
                FontDefined,
                BoldActivate
            );
        }

        public void RestoreSnapshot(SnapshotTextEditor snapshot)
        {
            Content = snapshot.Content;
            CursorPosX = snapshot.CursorPosX;
            CursorPosY = snapshot.CursorPosY;
            FontDefined = snapshot.FontDefined;
            BoldActivate = snapshot.BoldActivate;
        }

        public class SnapshotTextEditor
        {
            public string Content { get; set; }
            public int CursorPosX { get; set; }
            public int CursorPosY { get; set; }
            public string FontDefined { get; set; }
            public bool BoldActivate { get; set; }

            public SnapshotTextEditor(
                string content,
                int cursorPosX,
                int cursorPosY,
                string fontDefined,
                bool boldActivate
            )
            {
                Content = content;
                CursorPosX = cursorPosX;
                CursorPosY = cursorPosY;
                FontDefined = fontDefined;
                BoldActivate = boldActivate;
            }
        }
    }
}