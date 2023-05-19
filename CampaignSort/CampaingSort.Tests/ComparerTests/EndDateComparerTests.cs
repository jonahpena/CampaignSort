namespace CampaignSort.Tests
{
    [TestFixture]
    public class EndDateComparerTests
    {
        [Test]
        public void TestCompare()
        {
            var campaign1 = new Campaign { EndDate = DateTime.Now };
            var campaign2 = new Campaign { EndDate = DateTime.Now.AddDays(1) };

            var comparer = new EndDateComparer();
            Assert.That(comparer.Compare(campaign1, campaign2), Is.LessThan(0));
            Assert.That(comparer.Compare(campaign2, campaign1), Is.GreaterThan(0));
        }
    }
}
