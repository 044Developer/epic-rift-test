using System;
using EpicRiftTest.Modules.Core.Infrastructure.Data;

namespace EpicRiftTest.Modules.Gold.Data
{
    [Serializable]
    public class GoldSpendable : ISpendable
    {
        public void IsTransactionValid(int value)
        {
        }

        public void ApplyTransaction(int value)
        {
        }
    }
}