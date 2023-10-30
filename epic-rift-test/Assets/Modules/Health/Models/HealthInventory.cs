namespace EpicRiftTest.Modules.Health.Models
{
    public class HealthInventory
    {
        public int CurrentValue { get; private set; }

        public HealthInventory(int startValue)
        {
            CurrentValue = startValue;
        }

        public void AddHealth(int value)
        {
            CurrentValue += value;
        }

        public void SpendHealth(int value)
        {
            CurrentValue -= value;
        }
    }
}