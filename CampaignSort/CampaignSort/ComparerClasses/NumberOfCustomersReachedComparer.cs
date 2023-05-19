namespace CampaignSort
{
    public class NumberOfCustomersReachedComparer : ICampaignComparer
    {
        public int Compare(Campaign x, Campaign y)
        {
            return x.NumberOfCustomersReached.CompareTo(y.NumberOfCustomersReached);
        }
    }
}
