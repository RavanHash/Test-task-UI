using UnityEngine;

namespace Upgrades
{
    public class MozzarellaProfit: IUpgrade
    {
        private string _name = "Made with love";
        private string _description = "Mozzarella profit x20";
        private float _price = 199f;
        private string _imageName = "Mozzarella";
    
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
            Debug.Log("Mozzarella profit x20");
        }
    }
}