namespace Enemy.Weapons
{
    using UnityEngine;
    using Projectiles;

    public class Weapon : MonoBehaviour
    {
        public Projectile Projectile;
        public float ShootRate;

        private void Start()
        {
            InvokeRepeating("Shoot", this.ShootRate, this.ShootRate);
        }

        public virtual void Shoot()
        {
            Instantiate(this.Projectile, this.transform.position, Quaternion.identity);
        }
    }
}
