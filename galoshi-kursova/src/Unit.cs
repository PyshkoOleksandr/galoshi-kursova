using System.Numerics;

namespace GaloshiKursova.Src;

public class Unit : GameObject
{
    private int _cost;

    protected int AttackDamage;

    protected float AttackRange;
    protected float AttackCooldownSec;

    protected Vector2 Speed;

    public int Cost
    {
        get { return _cost; }
        protected set { _cost = Math.Max(0, value); }
    }

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
