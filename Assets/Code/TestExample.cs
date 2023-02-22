using NUnit.Framework;

namespace Code
{
    public class TestExample
    {
        [Test]
        public void TestSuccess()
        {
            Assert.IsTrue(true);
        }

        [Test]
        public void TestFail()
        {
            Assert.IsTrue(false);
        }
    }
}