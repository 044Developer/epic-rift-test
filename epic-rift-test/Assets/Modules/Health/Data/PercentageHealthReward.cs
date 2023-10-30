using System;
using EpicRiftTest.Modules.Core.Infrastructure.Data;

namespace EpicRiftTest.Modules.Health.Data
{
    [Serializable]
    public class PercentageHealthReward : IReward
    {
        public void ApplyReward(int value)
        {
            HealthManager.Instance.AddHealthFromPercentage(value);
        }
    }
}