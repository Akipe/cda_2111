using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeViewCore;
using TreeViewCore.node;

namespace TreeViewUI
{
    public static class NodeTreeUIGenerator
    {
        public static List<TreeNode> Generate(Dir dir)
        {
            List<TreeNode> rootNodes = new List<TreeNode>();
            rootNodes.Add(new TreeNode(dir.ToString()));

            GenerateTree(dir, rootNodes[0]);

            return rootNodes;
        }

        private static void GenerateTree(
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
