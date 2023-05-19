using System;

namespace CampaignSort;

public class CampaignComparer
{
    public static Func<Campaign, Campaign, int> GetCampaignComparer(string attribute)
    {
        switch (attribute.ToLower())
        {
            case "name":
                return (c1, c2) => string.Compare(c1.Name, c2.Name);
            case "startdate":
                return (c1, c2) => DateTime.Compare(c1.StartDate, c2.StartDate);
            case "enddate":
                return (c1, c2) => DateTime.Compare(c1.EndDate, c2.EndDate);
            case "totalbudget":
                return (c1, c2) => c1.TotalBudget.CompareTo(c2.TotalBudget);
            case "numberofcustomersreached":
                return (c1, c2) => c1.NumberOfCustomersReached.CompareTo(c2.NumberOfCustomersReached);
            default:
                throw new ArgumentException($"Invalid attribute: {attribute}");
        }
    }
}
