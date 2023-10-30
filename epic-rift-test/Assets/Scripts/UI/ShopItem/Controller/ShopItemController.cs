using EpicRiftTest.Modules.Shop.Data;

namespace EpicRiftTest.UI.ShopItem.Controller
{
    public class ShopItemController
    {
        private readonly ShopBundle _bundle;

        public ShopItemController(ShopBundle bundle)
        {
            _bundle = bundle;
        }

        public void OnPurchaseButtonClicked()
        {
            _bundle.RewardBundleItem.Reward.ApplyReward(_bundle.RewardBundleItem.Value);
            _bundle.PriceBundleItem.Spendable.ApplyTransaction(_bundle.PriceBundleItem.Value);
        }
    }
}