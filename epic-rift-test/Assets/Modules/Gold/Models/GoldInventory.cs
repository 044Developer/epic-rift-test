namespace EpicRiftTest.Modules.Gold.Models
{
    public class GoldInventory
    {
        public int CurrentValue { get; private set; }

        public GoldInventory(int startValue)
        {
            CurrentValue = startValue;
        }

        public void AddGold(int value)
        {
            CurrentValue += value;
        }

        public void SpendGold(int value)
        {
            CurrentValue -= value;
        }
    }
}