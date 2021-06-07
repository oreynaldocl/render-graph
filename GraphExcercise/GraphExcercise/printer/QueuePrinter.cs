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
            return root.Text;
        }
    }
}
