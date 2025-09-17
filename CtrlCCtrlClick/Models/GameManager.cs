namespace CtrlCCtrlClick.Models;

public class GameManager
{
    public Player Player { get; }
    public Shop Shop { get; }

    public GameManager()
    {
        Player = new Player();
        Shop = new Shop();
    }

    public void OnClick(int value)
    {
        Player.AddScore(value);
    }
}