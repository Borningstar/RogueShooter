namespace Enemy.Projectiles
{
    using UnityEngine;
    using Player;

    public class Projectile : MonoBehaviour
    {
        public int Damage;

        private void OnTriggerEnter(Collider other)
        {
            switch (other.gameObject.tag)
            {
                case "Player":
                    other.gameObject.GetComponent<PlayerShip>().DealDamage(this.Damage);
                    Destroy(this.gameObject);
                    break;
                default:
                    break;
            }
        }
    }
}
