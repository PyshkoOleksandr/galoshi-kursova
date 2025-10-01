namespace GaloshiKursova.Src;

public class Building : GameObject
{
    public const int MaxLevel = 3;
    public const int UpgradeCostIncrement = 50;

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

    // TODO Test Dasha
    public int UpgradeCost
    {
        private set { _upgradeCost = Math.Max(0, value); }
        get { return _upgradeCost; }
    }

    public int Level
    {
        set { _level = Math.Min(Math.Max(1, value), MaxLevel); }
        get { return _level; }
    }

    // TODO Test Dasha
    public void Upgrade() 
    {
        UpgradeCost += UpgradeCostIncrement;
        Level++;
    }
}
