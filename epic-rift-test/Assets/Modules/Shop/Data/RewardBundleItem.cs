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
        [SerializeField] private string _value;

        public IReward Reward => _reward;
        public string Value => _value;
    }
}