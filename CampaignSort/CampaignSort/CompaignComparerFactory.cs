namespace CampaignSort;

public class CampaignComparerFactory
{
    public ICampaignComparer GetCampaignComparer(string attribute)
    {
        switch (attribute.ToLower())
        {
            case "name":
                return new NameComparer();
            // Add cases for the new attributes
            default:
                throw new ArgumentException($"Invalid attribute: {attribute}");
        }
    }
}
