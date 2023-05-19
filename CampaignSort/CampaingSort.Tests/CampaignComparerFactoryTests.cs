namespace CampaignSorter.Tests
{

    [TestFixture]
    public class CampaignComparerFactoryTests
    {

        [Test]
        public void TestInvalidAttribute()
        {
            CampaignComparerFactory factory = new CampaignComparerFactory();
            Assert.Throws<ArgumentException>(() => factory.GetCampaignComparer("invalidAttribute"));
        }

    }
}
