using System.Numerics;

namespace galoshi_kursova.src;

public class Unit : GameObject
{
    protected int AttackDamage;

    protected float AttackRange;
    protected float AttackCooldownSec;

    protected Vector2 Speed;

    public virtual void Move()
    {
        Position += Speed;
    }

    protected virtual void Attack(GameObject target)
    {
        if (Vector2.Distance(Position, target.Position) <= AttackRange)
        {
            target.TakeDamage(AttackDamage);
        }
    }
}
