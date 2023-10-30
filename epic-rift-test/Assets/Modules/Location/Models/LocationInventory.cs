namespace EpicRiftTest.Modules.Location.Models
{
    public class LocationInventory
    {
        private string _currentLocation;

        public LocationInventory(string startLocation)
        {
            _currentLocation = startLocation;
        }

        public string GetCurrentLocationName()
        {
            return _currentLocation;
        }

        public void ChangeLocation(string locationName)
        {
            _currentLocation = locationName;
        }
    }
}