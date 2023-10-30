using System.Collections.Generic;
using EpicRiftTest.Modules.Shop.Data;
using UnityEngine;

namespace EpicRiftTest.Modules.Shop.Models
{
    [CreateAssetMenu(fileName = "Shop_Configuration", menuName = "Configuration/Shop/ShopBundles")]
    public class ShopConfiguration : ScriptableObject
    {
        [SerializeField] private List<ShopBundle> _shopBundles = new();

        public List<ShopBundle> ShopBundles => _shopBundles;
    }
}