using System.Collections.Generic;
using UnityEngine;
using Upgrades;

public class UpgradesInitializer : MonoBehaviour
{
    [SerializeField] private UpgradeShop upgradeShop;
    
    private void Start()
    {
        upgradeShop.AddUpgradeItem(new AddOneCashier(), 100);
        upgradeShop.AddUpgradeItem(new MozzarellaProfit(), 100);
        upgradeShop.AddUpgradeItem(new AddOneCashier(), 100);
        upgradeShop.AddUpgradeItem(new MozzarellaProfit(), 100);
        upgradeShop.AddUpgradeItem(new AddOneCashier(), 100);
        upgradeShop.AddUpgradeItem(new MozzarellaProfit(), 100);
        upgradeShop.AddUpgradeItem(new AddOneCashier(), 100);
        upgradeShop.AddUpgradeItem(new MozzarellaProfit(), 100);
        upgradeShop.AddUpgradeItem(new AddOneCashier(), 100);
        upgradeShop.AddUpgradeItem(new MozzarellaProfit(), 100);
        upgradeShop.AddUpgradeItem(new AddOneCashier(), 100);
        upgradeShop.AddUpgradeItem(new MozzarellaProfit(), 100);
    }
}