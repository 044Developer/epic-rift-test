using System;
using EpicRiftTest.Modules.Core.Infrastructure.Patterns;
using EpicRiftTest.Modules.Health.Models;
using UnityEngine;

namespace EpicRiftTest.Modules.Health
{
    public class HealthManager : Singleton<HealthManager>
    {
        private const int DEBUG_HEALTH_VALUE = 500;
        private const int MIN_PERCENT_VALUE = 0;
        private const int MAX_PERCENT_VALUE = 100;
        
        public event Action OnChanged;
        
        private HealthInventory _inventory;
        
        public void Initialize()
        {
            _inventory = new HealthInventory(DEBUG_HEALTH_VALUE);
        }

        public string DisplayCurrentValue()
        {
            return $"{_inventory.CurrentValue}";
        }

        public bool HasEnoughHealth(int value)
        {
            return _inventory.CurrentValue >= value && _inventory.CurrentValue > 0;    
        }

        public void TryPurchase(int value)
        {
            if (!HasEnoughHealth(value))
            {
                return;
            }
            
            _inventory.SpendHealth(value);
            OnChanged?.Invoke();
        }

        public void TopUpHealth(int value)
        {
            _inventory.AddHealth(value);
            OnChanged?.Invoke();
        }

        public void RestoreHealth()
        {
            TopUpHealth(DEBUG_HEALTH_VALUE);
            OnChanged?.Invoke();
        }

        public void AddHealthFromPercentage(int percentValue)
        {
            float correctPercentage = Mathf.Clamp(percentValue, MIN_PERCENT_VALUE, MAX_PERCENT_VALUE);
            correctPercentage /= MAX_PERCENT_VALUE;
            
            var rewardValue = Mathf.CeilToInt(_inventory.CurrentValue * correctPercentage);
            
            TopUpHealth(rewardValue);
            OnChanged?.Invoke();
        }
        

        public bool HasEnoughHealthByPercentage(int percentValue)
        {
            float correctPercentage = Mathf.Clamp(percentValue, MIN_PERCENT_VALUE, MAX_PERCENT_VALUE);
            correctPercentage /= MAX_PERCENT_VALUE;
            
            var valueToSpend = Mathf.CeilToInt(_inventory.CurrentValue * correctPercentage);
            
            return _inventory.CurrentValue >= valueToSpend && _inventory.CurrentValue > 0;    
        }

        public void SpendHealthFromPercentage(int percentValue)
        {
            float correctPercentage = Mathf.Clamp(percentValue, MIN_PERCENT_VALUE, MAX_PERCENT_VALUE);
            correctPercentage /= MAX_PERCENT_VALUE;
            
            var valueToSpend = Mathf.CeilToInt(_inventory.CurrentValue * correctPercentage);
            
            TryPurchase(valueToSpend);
            OnChanged?.Invoke();
        }
    }
}