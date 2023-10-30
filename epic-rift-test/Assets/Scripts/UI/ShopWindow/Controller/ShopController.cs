using EpicRiftTest.Modules.Gold;
using EpicRiftTest.Modules.Health;
using EpicRiftTest.Modules.Location;

namespace EpicRiftTest.UI.ShopWindow.Controller
{
    public class ShopController
    {
        public void OnAddGoldButtonClicked()
        {
            GoldManager.Instance.RestoreGold();
        }

        public void OnAddHealthButtonClicked()
        {
            HealthManager.Instance.RestoreHealth();
        }

        public void OnResetLocationButtonClicked()
        {
            LocationManager.Instance.ResetLocation();
        }
    }
}