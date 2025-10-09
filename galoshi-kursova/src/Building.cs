namespace GaloshiKursova.Src;

public class Building : GameObject
{
    public const int MaxLevel = 3;
    public const int UpgradeCostIncrement = 50;

    private int _upgradeCost = 50;
    private int _level = 1;

    public bool IsMax()
    {
        return Level >= MaxLevel;
    }

    public int UpgradeCost
    {
        set => _upgradeCost = Math.Max(0, value);
        get => _upgradeCost;
    }

    public int Level
    {
        set => _level = Math.Min(Math.Max(1, value), MaxLevel);
        get => _level;
    }

    public void Upgrade() 
    {
        UpgradeCost += UpgradeCostIncrement;
        Level++;
    }
}
