using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeViewCore;
using TreeViewCore.node;

namespace TreeViewUI
{
    internal class NodeGeneratorUI
    {
        private TreeView Viewer { get; set; }

        public NodeGeneratorUI(TreeView viewer)
        {
            Viewer = viewer;
        }

        public void GenerateRoot(string dir)
        {
            Viewer.Nodes.Clear();

            NodeGenerator.SetRoot(dir);
            Dir root = NodeGenerator.Root;

            Viewer.Nodes.Add(root.ToString());

            GenerateTree(root, Viewer.Nodes[0]);
        }

        private void GenerateTree(
            Dir dir,
            TreeNode collection
        )
        {
            for (int indexNode = 0; indexNode < dir.Children.Count; indexNode++)
            {
                collection.Nodes.Add(dir.Children[indexNode].ToString());

                if (dir.Children[indexNode] is Dir subDir)
                {
                    GenerateTree(
                        subDir,
                        collection.Nodes[indexNode]
                    );

                    if (collection.Nodes[indexNode].Nodes.Count == 0)
                    {
                        collection.Nodes[indexNode].Nodes.Add(String.Empty);
                    }
                }
            }
        }
    }
}
