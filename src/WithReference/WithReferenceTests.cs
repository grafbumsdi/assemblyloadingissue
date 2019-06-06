using NUnit.Framework;

namespace WithReference
{
    [TestFixture]
    public class WithReferenceTests
    {
        [Test]
        public void Fails()
        {
            Assert.That(() => new NLog.Extensions.Logging.NLogLoggerFactory(), Throws.Nothing);
        }
    }
}