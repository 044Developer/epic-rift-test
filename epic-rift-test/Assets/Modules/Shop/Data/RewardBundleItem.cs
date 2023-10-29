using System;
using EpicRiftTest.Modules.Core.Infrastructure.Data;
using UnityEngine;

namespace EpicRiftTest.Modules.Shop.Data
{
    [Serializable]
    public class RewardBundleItem
    {
        [SerializeReference, SelectImplementation(typeof(IReward))] public IReward _reward;
        [SerializeField] private int _value;
    }
}