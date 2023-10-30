using EpicRiftTest.Modules.Location.Data;

namespace EpicRiftTest.Modules.Location.Models
{
    public class LocationInventory
    {
        private LocationType _currentLocation;

        public LocationInventory(LocationType startLocation)
        {
            _currentLocation = startLocation;
        }

        public string GetCurrentLocationName()
        {
            return $"{_currentLocation.ToString()}";
        }

        public void ChangeLocation(int locationIndex)
        {
            _currentLocation = (LocationType)locationIndex;
        }

        public void ChangeLocation(LocationType locationType)
        {
            _currentLocation = locationType;
        }
    }
}