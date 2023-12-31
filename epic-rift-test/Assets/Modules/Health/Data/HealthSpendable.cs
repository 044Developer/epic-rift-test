using System;
using EpicRiftTest.Modules.Core.Infrastructure.Data;

namespace EpicRiftTest.Modules.Health.Data
{
    [Serializable]
    public class HealthSpendable : ISpendable
    {
        public bool IsTransactionValid(int value)
        {
            return HealthManager.Instance.HasEnoughHealth(value);
        }

        public void ApplyTransaction(int value)
        {
            HealthManager.Instance.TryPurchase(value);
        }
    }
}