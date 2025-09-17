namespace CtrlCCtrlClick.Models;

public class Upgrade
{
    public string Name { get; }
    public string Description { get; }
    public int Price { get; private set; }
    public bool Buyed { get; private set; }
    
    public Upgrade(string name, string description, int price, bool buyed = false)
    {
        Name = name;
        Description = description;
        Price = price;
        Buyed = buyed;
    }

    public void Purchase()
    {
        Buyed = true;
    }
}