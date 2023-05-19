using CampaignSort.ComparerClasses;

namespace CampaignSort
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize your campaigns
            List<Campaign> campaigns = new List<Campaign>{
            new Campaign
    {
        Name = "Hoosier Holiday Hustle",
        StartDate = new DateTime(2023, 11, 1),
        EndDate = new DateTime(2023, 12, 25),
        TotalBudget = 15000.0,
        NumberOfCustomersReached = 50000,
        EngagementRate = 0.65,
        ConversionRate = 0.15,
        ClickThroughRate = 0.07,
        ReturnOnInvestment = 1.3,
        RevenueGenerated = 19500.0,
        SocialMediaShares = 1200,
        CustomerSatisfaction = 0.85
    },
    new Campaign
    {
        Name = "Indy 500 Special",
        StartDate = new DateTime(2023, 5, 1),
        EndDate = new DateTime(2023, 5, 31),
        TotalBudget = 10000.0,
        NumberOfCustomersReached = 40000,
        EngagementRate = 0.70,
        ConversionRate = 0.10,
        ClickThroughRate = 0.05,
        ReturnOnInvestment = 1.2,
        RevenueGenerated = 12000.0,
        SocialMediaShares = 800,
        CustomerSatisfaction = 0.80
    },
    new Campaign
    {
        Name = "Spring Fever Frenzy",
        StartDate = new DateTime(2023, 4, 1),
        EndDate = new DateTime(2023, 4, 30),
        TotalBudget = 8000.0,
        NumberOfCustomersReached = 30000,
        EngagementRate = 0.75,
        ConversionRate = 0.20,
        ClickThroughRate = 0.10,
        ReturnOnInvestment = 1.5,
        RevenueGenerated = 12000.0,
        SocialMediaShares = 900,
        CustomerSatisfaction = 0.90
    },
    new Campaign
    {
        Name = "Autumn Adventures",
        StartDate = new DateTime(2023, 9, 1),
        EndDate = new DateTime(2023, 11, 30),
        TotalBudget = 12000.0,
        NumberOfCustomersReached = 45000,
        EngagementRate = 0.60,
        ConversionRate = 0.12,
        ClickThroughRate = 0.06,
        ReturnOnInvestment = 1.4,
        RevenueGenerated = 16800.0,
        SocialMediaShares = 1000,
        CustomerSatisfaction = 0.88
    },
    new Campaign
    {
        Name = "Summer Sizzler Sale",
        StartDate = new DateTime(2023, 6, 1),
        EndDate = new DateTime(2023, 8, 31),
        TotalBudget = 20000.0,
        NumberOfCustomersReached = 60000,
        EngagementRate = 0.68,
        ConversionRate = 0.18,
        ClickThroughRate = 0.08,
        ReturnOnInvestment = 1.6,
        RevenueGenerated = 32000.0,
        SocialMediaShares = 1500,
        CustomerSatisfaction = 0.92
    },
                new Campaign
                {
                    Name = "Emarsys Valentines Special",
                    // ... other attributes here
                }
            };

            CampaignComparerFactory factory = new CampaignComparerFactory();

            // Change the string parameter to the attribute you wish to sort by
            ICampaignComparer comparer = factory.GetCampaignComparer("Name");

            var sorter = new CampaignSorter();
            var sortedCampaigns = sorter.Sort(campaigns, comparer);

            // Instead of just printing the first two, loop over and print all campaigns
            foreach (var campaign in sortedCampaigns)
            {
                Console.WriteLine(campaign.Name);
            }
        }
    }
}