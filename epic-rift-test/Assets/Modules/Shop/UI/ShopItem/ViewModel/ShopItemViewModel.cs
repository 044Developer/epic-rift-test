using EpicRiftTest.Modules.Shop.UI.ShopItem.Model;

namespace EpicRiftTest.Modules.Shop.UI.ShopItem.ViewModel
{
    public class ShopItemViewModel
    {
        private ShopItemModel _model;

        public ShopItemViewModel(ShopItemModel model)
        {
            _model = model;
        }

        public string Name
        {
            get { return _model.Name; }
        }

        public string Price
        {
            get { return $"${_model.Price}"; }
        }

        public void OnPurchaseButtonClicked()
        {
        }
    }
}