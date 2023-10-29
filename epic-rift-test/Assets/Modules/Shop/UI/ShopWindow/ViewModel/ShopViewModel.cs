using EpicRiftTest.Modules.Shop.UI.ShopWindow.Model;

namespace EpicRiftTest.Modules.Shop.UI.ShopWindow.ViewModel
{
    public class ShopViewModel
    {
        private ShopModel _model;

        public ShopViewModel(ShopModel model)
        {
            _model = model;
        }
        
        public string Gold
        {
            get { return _model.Gold.ToString(); }
        }

        public string Health
        {
            get { return _model.Health.ToString(); }
        }

        public string Location
        {
            get { return _model.Location; }
        }
        
        public void OnAddGoldButtonClicked()
        {
            // Add gold logic here
            _model.Gold += 10;
        }

        public void OnAddHealthButtonClicked()
        {
            // Add health logic here
            _model.Health += 10;
        }

        public void OnResetLocationButtonClicked()
        {
            // Reset location logic here
            _model.Location = "Default Location";
        }
    }
}