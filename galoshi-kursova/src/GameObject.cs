using System.Numerics;

namespace galoshi_kursova.src;

internal abstract class GameObject
{
    public Vector2 position;
    public bool isEnemy;

    protected int maxHealth;
    protected int health;

    public virtual void TakeDamage(int amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Died();
        }
    }

    public virtual void Update(float deltaTime) {}

    protected abstract void Died();
}

