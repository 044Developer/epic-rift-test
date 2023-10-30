using EpicRiftTest.Modules.Gold;
using EpicRiftTest.Modules.Health;
using EpicRiftTest.Modules.Location;
using EpicRiftTest.Modules.Shop.Data;
using EpicRiftTest.Modules.Shop.Models;
using EpicRiftTest.UI.ShopItem.View;
using EpicRiftTest.UI.ShopWindow.Controller;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EpicRiftTest.UI.ShopWindow.View
{
    public class ShopView : MonoBehaviour
    {
        [Header("Gold")]
        [SerializeField] private TextMeshProUGUI _goldCountText;
        [SerializeField] private Button _addGoldButton;
        
        [Header("Health")]
        [SerializeField] private TextMeshProUGUI _healthCountText;
        [SerializeField] private Button _addHealthButton;
        
        [Header("Location")]
        [SerializeField] private TextMeshProUGUI _locationNameText;
        [SerializeField] private Button _resetLocationButton;

        [Header("Settings")]
        [SerializeField] private ShopItemView _itemPrefab;
        [SerializeField] private RectTransform _itemParent;
        [SerializeField] private ShopConfiguration _configuration;
    
        private ShopController _controller;

        private void Awake()
        {
            _controller = new ShopController();

            Initialize();
        }

        private void Start()
        {
            CreateShopView();
        }

        private void OnDestroy()
        {
            Dispose();
        }

        private void Initialize()
        {
            InitializeButtons();
            
            InitializeEvents();
            
            UpdateView();
        }

        private void Dispose()
        {
            DisposeButtons();

            DisposeEvents();
        }

        private void InitializeButtons()
        {
            _addGoldButton.onClick.AddListener(_controller.OnAddGoldButtonClicked);
            _addHealthButton.onClick.AddListener(_controller.OnAddHealthButtonClicked);
            _resetLocationButton.onClick.AddListener(_controller.OnResetLocationButtonClicked);
        }

        private void InitializeEvents()
        {
            GoldManager.Instance.OnChanged += UpdateView;
            HealthManager.Instance.OnChanged += UpdateView;
            LocationManager.Instance.OnChanged += UpdateView;
        }

        private void DisposeButtons()
        {
            _addGoldButton.onClick.RemoveListener(_controller.OnAddGoldButtonClicked);
            _addHealthButton.onClick.RemoveListener(_controller.OnAddHealthButtonClicked);
            _resetLocationButton.onClick.RemoveListener(_controller.OnResetLocationButtonClicked);
        }

        private void DisposeEvents()
        {
            GoldManager.Instance.OnChanged -= UpdateView;
            HealthManager.Instance.OnChanged -= UpdateView;
            LocationManager.Instance.OnChanged -= UpdateView;
        }

        private void UpdateView()
        {
            _goldCountText.text = GoldManager.Instance.DisplayCurrentValue();
            _healthCountText.text = HealthManager.Instance.DisplayCurrentValue();
            _locationNameText.text = LocationManager.Instance.DisplayCurrentValue();
        }

        private void CreateShopView()
        {
            foreach (ShopBundle bundle in _configuration.ShopBundles)
            {
                SetUpNewShopElement(bundle);
            }
        }

        private void SetUpNewShopElement(ShopBundle bundle)
        {
            ShopItemView shopElement = Instantiate(_itemPrefab, _itemParent);

            shopElement.Initialize(bundle);
        }
    }
}