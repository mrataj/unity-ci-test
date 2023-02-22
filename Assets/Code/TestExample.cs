using NUnit.Framework;

namespace Code
{
    public class TestExample
    {
        [Test]
        public void TestSuccess()
        {
            Assert.IsTrue(true, "Something is wrong");
        }

        [Test]
        public void TestFail()
        {
            Assert.IsTrue(false, "Something is wrong");
        }
    }
}