using System;
using EpicRiftTest.Modules.Core.Infrastructure.Patterns;
using EpicRiftTest.Modules.Gold.Models;

namespace EpicRiftTest.Modules.Gold
{
    public class GoldManager : Singleton<GoldManager>
    {
        private const int DEBUG_GOLD_VALUE = 500;
        
        public event Action OnChanged;
        
        private GoldInventory _inventory;
        
        public void Initialize()
        {
            _inventory = new GoldInventory(DEBUG_GOLD_VALUE);
        }

        public string DisplayCurrentValue()
        {
            return $"{_inventory.CurrentValue}";
        }

        public bool HasEnoughGold(int value)
        {
            return _inventory.CurrentValue >= value && _inventory.CurrentValue > 0;    
        }

        public void TryPurchase(int value)
        {
            if (!HasEnoughGold(value))
            {
                return;
            }
            
            _inventory.SpendGold(value);
            OnChanged?.Invoke();
        }

        public void TopUpGold(int value)
        {
            _inventory.AddGold(value);
            OnChanged?.Invoke();
        }

        public void RestoreGold()
        {
            TopUpGold(DEBUG_GOLD_VALUE);
            OnChanged?.Invoke();
        }
    }
}