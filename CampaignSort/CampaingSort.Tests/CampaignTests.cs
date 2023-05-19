using NUnit.Framework;
using System;
using CampaignSort;

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

        [Test]
        public void TestCompareByStartDate()
        {
            var campaign1 = new Campaign { StartDate = new DateTime(2023, 1, 1) };
            var campaign2 = new Campaign { StartDate = new DateTime(2023, 1, 2) };

            var comparer = CampaignComparer.GetCampaignComparer("startdate");
            Assert.That(comparer(campaign1, campaign2), Is.LessThan(0));
            Assert.That(comparer(campaign2, campaign1), Is.GreaterThan(0));
        }

        [Test]
        public void TestCompareByEndDate()
        {
            var campaign1 = new Campaign { EndDate = new DateTime(2023, 2, 1) };
            var campaign2 = new Campaign { EndDate = new DateTime(2023, 2, 2) };

            var comparer = CampaignComparer.GetCampaignComparer("enddate");
            Assert.That(comparer(campaign1, campaign2), Is.LessThan(0));
            Assert.That(comparer(campaign2, campaign1), Is.GreaterThan(0));
        }

        [Test]
        public void TestCompareByTotalBudget()
        {
            var campaign1 = new Campaign { TotalBudget = 1000.0 };
            var campaign2 = new Campaign { TotalBudget = 2000.0 };

            var comparer = CampaignComparer.GetCampaignComparer("totalbudget");
            Assert.That(comparer(campaign1, campaign2), Is.LessThan(0));
            Assert.That(comparer(campaign2, campaign1), Is.GreaterThan(0));
        }

        [Test]
        public void TestCompareByNumberOfCustomersReached()
        {
            var campaign1 = new Campaign { NumberOfCustomersReached = 100 };
            var campaign2 = new Campaign { NumberOfCustomersReached = 200 };

            var comparer = CampaignComparer.GetCampaignComparer("numberofcustomersreached");
            Assert.That(comparer(campaign1, campaign2), Is.LessThan(0));
            Assert.That(comparer(campaign2, campaign1), Is.GreaterThan(0));
        }

        [Test]
        public void TestInvalidAttribute()
        {
            Assert.Throws<ArgumentException>(() => CampaignComparer.GetCampaignComparer("invalidAttribute"));
        }

    }
}
