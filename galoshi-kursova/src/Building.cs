namespace galoshi_kursova.src;

public class Building : GameObject
{
    private const int MaxLevel = 3;
    private const int UpgradeCostIncrement = 50;

    private int _upgradeCost;
    private int _level;

    public Building()
    {
        _upgradeCost = 50;
        _level = 1;
    }

    public bool IsMax()
    {
        return Level >= MaxLevel;
    }

    public int UpgradeCost
    {
        set { _upgradeCost = Math.Max(0, value); }
        get { return _upgradeCost; }
    }

    public int Level
    {
        private set { _level = Math.Min(Math.Max(1, value), MaxLevel); }
        get { return _level; }
    }

    public void Upgrade() 
    {
        UpgradeCost += UpgradeCostIncrement;
        Level++;
    }
}
