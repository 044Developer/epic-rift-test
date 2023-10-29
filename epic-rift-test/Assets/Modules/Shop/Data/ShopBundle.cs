using System;
using UnityEngine;

namespace EpicRiftTest.Modules.Shop.Data
{
    [Serializable]
    public class ShopBundle
    {
        [SerializeField] private SpendableBundleItem _price = new();
        [SerializeField] private RewardBundleItem _reward = new();

        public SpendableBundleItem Price => _price;
        public RewardBundleItem Reward => _reward;
    }
}