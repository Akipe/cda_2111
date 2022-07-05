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
        private Dir Root { get; set; }
        private TreeView Viewer { get; set; }

        public NodeGeneratorUI(TreeView viewer)
        {
            Viewer = viewer;
        }

        public void GenerateRoot(string dir)
        {
            // Clear the TreeView each time the method is called.
            Viewer.Nodes.Clear();

            // Suppress repainting the TreeView until all the objects have been created.
            Viewer.BeginUpdate();

            NodeGenerator.SetRoot(dir);
            Root = NodeGenerator.Root;

            Viewer.Nodes.Add(Root.ToString());

            GenerateTree(Root, Viewer.Nodes[0]);

            Viewer.EndUpdate();
        }

        public void ExpandsAllNodes()
        {
            Viewer.BeginUpdate();
            ExpandNode(Viewer.Nodes[0]);
            Viewer.EndUpdate();
        }

        public void CollapseAllNodes()
        {
            Viewer.BeginUpdate();
            CollapseNode(Viewer.Nodes[0]);
            Viewer.EndUpdate();
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

        private void ExpandNode(TreeNode node)
        {
            node.Expand();

            if (node.Nodes.Count > 0)
            {
                foreach(TreeNode subNode in node.Nodes)
                {
                    ExpandNode(subNode);
                }
            }
        }

        private void CollapseNode(TreeNode node)
        {
            // treeView1.SelectedNode.Collapse();
            node.Collapse();

            if (node.Nodes.Count > 0)
            {
                foreach (TreeNode subNode in node.Nodes)
                {
                    CollapseNode(subNode);
                }
            }
        }
    }
}
