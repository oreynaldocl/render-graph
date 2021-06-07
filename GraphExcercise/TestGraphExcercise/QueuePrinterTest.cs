using Microsoft.VisualStudio.TestTools.UnitTesting;

using GraphExcercise.printer;
using GraphExcercise.models;

namespace TestGraphExcercise
{
    [TestClass]
    public class QueuePrinterTest
    {
        IPrinter queue;
        [TestInitialize]
        public void AssemblyInit()
        {
            this.queue = new QueuePrinter();
        }

        [TestMethod]
        public void RenderEmptyIfNodeIsEmpty()
        {
            string result = queue.printTexts(null);

            Assert.AreEqual(result, "", "is not empty if user sends empty root");
        }

        [TestMethod]
        public void RenderOnlyRootLevel()
        {
            string result = queue.printTexts(new Node("A"));

            Assert.AreEqual(result, "A", "doesn't render root level");
        }

        [TestMethod]
        public void RenderOnlyRootAndFirstLevel()
        {
            //   A
            //  B  C
            Node left = new Node("B");
            Node right = new Node("C");
            string result = queue.printTexts(new Node("A", left, right));

            Assert.AreEqual(result, "A,B,C", "doesn't render root and first level");
        }

        [TestMethod]
        public void RenderExcerciseInterview()
        {
            //     A
            //  B     C
            // D     E F
            Node left = new Node("B", new Node("D"), null);
            Node right = new Node("C", new Node("E"), new Node("F"));
            string result = queue.printTexts(new Node("A", left, right));

            Assert.AreEqual(result, "A,B,C,D,E,F", "doesn't render root and first level");
        }
    }
}
