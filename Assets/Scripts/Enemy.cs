using UnityEngine;

public sealed class Enemy : MonoBehaviour
{
    public int CollisionDamage;
    public int Health;

    public void DealDamage(int damage)
    {
        this.Health -= damage;

        if (this.Health < 1)
        {
            Destroy(this.gameObject);
        }
    }
}
