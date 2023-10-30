using System;
using EpicRiftTest.Modules.Core.Infrastructure.Data;

namespace EpicRiftTest.Modules.Location.Data
{
    [Serializable]
    public class LocationReward : IReward
    {
        public void ApplyReward(int value)
        {
            LocationManager.Instance.PurchaseLocation(value);
        }
    }
}