namespace Varelager
{
    public interface IStorage
    {
        Item[] ListAllItems();
        Item[] Search(string keyword);
        void AddItem(Item item);
    }
}