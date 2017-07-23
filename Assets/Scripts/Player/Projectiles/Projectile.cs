namespace Player.Projectiles
{
    using UnityEngine;
    using Enemy;

    public abstract class Projectile : MonoBehaviour
    {
        public float Speed;
        public int Damage;

        public virtual Projectile ApplyModifiers(WeaponModifiers weaponModifiers)
        {
            return this;
        }

        private void Update()
        {
            this.transform.Translate(Vector3.forward * this.Speed * Time.deltaTime);
        }

        private void OnTriggerEnter(Collider other)
        {
            switch (other.gameObject.tag)
            {
                case "Enemy":
                    other.gameObject.GetComponent<Enemy>().DealDamage(this.Damage);
                    Destroy(this.gameObject);
                    break;
                default:
                    break;
            }
        }
    }
}