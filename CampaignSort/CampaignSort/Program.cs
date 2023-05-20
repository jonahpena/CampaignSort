
using System.Reflection;

namespace CampaignSort
{
    class Program
    
    {
        static void Main(string[] args)
        {
            IUserInputInterface userInput = new ConsoleUserInputInterface();

            // Initialize your campaigns
            List<Campaign> allCampaigns = new List<Campaign>
            {
                new Campaign
                {
                    Name = "Year Start Jumpstart",
                    StartDate = new DateTime(2023, 1, 1),
                    EndDate = new DateTime(2023, 1, 31),
                    TotalBudget = 15000.00,
                    NumberOfCustomersReached = 120000,
                    EngagementRate = 0.68,
                    ConversionRate = 0.21,
                    ClickThroughRate = 0.08,
                    ReturnOnInvestment = 1.6,
                    RevenueGenerated = 24000.00,
                    SocialMediaShares = 1800,
                    CustomerSatisfaction = 0.92
                },
                new Campaign
                {
                    Name = "Spring Savings Spectacle",
                    StartDate = new DateTime(2023, 4, 1),
                    EndDate = new DateTime(2023, 4, 30),
                    TotalBudget = 13000.00,
                    NumberOfCustomersReached = 95000,
                    EngagementRate = 0.75,
                    ConversionRate = 0.19,
                    ClickThroughRate = 0.07,
                    ReturnOnInvestment = 1.4,
                    RevenueGenerated = 18200.00,
                    SocialMediaShares = 1500,
                    CustomerSatisfaction = 0.89
                },

                new Campaign
                {
                    Name = "Summer Sizzle Sale",
                    StartDate = new DateTime(2023, 6, 1),
                    EndDate = new DateTime(2023, 8, 31),
                    TotalBudget = 20000.00,
                    NumberOfCustomersReached = 150000,
                    EngagementRate = 0.72,
                    ConversionRate = 0.23,
                    ClickThroughRate = 0.09,
                    ReturnOnInvestment = 1.75,
                    RevenueGenerated = 35000.00,
                    SocialMediaShares = 2200,
                    CustomerSatisfaction = 0.94
                },
                new Campaign
                {
                    Name = "Autumn Arrival Offers",
                    StartDate = new DateTime(2023, 9, 1),
                    EndDate = new DateTime(2023, 11, 30),
                    TotalBudget = 17000.00,
                    NumberOfCustomersReached = 140000,
                    EngagementRate = 0.70,
                    ConversionRate = 0.22,
                    ClickThroughRate = 0.08,
                    ReturnOnInvestment = 1.5,
                    RevenueGenerated = 25500.00,
                    SocialMediaShares = 2000,
                    CustomerSatisfaction = 0.91
                },
                new Campaign
                {
                    Name = "Winter Wonders",
                    StartDate = new DateTime(2023, 12, 1),
                    EndDate = new DateTime(2024, 2, 28),
                    TotalBudget = 20000.00,
                    NumberOfCustomersReached = 160000,
                    EngagementRate = 0.72,
                    ConversionRate = 0.23,
                    ClickThroughRate = 0.09,
                    ReturnOnInvestment = 1.7,
                    RevenueGenerated = 34000.00,
                    SocialMediaShares = 2300,
                    CustomerSatisfaction = 0.93
                },
                new Campaign
                {
                    Name = "Leap into Spring",
                    StartDate = new DateTime(2024, 3, 1),
                    EndDate = new DateTime(2024, 5, 31),
                    TotalBudget = 18000.00,
                    NumberOfCustomersReached = 150000,
                    EngagementRate = 0.73,
                    ConversionRate = 0.24,
                    ClickThroughRate = 0.09,
                    ReturnOnInvestment = 1.8,
                    RevenueGenerated = 32400.00,
                    SocialMediaShares = 2100,
                    CustomerSatisfaction = 0.92
                }

            };

            // Display the campaigns
            for (int i = 0; i < allCampaigns.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {allCampaigns[i].Name}");
            }

            // Get the selected campaigns
            List<int> campaignSelection = userInput.GetCampaignSelection(allCampaigns.Count);
            List<Campaign> campaigns = campaignSelection.Select(i => allCampaigns[i]).ToList();

            
            
            // Define the attributes
            List<string> attributes = new List<string>
            {
                "Name",
                "StartDate",
                "EndDate",
                "TotalBudget",
                "NumberOfCustomersReached",
                "EngagementRate",
                "ConversionRate",
                "ClickThroughRate",
                "ReturnOnInvestment",
                "RevenueGenerated",
                "SocialMediaShares",
                "CustomerSatisfaction"
            };

            // Display the attributes
            for (int i = 0; i < attributes.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {attributes[i]}");
            }

            CampaignComparerFactory factory = new CampaignComparerFactory();

            // Get the selected attribute for sorting
            int sortingAttributeIndex = userInput.GetSortingAttribute(allCampaigns.Count);
            string sortingAttribute = attributes[sortingAttributeIndex];

            // Get the selected additional attributes for display
            List<int> attributeSelectionIndices = userInput.GetAttributeSelection(allCampaigns.Count);
            List<string> attributeSelection = attributeSelectionIndices.Select(i => attributes[i]).ToList();

            // Add the sorting attribute to the display list if it's not already there
            if (!attributeSelection.Contains(sortingAttribute))
            {
                attributeSelection.Add(sortingAttribute);
            }

            // Get the appropriate comparer for sorting
            ICampaignComparer comparer = factory.GetCampaignComparer(sortingAttribute);

            // Sort and display the campaigns
            SortAndDisplayCampaigns(campaigns, comparer, attributeSelection);
            
            
        }

        private static void SortAndDisplayCampaigns(List<Campaign> campaigns, ICampaignComparer comparer, List<string> attributeSelection)
        {
            campaigns.Sort(comparer.Compare);  // Sort the campaigns using the comparer

            // Use Reflection to display the chosen attributes
            foreach (var campaign in campaigns)
            {
                foreach (var attribute in attributeSelection)
                {
                    PropertyInfo propertyInfo = typeof(Campaign).GetProperty(attribute);
                    Console.WriteLine($"{attribute}: {propertyInfo.GetValue(campaign)}");
                }
                Console.WriteLine("--------------------");  // Separator between campaigns
            }
        }

        }

        
    }


