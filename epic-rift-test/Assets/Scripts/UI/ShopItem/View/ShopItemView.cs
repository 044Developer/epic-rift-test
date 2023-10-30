using EpicRiftTest.Modules.Gold;
using EpicRiftTest.Modules.Health;
using EpicRiftTest.Modules.Location;
using EpicRiftTest.Modules.Shop.Data;
using EpicRiftTest.UI.ShopItem.Controller;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EpicRiftTest.UI.ShopItem.View
{
    public class ShopItemView : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _nameText;
        [SerializeField] private TextMeshProUGUI _rewardCount;
        [SerializeField] private TextMeshProUGUI _priceText;
        [SerializeField] private Button _purchaseButton;

        private ShopItemController _controller;
        private ShopBundle _bundle;

        public void Initialize(ShopBundle bundle)
        {
            _controller = new ShopItemController(bundle);
            _bundle = bundle;

            InitializeButtons();
            InitializeEvents();
            
            UpdateText();
        }
        
        private void OnDestroy()
        {
            Dispose();
        }

        private void Dispose()
        {
            DisposeButtons();

            DisposeEvents();
        }

        private void InitializeButtons()
        {
            _purchaseButton.onClick.AddListener(_controller.OnPurchaseButtonClicked);
        }

        private void InitializeEvents()
        {
            GoldManager.Instance.OnChanged += UpdateButton;
            HealthManager.Instance.OnChanged += UpdateButton;
            LocationManager.Instance.OnChanged += UpdateButton;
        }

        private void DisposeButtons()
        {
            _purchaseButton.onClick.RemoveListener(_controller.OnPurchaseButtonClicked);
        }

        private void DisposeEvents()
        {
            GoldManager.Instance.OnChanged -= UpdateButton;
            HealthManager.Instance.OnChanged -= UpdateButton;
            LocationManager.Instance.OnChanged -= UpdateButton;
        }

        private void UpdateText()
        {
            _nameText.text = _bundle.RewardBundleItem.Reward.GetType().Name;
            _rewardCount.text = $"{_bundle.RewardBundleItem.Value}";
            _priceText.text = $"{_bundle.PriceBundleItem.Spendable.GetType().Name} {_bundle.PriceBundleItem.Value}";
        }

        private void UpdateButton()
        {
            bool canBePurchased = _bundle.PriceBundleItem.Spendable.IsTransactionValid(_bundle.PriceBundleItem.Value);

            _purchaseButton.interactable = canBePurchased;
        }
    }
}