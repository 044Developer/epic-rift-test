using System;
using EpicRiftTest.Modules.Core.Infrastructure.Patterns;
using EpicRiftTest.Modules.Location.Models;

namespace EpicRiftTest.Modules.Location
{
    public class LocationManager : Singleton<LocationManager>
    {
        private const string DEFAULT_LOCATION_NAME = "Default";
        
        public event Action OnChanged;
        
        private LocationInventory _inventory;
        
        public void Initialize()
        {
            _inventory = new LocationInventory(DEFAULT_LOCATION_NAME);
        }

        public void PurchaseLocation(string value)
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
            _inventory.ChangeLocation(DEFAULT_LOCATION_NAME);
            OnChanged?.Invoke();
        }
    }
}