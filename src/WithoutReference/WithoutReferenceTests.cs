using NUnit.Framework;

namespace WithoutReference
{
    [TestFixture]
    public class WithoutReferenceTests
    {
        [Test]
        public void Succeeds()
        {
            Assert.That(() => new NLog.Extensions.Logging.NLogLoggerFactory(), Throws.Nothing);
        }
    }
}