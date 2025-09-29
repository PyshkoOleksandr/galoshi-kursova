using System.Numerics;

namespace galoshi_kursova.src;

public abstract class GameObject
{
    public Vector2 Position;

    private int _maxHealth;
    private int _health;

    public GameObject(Vector2 position, int maxHealth = 100)
    {
        Position = position;
        MaxHealth = maxHealth;
        Health = maxHealth;
    }

    public GameObject() : this(new Vector2(0f, 0f)) { }

    public int MaxHealth
    {
        get { return _maxHealth; }
        set { _maxHealth = Math.Max(0, value); }
    }

    public int Health
    {
        get { return _health; }
        set { 
            if (value <= 0)
            {
                _health = Math.Min(Math.Max(0, value), _maxHealth); 
                Died();
            }
        }
    }

    public virtual void TakeDamage(int amount)
    {
        Health -= amount;
        if (Health <= 0)
        {
            Died();
        }
    }
    public virtual void Update(float deltaTime) { }

    protected virtual void Died() { }
}

