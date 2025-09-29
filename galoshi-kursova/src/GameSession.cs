namespace galoshi_kursova.src;

using System.Collections.Generic;

public class GameSession
{
    public Unit[] SelectedUnits = new Unit[5];

    private const int MaxMoneyIncrement = 50;
    private const float MoneyGainRateIncrement = 0.5f;

    private int _maxMoney;

    private float _currentMoney;
    private float _moneyGainRateSec;

    private readonly Player _player = new();
    private readonly Building _playerBuilding = new();
    private readonly Building _enemyBuilding = new();

    private InputManager _inputManager = new();

    private List<Unit> _playerUnits = new(20);
    private List<Unit> _enemyUnits = new(20);

    // TODO ... other game state variables ...

    GameSession(Unit[] selectedUnits)
    {
        SelectedUnits = selectedUnits;
        _moneyGainRateSec = 1.0f;
        _currentMoney = 0.0f;
        _maxMoney = 100;
    }

    public float Money
    {
        get { return (int)_currentMoney; }
        set { _currentMoney = Math.Min(Math.Max(0.0f, value), MaxMoney); }
    }

    private int MaxMoney
    {
        get { return (int)_maxMoney; }
        set { _maxMoney = Math.Max(0, value); }
    }

    public void Update(float deltaTime)
    {
        UpdateUnits(deltaTime);

        UpdateMoney(deltaTime);

        CheckForDeadUnits();

        CheckPlayerSpawnRequests();

        CheckGameEndConditions();
    }

    // TODO move to Player class
    public void UpgradeBuilding()
    {
        if ((Money < _playerBuilding.UpgradeCost) || _playerBuilding.IsMax())
        {
            return;
        }

        _playerBuilding.Upgrade();
        _moneyGainRateSec += MoneyGainRateIncrement;
        MaxMoney += MaxMoneyIncrement;
    }

    private void UpdateMoney(float deltaTime)
    {
        _currentMoney += _moneyGainRateSec * deltaTime;

        if(_currentMoney > _maxMoney)
        {
            _currentMoney = _maxMoney;
        }

    }

    private void UpdateUnits(float deltaTime)
    {
        for(int i = 0; i < _playerUnits.Count; i++)
        {
            _playerUnits[i].Update(deltaTime);
        }

        for(int i = 0; i < _enemyUnits.Count; i++)
        {
            _enemyUnits[i].Update(deltaTime);
        }
        
        CheckForDeadUnits();
    }
    
    private void CheckForDeadUnits()
    {
        _playerUnits.RemoveAll(unit => unit.Health <= 0);
        _enemyUnits.RemoveAll(unit => unit.Health <= 0);
    }

    private void CheckPlayerSpawnRequests()
    {
        //TODO Input handling logic to spawn player units

        if (_inputManager.GetKeyDown(KeyCode.Alpha1))
        {
            if (_currentMoney >= SelectedUnits[0].Cost)
            {
                SpawnPlayerUnit();
                _currentMoney -= 100;
            }
        }

        if (_inputManager.GetKeyDown(KeyCode.Alpha2))
        {
            if (_currentMoney >= SelectedUnits[1].Cost)
            {
                SpawnPlayerUnit();
                _currentMoney -= 200;
            }
        }
    }

    private void SpawnPlayerUnit()
    {
        // TODO
    }

    private void CheckGameEndConditions()
    {
        //TODO logic to check win/lose conditions
    }
}
