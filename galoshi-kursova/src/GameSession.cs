namespace galoshi_kursova.src;

using System.Collections.Generic;

internal class GameSession
{

    private int money;
    private int moneyGainRate;
    private int currentMoney;
    private int MaxMoney;

    private List<Unit> playerUnits;
    private List<Unit> enemyUnits;

    ... other game state variables ...

    public void update(float deltaTime)
    {
        UpdateUnits(deltaTime);

        UpdateMoney(deltaTime);

        CheckPlayerSpawnRequests();

        SpawmEnemies();

        CheckGameEndConditions();

    }

    private void UpdateMoney(float deltaTime)
    {
        money += (int)(moneyGainRate * deltaTime);

        if(currentMoney > MaxMoney)
        {
            currentMoney = MaxMoney;
        }

    }

    private void UpdateUnits(float deltaTime)
    {
        for(int i = 0; i < playerUnits.Count; i++)
        {
            playerUnits[i].Update(deltaTime);
        }

        for(int i = 0; i < enemyUnits.Count; i++)
        {
            enemyUnits[i].Update(deltaTime);
        }
        
        CheckForDeadUnits;
    }

    private void CheckForDeadUnits()
    {
        playerUnits.RemoveAll(unit => unit.Health <= 0);
        enemyUnits.RemoveAll(unit => unit.Health <= 0);
    }
}
