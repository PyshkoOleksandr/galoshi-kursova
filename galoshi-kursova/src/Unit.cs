using System.Numerics;

namespace galoshi_kursova.src;

internal abstract class Unit : GameObject
{
    protected Vector2 speed;
    protected float attackRange;
    protected int attackDamage;
    protected float attackCooldownS;

    protected virtual void Move()
    {
        position += speed;
    }

    protected virtual void Attack(GameObject target)
    {
        if (Vector2.Distance(position, target.position) <= attackRange)
        {
            target.TakeDamage(attackDamage);
        }
    }
}
