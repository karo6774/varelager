namespace Varelager
{
    public interface Storage
    {
        Item[] listAllItems();
        Item[] search(string keyword);
        void addItem(Item item);
    }
}