using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    public Projectile Projectile;
    public float TriggerRate;

    private float timeUntilTrigger;

    private void Start()
    {
        this.timeUntilTrigger = 0;
    }

    private void Update()
    {
        this.timeUntilTrigger -= this.TriggerRate * Time.deltaTime;
    }

    public void Trigger(WeaponModifiers weaponModifiers)
    {
        if (!(this.timeUntilTrigger <= 0)) return;

        this.timeUntilTrigger = 0;
        TriggerEffect(weaponModifiers);
        this.timeUntilTrigger += this.TriggerRate * weaponModifiers.Speed;
    }

    public virtual void TriggerEffect(WeaponModifiers weaponModifiers)
    {
        Instantiate(this.Projectile, this.transform.position, Quaternion.identity);
    }
}