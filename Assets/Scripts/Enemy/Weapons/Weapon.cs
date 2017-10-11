namespace Enemy.Weapons
{
    using Managers;
    using UnityEngine;
    using Projectiles;

    public class Weapon : MonoBehaviour
    {
        public Projectile Projectile;
        public float ShootRate;

        private void Start()
        {
            this.InvokeRepeating("Shoot", this.ShootRate, this.ShootRate);
        }

        public virtual void Shoot()
        {
            if (this.transform.position.z > WaveManager.Instance.Bottom)
            {
                Instantiate(this.Projectile, this.transform.position, this.transform.rotation);
            }
        }
    }
}
