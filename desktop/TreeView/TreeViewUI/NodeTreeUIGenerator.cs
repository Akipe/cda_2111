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
        public static int NbSubNodes
        {
            get;
            private set;
        }

        public static List<TreeNode> Generate(Dir dir)
        {
            return Generate(dir, new CancellationToken());
        }

        public static List<TreeNode> Generate(Dir dir, CancellationToken cancelToken)
        {
            NbSubNodes = 0;
            List<TreeNode> rootNodes = new List<TreeNode>();
            rootNodes.Add(new TreeNode(dir.ToString()));

            GenerateTree(dir, rootNodes[0], cancelToken);

            return rootNodes;
        }

        private static void GenerateTree(
            Dir dir,
            TreeNode collection,
            CancellationToken cancelToken
        )
        {
            cancelToken.ThrowIfCancellationRequested();

            for (int indexNode = 0; indexNode < dir.Children.Count; indexNode++)
            {
                cancelToken.ThrowIfCancellationRequested();

                collection.Nodes.Add(dir.Children[indexNode].ToString());
                NbSubNodes++;

                if (dir.Children[indexNode] is Dir subDir)
                {
                    if (subDir.Children.Count == 0)
                    {
                        collection.Nodes[indexNode].Nodes.Add(String.Empty);
                    }
                    else
                    {
                        GenerateTree(
                            subDir,
                            collection.Nodes[indexNode],
                            cancelToken
                        );
                    }
                }
            }
        }
    }
}
