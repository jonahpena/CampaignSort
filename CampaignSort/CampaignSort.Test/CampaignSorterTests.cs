using CampaignSort.ComparerClasses;

namespace CampaignSort.Tests
{
    [TestFixture]
    public class CampaignSorterTests
    {
        [Test]
        public void TestSortByName()
        {
            var campaign1 = new Campaign { Name = "Campaign B" };
            var campaign2 = new Campaign { Name = "Campaign A" };

            var campaigns = new List<Campaign> { campaign1, campaign2 };
            var comparer = new NameComparer();


            var sorter = new CampaignSorter();
            var sortedCampaigns = sorter.Sort(campaigns, comparer);

            Assert.That(sortedCampaigns[0], Is.EqualTo(campaign2));
            Assert.That(sortedCampaigns[1], Is.EqualTo(campaign1));
            
        }

        [Test]
        public void TestSortByStartDate()
        {
            var campaign1 = new Campaign { StartDate = new DateTime(2023, 2, 1) };
            var campaign2 = new Campaign { StartDate = new DateTime(2023, 1, 1) };

            var campaigns = new List<Campaign> { campaign1, campaign2 };
            var comparer = new StartDateComparer();

            var sorter = new CampaignSorter();
            var sortedCampaigns = sorter.Sort(campaigns, comparer);

            Assert.That(sortedCampaigns[0], Is.EqualTo(campaign2));
            Assert.That(sortedCampaigns[1], Is.EqualTo(campaign1));
        }

        [Test]
public void TestSortByEndDate()
{
    var campaign1 = new Campaign { EndDate = new DateTime(2023, 2, 1) };
    var campaign2 = new Campaign { EndDate = new DateTime(2023, 1, 1) };

    var campaigns = new List<Campaign> { campaign1, campaign2 };
    var comparer = new EndDateComparer();

    var sorter = new CampaignSorter();
    var sortedCampaigns = sorter.Sort(campaigns, comparer);

    Assert.That(sortedCampaigns[0], Is.EqualTo(campaign2));
    Assert.That(sortedCampaigns[1], Is.EqualTo(campaign1));
}


        [Test]
        public void TestSortByTotalBudget()
        {
            var campaign1 = new Campaign { TotalBudget = 2000.0 };
            var campaign2 = new Campaign { TotalBudget = 1000.0 };
            var campaigns = new List<Campaign> { campaign1, campaign2 };
            var comparer = new TotalBudgetComparer();


            var sorter = new CampaignSorter();
            var sortedCampaigns = sorter.Sort(campaigns, comparer);

            Assert.That(sortedCampaigns[0], Is.EqualTo(campaign2));
            Assert.That(sortedCampaigns[1], Is.EqualTo(campaign1));
        }

        [Test]
        public void TestSortByNumberOfCustomersReached()
        {
            var campaign1 = new Campaign { NumberOfCustomersReached = 200 };
            var campaign2 = new Campaign { NumberOfCustomersReached = 100 };
            var campaigns = new List<Campaign> { campaign1, campaign2 };
            var comparer = new NumberOfCustomersReachedComparer();

            var sorter = new CampaignSorter();
            var sortedCampaigns = sorter.Sort(campaigns, comparer);


            Assert.That(sortedCampaigns[0], Is.EqualTo(campaign2));
            Assert.That(sortedCampaigns[1], Is.EqualTo(campaign1));
        }
    }
}
