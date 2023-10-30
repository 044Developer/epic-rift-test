using EpicRiftTest.Modules.Gold;
using EpicRiftTest.Modules.Health;
using EpicRiftTest.Modules.Location;
using EpicRiftTest.Modules.Shop;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace EpicRiftTest.Bootstrap
{
    public class ApplicationBootstrapper : MonoBehaviour
    {
        private const int MAIN_SCENE_INDEX = 1;
        
        private void Start()
        {
            InitManagers();

            LoadMainScene();
        }

        private void InitManagers()
        {
            HealthManager.Instance.Initialize();
            GoldManager.Instance.Initialize();
            LocationManager.Instance.Initialize();
            ShopManager.Instance.Initialize();
        }

        private void LoadMainScene()
        {
            SceneManager.LoadScene(sceneBuildIndex: MAIN_SCENE_INDEX);
        }
    }
}
