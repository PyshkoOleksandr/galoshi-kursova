using System.Numerics;

namespace galoshi_kursova.src;

internal abstract class Unit : GameObject
{
    protected Vector2 speed;
    protected float attackRange;
    protected float attackDamage;
    protected float attackCooldownS;
}
