   namespace CtrlCCtrlClick.Models;

public class Player 
{
    public int Score { get; private set; }

    public Player(int score = 0)
    {
        Score = score;
    }

    public int GetScore()
    {
        return Score;
    }

    public void AddScore(int value)
    {
        Score += value;
    }

    public void RemoveScore(int value)
    {
        Score = Math.Max(0, Score - value);
    }

    public void ResetScore()
    {
        Score = 0;
    }
}