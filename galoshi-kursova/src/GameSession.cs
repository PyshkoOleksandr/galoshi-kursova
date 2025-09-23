namespace galoshi_kursova.src;

using System.Collections.Generic;
using System.Numerics;

internal class GameSession
{
 
    public Unit[] selectedUnits = new Unit[5];

    private int moneyGainRate;
    private int currentMoney;
    private int maxMoney;

    private List<Unit> playerUnits;
    private List<Unit> enemyUnits;

    //TODO ... other game state variables ...

    public void update(float deltaTime)
    {
        UpdateUnits(deltaTime);

        UpdateMoney(deltaTime);

        CheckForDeadUnits();

        CheckPlayerSpawnRequests();

        SpawnPlayerUnits();

        SpawmEnemies();

        CheckGameEndConditions();

    }

    private void UpdateMoney(float deltaTime)
    {
        money += (int)(moneyGainRate * deltaTime);

        if(currentMoney > maxMoney)
        {
            currentMoney = maxMoney;
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

    private void SpawnPlayerUnits()
    {
        //TODO logic to spawn player units
    }

    private void SpawmEnemies()
    {
        //TODO logic to spawn enemy units
    }

    private void CheckPlayerSpawnRequests()
    {
        //TODO Input handling logic to spawn player units

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (currentMoney >= selectedUnits[0].cost)
            {
                SpawnPlayerUnit(new Vector2(0, 0), UnitType.SomeUnit);
                currentMoney -= 100;
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (currentMoney >= selectedUnits[1].cost)
            {
                SpawnPlayerUnit(new Vector2(0, 0), UnitType.SomeUnit);
                currentMoney -= 200;
            }
        }

    }

    private void CheckGameEndConditions()
    {
        //TODO logic to check win/lose conditions
    }
}
