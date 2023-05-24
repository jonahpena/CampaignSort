namespace CampaignSort;

public class Campaign
{
    public string? Name { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public double TotalBudget { get; set; }
    public int NumberOfCustomersReached { get; set; }
    public double EngagementRate { get; set; }
    public double ConversionRate { get; set; }
    public double ClickThroughRate { get; set; }
    public double ReturnOnInvestment { get; set; }
    public double RevenueGenerated { get; set; }
    public int SocialMediaShares { get; set; }
    public double CustomerSatisfaction { get; set; }
}
