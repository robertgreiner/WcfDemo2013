using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WcfInAction.Tests
{
    [TestFixture]
    public class FlipCaseServiceTests
    {
        [Test]
        public void ShouldReverseTheCaseOfAString()
        {
            var service = new FlipCaseService();
            var stringData = new StringData();
            stringData.OriginalString = "Robert";
            var result = service.FlipCase(stringData);
            Assert.AreEqual("rOBERT", result.FlippedCaseString);
        }
    }
}
