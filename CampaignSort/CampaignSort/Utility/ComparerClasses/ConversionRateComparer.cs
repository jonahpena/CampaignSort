namespace CampaignSort.ComparerClasses
{
    public class ConversionRateComparer : ICampaignComparer
    {
        public int Compare(Campaign x, Campaign y)
        {
            return x.ConversionRate.CompareTo(y.ConversionRate);
        }
    }
}