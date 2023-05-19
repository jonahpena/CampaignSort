namespace CampaignSort
{
    public class TotalBudgetComparer : ICampaignComparer
    {
        public int Compare(Campaign x, Campaign y)
        {
            return x.TotalBudget.CompareTo(y.TotalBudget);
        }
    }
}
