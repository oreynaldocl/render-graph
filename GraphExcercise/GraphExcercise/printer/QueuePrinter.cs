using GraphExcercise.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraphExcercise.printer
{
    public class QueuePrinter : IPrinter
    {
        public string printTexts(Node root)
        {
            if (root == null)
            {
                return "";
            }
            Queue<Node> working = new Queue<Node>();
            Queue<string> result = new Queue<string>();
            working.Enqueue(root);

            while (working.Count > 0) {
                Node node = working.Dequeue();
                result.Enqueue(node.Text);
                if (node.Left != null)
                {
                    working.Enqueue(node.Left);
                }
                if (node.Right != null)
                {
                    working.Enqueue(node.Right);
                }
            }

            return this.queueToText(result);
        }

        private string queueToText(Queue<string> texts)
        {
            string result = "";
            while (texts.Count > 0) {
                result += texts.Dequeue();
                if (texts.Count > 0) {
                    result += ",";
                }
            }
            return result;
        }
    }
}
