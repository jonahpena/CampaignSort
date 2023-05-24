public interface IUserInputInterface
{
    List<int> GetCampaignSelection(int numberOfCampaigns);
    int GetSortingAttribute(int numberOfAttributes);
    List<int> GetAttributeSelection(int numberOfAttributes);
}