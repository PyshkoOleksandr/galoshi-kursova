namespace GaloshiKursovaTests;

using GaloshiKursova.Src;

[TestClass]
public class BuildingTests
{
    [TestMethod]
    public void IsMax_Max_ReturnTrue()
    {
        Building building = new();
        building.Level = Building.MaxLevel;

        Assert.IsTrue(building.Level == Building.MaxLevel);
    }

    [TestMethod]
    public void IsMax_NotMax_ReturnTrue()
    {
        Building building = new();
        building.Level = Building.MaxLevel - 1;

        Assert.IsTrue(building.Level != Building.MaxLevel);
    }

    [TestMethod]
    public void UpgradeCost_NegativeValue_ReturnZero()
    {
        Building building = new();
        building.UpgradeCost = -10;
        Assert.AreEqual(0, building.UpgradeCost);
    }

    [TestMethod]
    public void UpgradeCost_PositiveValue_ReturnSameValue()
    {
        Building building = new();
        building.UpgradeCost = 100;
        Assert.AreEqual(100, building.UpgradeCost);
    }
    
    [TestMethod]
    public void Upgrade_IncreaseLevelBuilding()
    {
        Building building = new();

        int initialLevel = building.Level;
        int initialUpgradeCost = building.UpgradeCost;

        building.Upgrade();

        Assert.AreEqual(initialLevel + 1, building.Level);
        Assert.AreEqual(initialUpgradeCost + Building.UpgradeCostIncrement, building.UpgradeCost);
    }
}

