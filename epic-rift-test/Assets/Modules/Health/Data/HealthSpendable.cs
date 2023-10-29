using System;
using EpicRiftTest.Modules.Core.Infrastructure.Data;

namespace EpicRiftTest.Modules.Health.Data
{
    [Serializable]
    public class HealthSpendable : ISpendable
    {
        public void IsTransactionValid(int value)
        {
        }

        public void ApplyTransaction(int value)
        {
        }
    }
}