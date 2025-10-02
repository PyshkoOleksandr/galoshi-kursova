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

        Assert.IsTrue(building.IsMax());
    }

    [TestMethod]
    public void IsMax_NotMax_ReturnTrue()
    {
        Building building = new();
        building.Level = Building.MaxLevel - 1;

        Assert.IsFalse(building.IsMax());
    }
}
