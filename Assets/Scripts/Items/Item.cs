namespace Items
{
    using UnityEngine;

    public abstract class Item : MonoBehaviour
    {
        public float TriggerRate;

        private float timeUntilTrigger;

        private void Start()
        {
            this.timeUntilTrigger = 0;
        }

        public virtual void Activate(WeaponModifiers weaponModifiers, ShipProperties shipProperties)
        {
            ActivateEffect(weaponModifiers, shipProperties);
        }

        public virtual void ActivateEffect(WeaponModifiers weaponModifiers, ShipProperties shipProperties)
        {
        }

        public virtual void Trigger(WeaponModifiers weaponModifiers, ShipProperties shipProperties)
        {
            if (!(this.timeUntilTrigger <= 0)) return;

            this.timeUntilTrigger = 0;
            TriggerEffect(weaponModifiers, shipProperties);
            this.timeUntilTrigger += this.TriggerRate * weaponModifiers.Speed;
        }

        public virtual void TriggerEffect(WeaponModifiers weaponModifiers, ShipProperties shipProperties)
        {
        }
    }
}