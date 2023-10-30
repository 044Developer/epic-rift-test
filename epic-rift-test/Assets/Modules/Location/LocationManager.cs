using System;
using EpicRiftTest.Modules.Core.Infrastructure.Patterns;
using EpicRiftTest.Modules.Location.Data;
using EpicRiftTest.Modules.Location.Models;

namespace EpicRiftTest.Modules.Location
{
    public class LocationManager : Singleton<LocationManager>
    {
        public event Action OnChanged;
        
        private LocationInventory _inventory;
        
        public void Initialize()
        {
            _inventory = new LocationInventory(LocationType.Default);
        }

        public void PurchaseLocation(int value)
        {
            _inventory.ChangeLocation(value);
            OnChanged?.Invoke();
        }

        public string DisplayCurrentValue()
        {
            return _inventory.GetCurrentLocationName();
        }

        public void ResetLocation()
        {
            _inventory.ChangeLocation(LocationType.Default);
            OnChanged?.Invoke();
        }
    }
}