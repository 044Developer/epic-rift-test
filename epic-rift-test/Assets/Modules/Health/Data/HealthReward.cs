using System;
using EpicRiftTest.Modules.Core.Infrastructure.Data;

namespace EpicRiftTest.Modules.Health.Data
{
    [Serializable]
    public class HealthReward : IReward
    {
        public void ApplyReward(string value)
        {
            if (Int32.TryParse(value, out var correctValue))
            {
                HealthManager.Instance.TopUpHealth(correctValue);
            }
        }
    }
}