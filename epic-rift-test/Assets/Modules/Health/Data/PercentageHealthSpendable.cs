using System;
using EpicRiftTest.Modules.Core.Infrastructure.Data;

namespace EpicRiftTest.Modules.Health.Data
{
    [Serializable]
    public class PercentageHealthSpendable : ISpendable
    {
        public bool IsTransactionValid(int value)
        {
            return HealthManager.Instance.HasEnoughHealthByPercentage(value);
        }

        public void ApplyTransaction(int value)
        {
            HealthManager.Instance.SpendHealthFromPercentage(value);
        }
    }
}