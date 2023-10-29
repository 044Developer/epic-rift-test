using EpicRiftTest.Modules.Shop.UI.ShopItem.ViewModel;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EpicRiftTest.Modules.Shop.UI.ShopItem.View
{
    public class ShopItemView : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _nameText;
        [SerializeField] private TextMeshProUGUI _priceText;
        [SerializeField] private Button _purchaseButton;

        private ShopItemViewModel _viewModel;

        public void SetViewModel(ShopItemViewModel viewModel)
        {
            _viewModel = viewModel;
            UpdateView();
        
            _purchaseButton.onClick.AddListener(_viewModel.OnPurchaseButtonClicked);
        }

        private void UpdateView()
        {
            _nameText.text = _viewModel.Name;
            _priceText.text = _viewModel.Price;
        }
    }
}