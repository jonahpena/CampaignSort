using CampaignSort.ComparerClasses;

namespace CampaignSort;

public class CampaignComparerFactory
{
    public ICampaignComparer GetCampaignComparer(string attribute)
    {
        switch (attribute.ToLower())
        {
            case "name":
                return new NameComparer();
            default:
                throw new ArgumentException($"Invalid attribute: {attribute}");
        }
    }
}
