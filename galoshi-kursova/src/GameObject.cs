namespace galoshi_kursova.src;

internal abstract class GameObject
{
    public int position;
    public bool isEnemy;

    protected int maxHealth;
    protected int health;

    public virtual void takeDamage(int amount)
    {
        health -= amount;
        if (health <= 0)
        {
            died();
        }
    }

    protected abstract void died();
}

