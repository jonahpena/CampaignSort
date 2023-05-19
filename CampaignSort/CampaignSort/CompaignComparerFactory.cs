using CampaignSort.ComparerClasses;

namespace CampaignSort;

public class CampaignComparerFactory
{
    public ICampaignComparer GetCampaignComparer(string attribute)
    {
        switch (attribute)
        {
            case "Name":
                return new NameComparer();
            case "StartDate":
                return new StartDateComparer();
            case "EndDate":
                return new EndDateComparer();
            case "TotalBudget":
                return new TotalBudgetComparer();
            case "NumberOfCustomersReached":
                return new NumberOfCustomersReachedComparer();
            case "EngagementRate":
                return new EngagementRateComparer();
            case "ConversionRate":
                return new ConversionRateComparer();
            case "ClickThroughRate":
                return new ClickThroughRateComparer();
            case "ReturnOnInvestment":
                return new ReturnOnInvestmentComparer();
            case "RevenueGenerated":
                return new RevenueGeneratedComparer();
            case "SocialMediaShares":
                return new SocialMediaSharesComparer();
            case "CustomerSatisfaction":
                return new CustomerSatisfactionComparer();
            default:
                throw new ArgumentException($"Invalid attribute: {attribute}");
        }
    }

}
