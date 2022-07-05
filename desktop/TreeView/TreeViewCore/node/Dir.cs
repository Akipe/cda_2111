using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace TreeViewCore.node
{
    public class Dir : Node
    {
        public Dir(string path) : base(path)
        {
            Children = new List<Node>();
        }

        public Dir(string name, Dir parent) : base(name, parent)
        {
            Children = new List<Node>();
        }

        public List<Node> Children
        {
            get; private set;
        }
    }
}