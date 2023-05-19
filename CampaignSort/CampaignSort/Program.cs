using System;
using System.Collections.Generic;
using CampaignSort.ComparerClasses;

namespace CampaignSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var campaign1 = new Campaign
            {
                Name = "Campaign A",
                StartDate = new DateTime(2023, 1, 1),
                EndDate = new DateTime(2023, 12, 31),
                TotalBudget = 5000.0,
                NumberOfCustomersReached = 1000,
                EngagementRate = 0.75,
                ConversionRate = 0.10,
                ClickThroughRate = 0.20,
                ReturnOnInvestment = 1.5,
                RevenueGenerated = 7500,
                SocialMediaShares = 200,
                CustomerSatisfaction = 0.90
            };

            var campaign2 = new Campaign
            {
                Name = "Campaign B",
                StartDate = new DateTime(2023, 2, 1),
                EndDate = new DateTime(2023, 11, 30),
                TotalBudget = 7000.0,
                NumberOfCustomersReached = 2000,
                EngagementRate = 0.85,
                ConversionRate = 0.15,
                ClickThroughRate = 0.25,
                ReturnOnInvestment = 2.0,
                RevenueGenerated = 14000,
                SocialMediaShares = 300,
                CustomerSatisfaction = 0.95
            };

            // add more campaigns as needed

            var campaigns = new List<Campaign> { campaign1, campaign2 };

            var sorter = new CampaignSorter();

            // Sorting by Name
            Console.WriteLine("Sorting by Name:");
            var sortedByName = sorter.Sort(campaigns, new NameComparer());
            foreach (var campaign in sortedByName)
            {
                Console.WriteLine(campaign.Name);
            }

            // Sorting by StartDate
            Console.WriteLine("\nSorting by StartDate:");
            var sortedByStartDate = sorter.Sort(campaigns, new StartDateComparer());
            foreach (var campaign in sortedByStartDate)
            {
                Console.WriteLine($"{campaign.Name}, Start Date: {campaign.StartDate}");
            }

            // Repeat this for other comparers (EndDate, TotalBudget, NumberOfCustomersReached, etc.)
            
            Console.WriteLine("\nSorting by EndDate:");
            var sortedByEndDate = sorter.Sort(campaigns, new EndDateComparer());
            foreach (var campaign in sortedByEndDate)
            {
                Console.WriteLine($"{campaign.Name}, End Date: {campaign.EndDate}");
            }
            
            Console.WriteLine("\nSorting by TotalBudget:");
            var sortedByTotalBudget = sorter.Sort(campaigns, new TotalBudgetComparer());
            foreach (var campaign in sortedByTotalBudget)
            {
                Console.WriteLine($"{campaign.Name}, Total Budget: {campaign.TotalBudget}");
            }
            
            Console.WriteLine("\nSorting by NumberOfCustomersReached:");
            var sortedByNumberOfCustomersReached = sorter.Sort(campaigns, new NumberOfCustomersReachedComparer());
            foreach (var campaign in sortedByNumberOfCustomersReached)
            {
                Console.WriteLine($"{campaign.Name}, Number Of Customers Reached: {campaign.NumberOfCustomersReached}");
            }
            
            Console.WriteLine("\nSorting by EngagementRate:");
            var sortedByEngagementRate = sorter.Sort(campaigns, new EngagementRateComparer());
            foreach (var campaign in sortedByEngagementRate)
            {
                Console.WriteLine($"{campaign.Name}, Engagement Rate: {campaign.EngagementRate}");
            }
            
            Console.WriteLine("\nSorting by ConversionRate:");
            var sortedByConversionRate = sorter.Sort(campaigns, new ConversionRateComparer());
            foreach (var campaign in sortedByConversionRate)
            {
                Console.WriteLine($"{campaign.Name}, Conversion Rate: {campaign.ConversionRate}");
            }
            
            Console.WriteLine("\nSorting by ClickThroughRate:");
            var sortedByClickThroughRate = sorter.Sort(campaigns, new ClickThroughRateComparer());
            foreach (var campaign in sortedByClickThroughRate)
            {
                Console.WriteLine($"{campaign.Name}, Click Through Rate: {campaign.ClickThroughRate}");
            }
            
            Console.WriteLine("\nSorting by ReturnOnInvestment:");
            var sortedByReturnOnInvestment = sorter.Sort(campaigns, new ReturnOnInvestmentComparer());
            foreach (var campaign in sortedByReturnOnInvestment)
            {
                Console.WriteLine($"{campaign.Name}, Return On Investment: {campaign.ReturnOnInvestment}");
            }
            
            Console.WriteLine("\nSorting by RevenueGenerated:");
            var sortedByRevenueGenerated = sorter.Sort(campaigns, new RevenueGeneratedComparer());
            foreach (var campaign in sortedByRevenueGenerated)
            {
                Console.WriteLine($"{campaign.Name}, Revenue Generated: {campaign.RevenueGenerated}");
            }
            
            Console.WriteLine("\nSorting by SocialMediaShares:");
            var sortedBySocialMediaShares = sorter.Sort(campaigns, new SocialMediaSharesComparer());
            foreach (var campaign in sortedBySocialMediaShares)
            {
                Console.WriteLine($"{campaign.Name}, Social Media Shares: {campaign.SocialMediaShares}");
            }
            
            Console.WriteLine("\nSorting by CustomerSatisfaction:");
            var sortedByCustomerSatisfaction = sorter.Sort(campaigns, new CustomerSatisfactionComparer());
            foreach (var campaign in sortedByCustomerSatisfaction)
            {
                Console.WriteLine($"{campaign.Name}, Customer Satisfaction: {campaign.CustomerSatisfaction}");
            }
            
        }
    }
}
