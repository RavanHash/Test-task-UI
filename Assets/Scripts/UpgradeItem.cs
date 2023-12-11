using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeItem : MonoBehaviour
{
        [SerializeField] private TextMeshProUGUI itemName;
        [SerializeField] private TextMeshProUGUI itemDescription;
        [SerializeField] private TextMeshProUGUI[] itemPriceTxt;
        [SerializeField] private Image itemImage;
        
        [SerializeField] private GameObject purchaseBtn;
        [SerializeField] private GameObject cantPurchaseBtn;

        private float _itemPrice;
        private IUpgrade _upgrade;
        
        public void SetItem(IUpgrade upgrade)
        {
                _upgrade = upgrade;

                SetItemDetails();
        }

        private void SetItemDetails()
        {
                itemName.text = _upgrade.GetName();
                itemDescription.text = _upgrade.GetDescription();

                _itemPrice = _upgrade.GetPrice();
                itemPriceTxt[0].text = _itemPrice + "T";
                itemPriceTxt[1].text = _itemPrice + "T";

                itemImage.sprite = _upgrade.GetImage();
        }

        public void SetItemPurchaseButton(float playerMoney)
        {
                var canAfford = playerMoney >= _itemPrice;
                purchaseBtn.SetActive(canAfford);
                cantPurchaseBtn.SetActive(!canAfford);
        }

        public void PurchaseUpgradeItem()
        {
                _upgrade.ApplyEffect();
                Destroy(gameObject);
        }
}