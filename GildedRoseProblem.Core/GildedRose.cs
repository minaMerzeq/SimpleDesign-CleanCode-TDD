namespace GildedRoseProblem.Core
{
    public class GildedRose
    {
        public GildedRose(Item[] items)
        {
            Items = items;
        }

        public Item[] Items { get; set; }

        public void UpdateQuality()
        {
            throw new NotImplementedException();
        }
    }
}