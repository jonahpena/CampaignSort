namespace CampaignSort.Tests
{
    [TestFixture]
    public class StartDateComparerTests
    {
        [Test]
        public void TestCompare()
        {
            var campaign1 = new Campaign { StartDate = DateTime.Now };
            var campaign2 = new Campaign { StartDate = DateTime.Now.AddDays(1) };

            var comparer = new StartDateComparer();
            Assert.That(comparer.Compare(campaign1, campaign2), Is.LessThan(0));
            Assert.That(comparer.Compare(campaign2, campaign1), Is.GreaterThan(0));
        }
    }
}
