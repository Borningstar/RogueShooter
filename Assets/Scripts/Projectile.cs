using UnityEngine;

public abstract class Projectile : MonoBehaviour
{
    public float Speed;
    public float Damage;

    public virtual Projectile ApplyModifiers(WeaponModifiers weaponModifiers)
    {
        return this;
    }

    private void Update()
    {
        this.transform.Translate(Vector3.forward * this.Speed * Time.deltaTime);
    }
}
