using CampaignSort.ComparerClasses;
using NUnit.Framework;

namespace CampaignSort.Tests
{
    [TestFixture]
    public class ConversionRateComparerTests
    {
        [Test]
        public void TestCompare()
        {
            var campaign1 = new Campaign { ConversionRate = 5.5 };
            var campaign2 = new Campaign { ConversionRate = 6.5 };

            var comparer = new ConversionRateComparer();
            Assert.That(comparer.Compare(campaign1, campaign2), Is.LessThan(0));
            Assert.That(comparer.Compare(campaign2, campaign1), Is.GreaterThan(0));
        }
    }
}