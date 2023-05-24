namespace CampaignSort.ComparerClasses
{ 
    public class NameComparer : ICampaignComparer
    {
        public int Compare(Campaign c1, Campaign c2)
        {
            return string.Compare(c1.Name, c2.Name);
        }
    }
}