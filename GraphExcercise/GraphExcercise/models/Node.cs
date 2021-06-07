using System;
using System.Collections.Generic;
using System.Text;

namespace GraphExcercise.models
{

    public class Node {
        private Node left;
        private Node right;
        private string text;

        public Node(string text)
        {
            this.text = text;
            this.left = null;
            this.right = null;
        }

        public Node(string text, Node left, Node right)
        {
            this.text = text;
            this.left = left;
            this.right = right;
        }

        public Node Left { get => left; set => left = value; }
        public Node Right { get => right; set => right = value; }
        public string Text { get => text; set => text = value; }

        public override string ToString()
        {
            return this.text;
        }
    }
}
