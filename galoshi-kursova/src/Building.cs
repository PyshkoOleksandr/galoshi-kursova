namespace galoshi_kursova.src;
using System.Numerics;

internal abstract class Building : GameObject
{
    private byte slotQuantity;
    private byte occupiedSlots;
    private byte slotCapacity;

    public Building(Vector2 position, byte slotQuantity, int maxHealth)
    {
        this.position = position;
        this.slotQuantity = slotQuantity;
        this.occupiedSlots = 0;
        this.maxHealth = maxHealth;
        this.health = maxHealth;
        this.isEnemy = false;
    }

    public bool hasFreeSlots()
    {
        return occupiedSlots < slotQuantity;
    }

    public void occupySlot()
    {
        if (hasFreeSlots())
        {
            occupiedSlots++;
        }
    }

    public void freeSlot()
    {
        if (occupiedSlots > 0)
        {
            occupiedSlots--;
        }
    }

    protected override void died()
    {
        // Logic for when the building is destroyed
        Console.WriteLine("Building destroyed at position: " + position);
    }

}
