namespace CampaignSort.ComparerClasses
{
    public class StartDateComparer : ICampaignComparer
    {
        public int Compare(Campaign x, Campaign y)
        {
            return DateTime.Compare(x.StartDate, y.StartDate);
        }
    }
}
