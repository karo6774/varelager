namespace Varelager
{
    public interface IStorage
    {
        Item[] ListAllItems();
        Item[] Search(string keyword);
        bool AddItem(Item item);
    }
}