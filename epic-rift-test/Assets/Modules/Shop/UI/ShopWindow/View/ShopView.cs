using EpicRiftTest.Modules.Shop.Data;
using EpicRiftTest.Modules.Shop.UI.ShopItem.View;
using EpicRiftTest.Modules.Shop.UI.ShopWindow.ViewModel;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EpicRiftTest.Modules.Shop.UI.ShopWindow.View
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
    
        private ShopViewModel _viewModel;

        public void SetViewModel(ShopViewModel viewModel)
        {
            _viewModel = viewModel;
            UpdateView();
        
            _addGoldButton.onClick.AddListener(_viewModel.OnAddGoldButtonClicked);
            _addHealthButton.onClick.AddListener(_viewModel.OnAddHealthButtonClicked);
            _resetLocationButton.onClick.AddListener(_viewModel.OnResetLocationButtonClicked);
        }

        private void UpdateView()
        {
            _goldCountText.text = _viewModel.Gold;
            _healthCountText.text = _viewModel.Health;
            _locationNameText.text = _viewModel.Location;
        }
    }
}