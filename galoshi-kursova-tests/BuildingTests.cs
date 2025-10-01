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
}
