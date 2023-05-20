using CampaignSort;

public class ConsoleUserInputInterface : IUserInputInterface
{
    public List<int> GetCampaignSelection()
    {
        Console.WriteLine("Enter the number(s) of the campaigns you're interested in, separated by commas, or 'all' for all campaigns:");
        string input = Console.ReadLine();
        
        if (input.ToLower() == "all")
        {
            return Enumerable.Range(0, 6).ToList(); // assume there are 6 campaigns
        }
        else
        {
            return input.Split(',').Select(s => int.Parse(s.Trim()) - 1).ToList();
        }
    }
    
    public int GetSortingAttribute()
    {
        Console.WriteLine("Please select an attribute to sort by:");
        string input = Console.ReadLine();
        return int.Parse(input) - 1; // Subtract 1 to get zero-based index
    }
    
    public List<int> GetAttributeSelection()
    {
        Console.WriteLine("Please select additional attributes to display (separate by comma, or 'all'):");
        string input = Console.ReadLine();

        if (input.ToLower() == "all")
        {
            // Return a list with all indices
            return Enumerable.Range(0, 12).ToList();
        }
        else
        {
            // Convert input into list of integers
            return input.Split(", ").Select(x => int.Parse(x) - 1).ToList(); // Subtract 1 to get zero-based index
        }
    }
    
    
    

}