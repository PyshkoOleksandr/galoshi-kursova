namespace GaloshiKursovaTests;
using GaloshiKursova.Src;

[TestClass]
public class GameSessionTests
{
    [TestMethod]
    public void Money_BelowZero_ReturnZero()
    {
        GameSession session = new(new Unit[5]);
        session.Money = -10;
        Assert.AreEqual(0, session.Money);
    }

    public void Money_AboveMax_ReturnMax()
    {
        GameSession session = new(new Unit[5]);
        session.Money = 200;
        Assert.AreEqual(session.MaxMoney, session.Money);
    }
}
