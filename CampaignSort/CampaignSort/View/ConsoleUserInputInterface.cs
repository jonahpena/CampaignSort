public class ConsoleUserInputInterface : IUserInputInterface
{

    public List<int> GetCampaignSelection(int numberOfCampaigns)
    {
        while (true)
        {
            
            Console.WriteLine(
                "\nEnter the number(s) of the campaigns you're interested in, separated by commas, or 'all' for all campaigns:");

            var input = Console.ReadLine() ?? string.Empty;

            try
            {
                if (input.ToLower() == "all")
                {
                    return Enumerable.Range(0, numberOfCampaigns).ToList(); // assume there are 6 campaigns
                }
                else
                {
                    List<int> selection = input.Split(',')
                        .Select(s => int.Parse(s.Trim()) - 1)
                        .Distinct() // <--- remove duplicates
                        .ToList();

                    if (selection.All(i => i >= 0 && i < numberOfCampaigns))
                        return selection;
                    else
                        throw new IndexOutOfRangeException();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter integers separated by commas.");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine($"Invalid campaign number. Please enter numbers between 1 and {numberOfCampaigns}.");
            }
        }
    }

    public int GetSortingAttribute(int numberOfAttributes)
    {
        while (true)
        {
            Console.WriteLine("\nSelect an attribute to sort by:");

            var input = Console.ReadLine() ?? string.Empty;
            
            try
            {
                int index = int.Parse(input) - 1; // Subtract 1 to get zero-based index

                if (index >= 0 && index < numberOfAttributes)
                    return index;
                else
                    throw new IndexOutOfRangeException();
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine($"Invalid attribute number. Please enter a number between 1 and {numberOfAttributes}.");
            }
        }
    }

    public List<int> GetAttributeSelection(int numberOfAttributes)
    {
        while (true)
        {
            Console.WriteLine("\nSelect additional attributes to display (separate by comma, or 'all'):");

            var input = Console.ReadLine() ?? string.Empty;
            
            try
            {
                if (input.ToLower() == "all")
                {
                    return Enumerable.Range(0, numberOfAttributes).ToList();
                }
                else
                {
                    List<int> selection = input.Split(',')
                        .Select(x => int.Parse(x.Trim()) - 1)
                        .Distinct() // This line removes duplicates
                        .ToList();

                    if (selection.All(i => i >= 0 && i < numberOfAttributes))
                        return selection;
                    else
                        throw new IndexOutOfRangeException();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter integers separated by commas.");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine($"Invalid attribute number. Please enter numbers between 1 and {numberOfAttributes}.");
            }
        }
    }

}
