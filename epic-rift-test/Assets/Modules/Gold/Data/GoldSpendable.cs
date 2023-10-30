using System;
using EpicRiftTest.Modules.Core.Infrastructure.Data;

namespace EpicRiftTest.Modules.Gold.Data
{
    [Serializable]
    public class GoldSpendable : ISpendable
    {
        public bool IsTransactionValid(int value)
        {
            return GoldManager.Instance.HasEnoughGold(value);
        }

        public void ApplyTransaction(int value)
        {
            GoldManager.Instance.TryPurchase(value);
        }
    }
}