namespace CampaignSort.ComparerClasses
{
    public class EngagementRateComparer : ICampaignComparer
    {
        public int Compare(Campaign x, Campaign y)
        {
            return x.EngagementRate.CompareTo(y.EngagementRate);
        }
    }
}