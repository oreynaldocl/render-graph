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
    }
}
