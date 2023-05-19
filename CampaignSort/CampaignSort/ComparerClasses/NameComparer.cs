namespace CampaignSort;

public class NameComparer : ICampaignComparer
{
    public int Compare(Campaign c1, Campaign c2)
    {
        return string.Compare(c1.Name, c2.Name);
    }
}

// Implement similar classes for the other attributes
