namespace CampaignSort.Tests;

public class IUserInputInterfaceTests
{
    [Test]
    public void TestGetCampaignSelectionAll()
    {
        var inputInterface = new MockUserInputInterface(new List<int> { 0, 1, 2, 3, 4, 5 }, new List<int>());
        var selectedCampaigns = inputInterface.GetCampaignSelection(6); // added argument

        Assert.That(actual: selectedCampaigns.Count,Is.EqualTo(expected: 6));
    }



    [Test]
    public void TestGetCampaignSelectionSpecific()
    {
        var inputInterface = new MockUserInputInterface(new List<int> { 0, 2, 4 }, new List<int> { 1, 3, 5 });
        var selection = inputInterface.GetCampaignSelection(6); // added argument
        
        Assert.That(actual: selection.Count, Is.EqualTo(expected:3));
        Assert.Contains(0, selection);
        Assert.Contains(2, selection);
        Assert.Contains(4, selection);
    }

    [Test]
    public void TestGetCampaignSelectionOutOfOrder()
    {
        var inputInterface = new MockUserInputInterface(new List<int> { 4, 0, 2 }, new List<int>());
        var selection = inputInterface.GetCampaignSelection(6);

        Assert.That(selection.Count, Is.EqualTo(3));
        Assert.Contains(0, selection);
        Assert.Contains(2, selection);
        Assert.Contains(4, selection);
    }

    [Test]
    public void TestGetCampaignSelectionWithDuplicates()
    {
        var inputInterface = new MockUserInputInterface(new List<int> { 0, 0, 2, 2, 4, 4 }, new List<int>());
        var selection = inputInterface.GetCampaignSelection(6);

1,        Assert.That(selection.Count, Is.EqualTo(3)); // Assumes the selection should contain unique numbers
        Assert.Contains(0, selection);
        Assert.Contains(2, selection);
        Assert.Contains(4, selection);
    }

    [Test]
    public void TestGetCampaignSelectionWithInvalidNumber()
    {
        var inputInterface = new MockUserInputInterface(new List<int> { 0, 6 }, new List<int>());
        Assert.Throws<IndexOutOfRangeException>(() => inputInterface.GetCampaignSelection(6));
    }

    [Test]
    public void TestGetCampaignSelectionCheckOrder()
    {
        var inputInterface = new MockUserInputInterface(new List<int> { 4, 0, 2 }, new List<int>());
        var selection = inputInterface.GetCampaignSelection(6);

        Assert.That(selection, Is.EquivalentTo(new List<int> { 0, 2, 4 }));
    }
    
}