using System;
using EpicRiftTest.Modules.Core.Infrastructure.Data;

namespace EpicRiftTest.Modules.Health.Data
{
    [Serializable]
    public class PercentageHealthReward : IReward
    {
        public void ApplyReward(string value)
        {
            if (Int32.TryParse(value, out int correctValue))
            {
                HealthManager.Instance.AddHealthFromPercentage(correctValue);
            }
        }
    }
}