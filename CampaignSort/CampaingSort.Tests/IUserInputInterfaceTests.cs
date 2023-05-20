namespace CampaignSort.Tests;

public class IUserInputInterfaceTests
{
    [Test]
    public void TestGetCampaignSelectionAll()
    {
        var inputInterface = new MockUserInputInterface(new List<int> { 0, 1, 2, 3, 4, 5 }, new List<int>());
        var selectedCampaigns = inputInterface.GetCampaignSelection();

        Assert.AreEqual(6, selectedCampaigns.Count);
    }


    [Test]
    public void TestGetCampaignSelectionSpecific()
    {
        var inputInterface = new MockUserInputInterface(new List<int> { 0, 2, 4 }, new List<int> { 1, 3, 5 });
        var selection = inputInterface.GetCampaignSelection();
        Assert.AreEqual(3, selection.Count);
        Assert.Contains(0, selection);
        Assert.Contains(2, selection);
        Assert.Contains(4, selection);
    }

    
}