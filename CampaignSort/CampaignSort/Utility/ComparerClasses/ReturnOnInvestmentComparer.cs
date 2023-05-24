namespace CampaignSort.ComparerClasses
{
    public class ReturnOnInvestmentComparer : ICampaignComparer
    {
        public int Compare(Campaign x, Campaign y)
        {
            return x.ReturnOnInvestment.CompareTo(y.ReturnOnInvestment);
        }
    }

}
