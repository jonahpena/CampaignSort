namespace CampaignSort.ComparerClasses
{
    public class SocialMediaSharesComparer : ICampaignComparer
    {
        public int Compare(Campaign x, Campaign y)
        {
            return x.SocialMediaShares.CompareTo(y.SocialMediaShares);
        }
    }
}