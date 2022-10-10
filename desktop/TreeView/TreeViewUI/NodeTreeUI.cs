using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeViewUI
{
    internal class NodeTreeUI
    {
        public TreeView TreeView { get; private set; }
        public Button ExpandBtn { get; private set; }
        public Button CollapseBtn { get; private set; }
        public TreeNode? Root { get; private set; }

        public NodeTreeUI(
            TreeView treeView,
            Button expandBtn,
            Button collapseBtn
        )
        {
            TreeView = treeView;
            ExpandBtn = expandBtn;
            CollapseBtn = collapseBtn;
            Root = null;

            TriggerCollapseExpandsBtn(false);
        }

        public void SetRootNode(TreeNode node)
        {
            Root = node;

            TreeView.BeginUpdate();
            TreeView.Nodes.Clear();
            TreeView.Nodes.Add(node);
            TreeView.EndUpdate();
            TriggerCollapseExpandsBtn(true);
        }

        public void Clear()
        {
            Root = null;

            TreeView.BeginUpdate();
            TreeView.Nodes.Clear();
            TreeView.EndUpdate();
            TriggerCollapseExpandsBtn(false);
        }

        public void CollapseAllNodes()
        {
            if (Root is not null)
            {
                TreeView.BeginUpdate();
                TreeView.CollapseAll();
                //CollapseNode(TreeView.Nodes[0]);
                TreeView.EndUpdate();
            }
        }

        private void CollapseNode(TreeNode node)
        {
            node.Collapse();

            if (node.Nodes.Count > 0)
            {
                foreach (TreeNode subNode in node.Nodes)
                {
                    CollapseNode(subNode);
                }
            }
        }

        public void ExpandsAllNodes()
        {
            if (Root is not null)
            {
                TreeView.BeginUpdate();
                TreeView.ExpandAll();
                //ExpandNode(TreeView.Nodes[0]);
                TreeView.EndUpdate();
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

        private void TriggerCollapseExpandsBtn(Boolean status)
        {
            ExpandBtn.Enabled = status;
            CollapseBtn.Enabled = status;
        }
    }
}
