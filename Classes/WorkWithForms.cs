using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EngProject.Forms;

namespace EngProject.Classes
{
    public class WorkWithForms
    {
        public Form1 Form1;
        public FormПеревод FormПеревод;
        public TextClass TextClass;
        public TreeView TreeView;
        public Label Label;

        public static void Init(
            out WorkWithForms workWithForms,
            Form1 form1,
            TextClass textClass,
            TreeView treeView,
            Label label)
        {
            workWithForms = new WorkWithForms()
            {
                Form1 = form1,
                TextClass = textClass,
                TreeView = treeView,
                Label = label
            };
            var c = treeView as Control;
            treeView.MouseDoubleClick += workWithForms.TreeViewOnDoubleClickEvent;
        }

        public void TreeViewOnDoubleClickEvent(Object sender, MouseEventArgs eventArgs)
        {
            if (sender is TreeView treeView)
            {
                var selectedNode = treeView.SelectedNode;
                if (selectedNode.Parent != null)
                {
                    TextClass.ChangeCurrentTranslation(
                        selectedNode.Parent.Text,
                        selectedNode.Text);
                    foreach (TreeNode node in selectedNode.Parent.Nodes)
                    {
                        DeSelectNode(node);
                    }

                    SelectNode(selectedNode);
                    Label.Text = selectedNode.Text;
                }
            }
        }

        public List<TreeNode> GetTreeNodes()
        {
            var result = new List<TreeNode>();
            foreach (var word in TextClass.WordsList)
            {
                var node = new TreeNode(word.Meaning);
                foreach (var translation in word.Translations)
                {
                    var subNode = new TreeNode(translation);
                    if (translation == word.CurrentTranslation)
                    {
                        SelectNode(subNode);
                    }
                    node.Nodes.Add(subNode);
                }
                result.Add(node);
            }

            return result;
        }

        private void SelectNode(TreeNode treeNode)
        {
            treeNode.ForeColor = Color.Red;
        }

        private void DeSelectNode(TreeNode treeNode)
        {
            treeNode.ForeColor = Control.DefaultForeColor;
        }
    }
}
