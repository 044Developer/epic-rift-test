using System;
using EpicRiftTest.Modules.Core.Infrastructure.Data;

namespace EpicRiftTest.Modules.Gold.Data
{
    [Serializable]
    public class GoldReward : IReward
    {
        public void ApplyReward(string value)
        {
            if (Int32.TryParse(value, out var correctValue))
            {
                GoldManager.Instance.TopUpGold(correctValue);
            }
        }
    }
}