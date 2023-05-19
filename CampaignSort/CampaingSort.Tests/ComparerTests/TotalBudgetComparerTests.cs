namespace CampaignSort.Tests
{
    [TestFixture]
    public class TotalBudgetComparerTests
    {
        [Test]
        public void TestCompare()
        {
            var campaign1 = new Campaign { TotalBudget = 1000 };
            var campaign2 = new Campaign { TotalBudget = 2000 };

            var comparer = new TotalBudgetComparer();
            Assert.That(comparer.Compare(campaign1, campaign2), Is.LessThan(0));
            Assert.That(comparer.Compare(campaign2, campaign1), Is.GreaterThan(0));
        }
    }
}
