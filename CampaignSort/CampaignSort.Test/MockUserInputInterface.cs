public class MockUserInputInterface : IUserInputInterface
{
    private List<int> mockCampaignSelection;
    private List<int> mockAttributeSelection;

    public MockUserInputInterface(List<int> campaignSelection, List<int> attributeSelection)
    {
        mockCampaignSelection = campaignSelection;
        mockAttributeSelection = attributeSelection;
    }

    public List<int> GetCampaignSelection(int numberOfCampaigns)
    {
        return mockCampaignSelection;
    }

    public List<int> GetAttributeSelection(int numberOfAttributes)
    {
        return mockAttributeSelection;
    }

    public int GetSortingAttribute(int numberOfAttributes)
    {
        return 0;
    }
}