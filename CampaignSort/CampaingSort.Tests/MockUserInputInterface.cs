public class MockUserInputInterface : IUserInputInterface
{
    private List<int> mockCampaignSelection;
    private List<int> mockAttributeSelection;

    public MockUserInputInterface(List<int> campaignSelection, List<int> attributeSelection)
    {
        mockCampaignSelection = campaignSelection;
        mockAttributeSelection = attributeSelection;
    }

    public List<int> GetCampaignSelection()
    {
        return mockCampaignSelection;
    }

    public List<int> GetAttributeSelection()
    {
        return Enumerable.Range(0, 12).ToList(); // This will select all attributes in a test environment
    }

    public int GetSortingAttribute()
    {
        return 0;
    }
}