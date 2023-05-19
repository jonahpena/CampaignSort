﻿using NUnit.Framework;
using CampaignSort;
using System;

namespace CampaignSorter.Tests
{
    [TestFixture]
    public class CampaignSorterTests
    {
        [Test]
        public void TestSortByName()
        {
            var campaign1 = new Campaign { Name = "Campaign B" };
            var campaign2 = new Campaign { Name = "Campaign A" };
            var campaigns = new[] { campaign1, campaign2 };
            var comparer = new NameComparer();

            var sortedCampaigns = CampaignSorter.Sort(campaigns, comparer);

            Assert.AreEqual(campaign2, sortedCampaigns[0]);
            Assert.AreEqual(campaign1, sortedCampaigns[1]);
        }

        [Test]
        public void TestSortByStartDate()
        {
            var campaign1 = new Campaign { StartDate = new DateTime(2023, 2, 1) };
            var campaign2 = new Campaign { StartDate = new DateTime(2023, 1, 1) };
            var campaigns = new[] { campaign1, campaign2 };
            var comparer = new StartDateComparer();

            var sortedCampaigns = CampaignSorter.Sort(campaigns, comparer);

            Assert.AreEqual(campaign2, sortedCampaigns[0]);
            Assert.AreEqual(campaign1, sortedCampaigns[1]);
        }

        [Test]
        public void TestSortByEndDate()
        {
            var campaign1 = new Campaign { EndDate = new DateTime(2023, 2, 1) };
            var campaign2 = new Campaign { EndDate = new DateTime(2023, 1, 1) };
            var campaigns = new[] { campaign1, campaign2 };
            var comparer = new EndDateComparer();

            var sortedCampaigns = CampaignSorter.Sort(campaigns, comparer);

            Assert.AreEqual(campaign2, sortedCampaigns[0]);
            Assert.AreEqual(campaign1, sortedCampaigns[1]);
        }

        [Test]
        public void TestSortByTotalBudget()
        {
            var campaign1 = new Campaign { TotalBudget = 2000.0 };
            var campaign2 = new Campaign { TotalBudget = 1000.0 };
            var campaigns = new[] { campaign1, campaign2 };
            var comparer = new TotalBudgetComparer();

            var sortedCampaigns = CampaignSorter.Sort(campaigns, comparer);

            Assert.AreEqual(campaign2, sortedCampaigns[0]);
            Assert.AreEqual(campaign1, sortedCampaigns[1]);
        }

        [Test]
        public void TestSortByNumberOfCustomersReached()
        {
            var campaign1 = new Campaign { NumberOfCustomersReached = 200 };
            var campaign2 = new Campaign { NumberOfCustomersReached = 100 };
            var campaigns = new[] { campaign1, campaign2 };
            var comparer = new NumberOfCustomersReachedComparer();

            var sortedCampaigns = CampaignSorter.Sort(campaigns, comparer);

            Assert.AreEqual(campaign2, sortedCampaigns[0]);
            Assert.AreEqual(campaign1, sortedCampaigns[1]);
        }
    }
}
