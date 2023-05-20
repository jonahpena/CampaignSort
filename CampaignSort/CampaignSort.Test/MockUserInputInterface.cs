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
        // Validate inputs and remove duplicates
        var validCampaignSelection = new List<int>();

        foreach (int campaign in mockCampaignSelection)
        {
            if (campaign < 0 || campaign >= numberOfCampaigns)
            {
                throw new IndexOutOfRangeException("Invalid campaign number");
            }

            if (!validCampaignSelection.Contains(campaign))
            {
                validCampaignSelection.Add(campaign);
            }
        }

        return validCampaignSelection;
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