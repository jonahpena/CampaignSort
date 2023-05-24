namespace CampaignSort.ComparerClasses
{
    public class ClickThroughRateComparer : ICampaignComparer
    {
        public int Compare(Campaign x, Campaign y)
        {
            return x.ClickThroughRate.CompareTo(y.ClickThroughRate);
        }
    }
}