namespace CampaignSort.ComparerClasses
{
    public class CustomerSatisfactionComparer : ICampaignComparer
    {
        public int Compare(Campaign x, Campaign y)
        {
            return x.CustomerSatisfaction.CompareTo(y.CustomerSatisfaction);
        }
    }
}