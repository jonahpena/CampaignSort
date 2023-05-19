using System;

namespace CampaignSort
{
    public class EndDateComparer : ICampaignComparer
    {
        public int Compare(Campaign x, Campaign y)
        {
            return DateTime.Compare(x.EndDate, y.EndDate);
        }
    }
}
