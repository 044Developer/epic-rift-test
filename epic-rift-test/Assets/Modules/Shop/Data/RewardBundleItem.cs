using System;
using System.Linq;
using EpicRiftTest.Modules.Core.Infrastructure.Data;
using UnityEngine;

namespace EpicRiftTest.Modules.Shop.Data
{
    [Serializable]
    public class RewardBundleItem
    {
        [SerializeReference, SelectImplementation(typeof(IReward))] private IReward _reward;
        [SerializeField] private int _value;

        public IReward Reward => _reward;
        public int Value => _value;
    }
}