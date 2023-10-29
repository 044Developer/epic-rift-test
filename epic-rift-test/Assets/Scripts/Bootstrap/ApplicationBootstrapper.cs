using EpicRiftTest.Modules.Gold;
using EpicRiftTest.Modules.Health;
using EpicRiftTest.Modules.Location;
using EpicRiftTest.Modules.Shop;
using UnityEngine;

namespace EpicRiftTest.Bootstrap
{
    public class ApplicationBootstrapper : MonoBehaviour
    {
        private void Start()
        {
            InitManagers();
        }

        private void OnDestroy()
        {
            DisposeManagers();
        }

        private void InitManagers()
        {
            HealthManager.Instance.Initialize();
            GoldManager.Instance.Initialize();
            LocationManager.Instance.Initialize();
            ShopManager.Instance.Initialize();
        }

        private void DisposeManagers()
        {
            HealthManager.Instance.Dispose();
            GoldManager.Instance.Dispose();
            LocationManager.Instance.Dispose();
            ShopManager.Instance.Dispose();
        }
    }
}
