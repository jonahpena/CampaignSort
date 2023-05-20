using CampaignSort.ComparerClasses;
using NUnit.Framework;

namespace CampaignSort.Tests
{
    [TestFixture]
    public class RevenueGeneratedComparerTests
    {
        [Test]
        public void TestCompare()
        {
            var campaign1 = new Campaign { RevenueGenerated = 1000.0 };
            var campaign2 = new Campaign { RevenueGenerated = 2000.0 };

            var comparer = new RevenueGeneratedComparer();
            Assert.That(comparer.Compare(campaign1, campaign2), Is.LessThan(0));
            Assert.That(comparer.Compare(campaign2, campaign1), Is.GreaterThan(0));
        }
    }
}