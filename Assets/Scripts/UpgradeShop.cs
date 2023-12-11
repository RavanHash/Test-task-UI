using System.Collections.Generic;
using UnityEngine;

public class UpgradeShop : MonoBehaviour
{
    [SerializeField] private Transform content;
    [SerializeField] private GameObject upgradeItemPrefab;
    
    public void AddUpgradeItem(IUpgrade upgrade, float playerMoney)
    {
        var newUpgradeItem = CreateUpgradeItem();
        newUpgradeItem.SetItem(upgrade);
        newUpgradeItem.SetItemPurchaseButton(playerMoney);
    }

    private UpgradeItem CreateUpgradeItem()
    {
        var newUpgradeItem = Instantiate(upgradeItemPrefab, content).GetComponent<UpgradeItem>();
        return newUpgradeItem;
    }
}