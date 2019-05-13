namespace Varelager
{
    public struct Item
    {
        public string Name;
        public int Amount;

        public Item(string name, int amount)
        {
            this.Name = name;
            this.Amount = amount;
        }

        public override string ToString() => $"{Amount} of item named '{Name}'";
    }
}