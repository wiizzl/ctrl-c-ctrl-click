namespace CtrlCCtrlClick.Models;

public class Shop
{
    public List<Upgrade> Upgrades { get; set; }

    public Shop()
    {
        Upgrades = new List<Upgrade>
        {
            new Upgrade("Auto-code", "Créé une ligne de code par seconde de manière automatique", 10)
        };
    }

    public bool CanAfford(Upgrade upgrade, Player player)
    {
        return upgrade.Price <= player.Score;
    }

    public bool BuyUpgrade(Upgrade upgrade, Player player)
    {
        if (!CanAfford(upgrade, player))
        {
            return false;
        }
        
        player.RemoveScore(upgrade.Price);
        upgrade.Purchase();

        return true;
    }
}