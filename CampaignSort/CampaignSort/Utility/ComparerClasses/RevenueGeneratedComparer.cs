namespace CampaignSort.ComparerClasses
{
    public class RevenueGeneratedComparer : ICampaignComparer
    {
        public int Compare(Campaign x, Campaign y)
        {
            return x.RevenueGenerated.CompareTo(y.RevenueGenerated);
        }
    }
}