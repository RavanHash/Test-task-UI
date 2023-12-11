using UnityEngine;

namespace Upgrades
{
    [System.Serializable]
    public class AddOneCashier : IUpgrade
    {
        private string _name = "Visit a university job fair";
        private string _description = "+1 Cashier";
        private float _price = 99.9f;
        private string _imageName = "Cashier";
    
        public string GetName()
        {
            return _name;
        }

        public string GetDescription()
        {
            return _description;
        }

        public float GetPrice()
        {
            return _price;
        }

        public Sprite GetImage()
        {
            return Resources.Load<Sprite>("Sprites/" + _imageName);
        }

        public void ApplyEffect()
        {
            Debug.Log("+1 Cashier");
        }
    }
}