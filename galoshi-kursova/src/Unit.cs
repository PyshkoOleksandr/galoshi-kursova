using System.Numerics;

namespace galoshi_kursova.src;

internal abstract class Unit : GameObject
{
    protected Vector2 speed;
    protected float attackRange;
    protected int attackDamage;
    protected float attackCooldownS;

    protected virtual void move()
    {
        position += speed;
    }

    protected virtual void attack(GameObject target)
    {
        if (Vector2.Distance(position, target.position) <= attackRange)
        {
            target.takeDamage(attackDamage);
        }
    }
}
