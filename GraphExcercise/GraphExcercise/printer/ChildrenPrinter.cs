using GraphExcercise.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraphExcercise.printer
{
    public class ChildrenPrinter : IPrinter
    {
        public string printTexts(Node root)
        {
            if (root == null)
            {
                return "";
            }
            List<Node> working = new List<Node>();
            List<string> result = new List<string>();
            working.Add(root);

            while (working.Count > 0)
            {
                working.ForEach(node =>
                {
                    result.Add(node.Text);
                });
                working = this.getChildrens(working);
            }

            return this.listToText(result);
        }

        private List<Node> getChildrens(List<Node> parents) {
            List<Node> children = new List<Node>();
            parents.ForEach(parent => {
                if(parent.Left != null)
                {
                    children.Add(parent.Left);
                }
                if (parent.Right != null)
                {
                    children.Add(parent.Right);
                }
            });

            return children;
        }

        private string listToText(List<string> result) {
            // string.Join("_", array);
            return string.Join(",", result);
        }
    }
}
