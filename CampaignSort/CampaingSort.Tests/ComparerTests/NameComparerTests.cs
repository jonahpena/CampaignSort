namespace CampaignSorter.Tests
{
    [TestFixture]
    public class NameComparerTests
    {
        [Test]
        public void TestCompare()
        {
            var campaign1 = new Campaign { Name = "Campaign A" };
            var campaign2 = new Campaign { Name = "Campaign B" };

            var comparer = new NameComparer();
            Assert.That(comparer.Compare(campaign1, campaign2), Is.LessThan(0));
            Assert.That(comparer.Compare(campaign2, campaign1), Is.GreaterThan(0));
        }
    }
}
