using CampaignSort;

public class MarketingManager
{
    private List<Campaign> campaigns;
    private CampaignComparerFactory comparerFactory;

    public MarketingManager()
    {
        this.campaigns = new List<Campaign>();
        this.comparerFactory = new CampaignComparerFactory();
    }

    public void AddCampaign(Campaign campaign)
    {
        this.campaigns.Add(campaign);
    }

    public void SortCampaigns(string attribute)
    {
        var comparer = this.comparerFactory.GetCampaignComparer(attribute);

        this.campaigns.Sort((c1, c2) => comparer.Compare(c1, c2));
    }
}
