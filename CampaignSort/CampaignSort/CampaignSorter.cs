using System;
using System.Collections.Generic;

namespace CampaignSort
{
    public class CampaignSorter
    {
        public List<Campaign> Sort(List<Campaign> campaigns, ICampaignComparer comparer)
        {
            // Create a new list as a copy of the original
            var copiedCampaigns = new List<Campaign>(campaigns);

            // Sort the copied list
            MergeSort(copiedCampaigns, comparer);

            // Return the sorted list
            return copiedCampaigns;
        }

        public void MergeSort(List<Campaign> campaigns, ICampaignComparer comparer)
        {
            if (campaigns.Count <= 1)
            {
                return;
            }

            var left = new List<Campaign>();
            var right = new List<Campaign>();

            int middle = campaigns.Count / 2;
            for (int i = 0; i < middle; i++)
            {
                left.Add(campaigns[i]);
            }
            for (int i = middle; i < campaigns.Count; i++)
            {
                right.Add(campaigns[i]);
            }

            MergeSort(left, comparer);
            MergeSort(right, comparer);
            Merge(campaigns, left, right, comparer);
        }

        private void Merge(List<Campaign> campaigns, List<Campaign> left, List<Campaign> right, ICampaignComparer comparer)
        {
            campaigns.Clear();

            while (left.Count > 0 && right.Count > 0)
            {
                if (comparer.Compare(left[0], right[0]) <= 0)
                {
                    campaigns.Add(left[0]);
                    left.RemoveAt(0);
                }
                else
                {
                    campaigns.Add(right[0]);
                    right.RemoveAt(0);
                }
            }

            while (left.Count > 0)
            {
                campaigns.Add(left[0]);
                left.RemoveAt(0);
            }

            while (right.Count > 0)
            {
                campaigns.Add(right[0]);
                right.RemoveAt(0);
            }
        }
    }
}
