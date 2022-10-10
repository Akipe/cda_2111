using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TreeViewCore.node
{
    public class File : Node
    {
        public File(string path) : base(path)
        { }

        public File(string name, Dir parent) : base(name, parent)
        { }
    }
}