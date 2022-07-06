using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TreeViewCore.node;

namespace TreeViewCore
{
    public abstract class Node
    {
        public Node(string path)
        {
            Path = path;
            Parent = null;
            Name = System.IO.Path.GetFileName(path);
        }

        public Node(string name, Dir parent)
        {
            Name = name;
            Parent = parent;
            Path =
                parent.Path
                + System.IO.Path.DirectorySeparatorChar
                + name
            ;
        }

        public string Path
        {
            get;
            private set;
        }

        public string Name
        {
            get;
            set;
        }

        public Dir? Parent
        {
            get;
            private set;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}