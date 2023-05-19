using NUnit.Framework;
using System;

namespace CampaignSorter.Tests
{
    [TestFixture]
    public class CampaignTests
    {
        // You can add tests here for the Campaign class functionality
        // such as creating a campaign and accessing its properties.
    }

    [TestFixture]
    public class CampaignComparerTests
    {
        [Test]
        public void TestCompareByName()
        {
            var campaign1 = new Campaign { Name = "Campaign A" };
            var campaign2 = new Campaign { Name = "Campaign B" };

            var comparer = CampaignComparer.GetCampaignComparer("name");
            Assert.That(comparer(campaign1, campaign2), Is.LessThan(0));
            Assert.That(comparer(campaign2, campaign1), Is.GreaterThan(0));
        }

        // Add similar tests for the other attributes.
    }
}
