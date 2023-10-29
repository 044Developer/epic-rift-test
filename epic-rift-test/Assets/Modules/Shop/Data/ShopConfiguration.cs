using System.Collections.Generic;
using UnityEngine;

namespace EpicRiftTest.Modules.Shop.Data
{
    [CreateAssetMenu(fileName = "Shop_Configuration", menuName = "Configuration/Shop/ShopBundles")]
    public class ShopConfiguration : ScriptableObject
    {
        [SerializeField] private List<ShopBundle> _shopBundles = new();

        public List<ShopBundle> ShopBundles => _shopBundles;
    }
}