using System;
using EpicRiftTest.Modules.Core.Infrastructure.Data;
using UnityEngine;

namespace EpicRiftTest.Modules.Shop.Data
{
    [Serializable]
    public class SpendableBundleItem
    {
        [SerializeReference, SelectImplementation(typeof(ISpendable))] private ISpendable _spendable;
        [SerializeField] private int _value;

        public ISpendable Spendable => _spendable;
        public int Value => _value;
    }
}