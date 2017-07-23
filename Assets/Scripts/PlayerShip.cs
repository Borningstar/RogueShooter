using System.Collections.Generic;
using System.Linq;
using Items;
using UnityEngine;

public sealed class PlayerShip : MonoBehaviour
{
    public ShipProperties ShipProperties;
    public WeaponModifiers WeaponModifiers;
    public List<Weapon> Weapons;
    public float WeaponTriggerRate;
    public float ItemTriggerRate;
    public List<Item> Items;

    private void Start ()
    {
	    InvokeRepeating("TriggerWeapons", this.WeaponTriggerRate, this.WeaponTriggerRate);
        InvokeRepeating("TriggerItems", this.ItemTriggerRate, this.ItemTriggerRate);
    }

    private void TriggerWeapons()
    {
        if (this.Weapons == null) return;

        this.Weapons
            .ForEach(weapon => weapon.Trigger(this.WeaponModifiers));
    }

    private void TriggerItems()
    {
        if (this.Items == null) return;
        
        this.Items
            .ForEach(item => item.Trigger(this.WeaponModifiers, this.ShipProperties));
    }

    private void OnTriggerEnter(Collider other)
    {
        switch (other.gameObject.tag)
        {
            case "Item":
                this.Items.Add(other.gameObject.GetComponent<ItemPickup>().Item);
                this.Items.Last().Activate(this.WeaponModifiers, this.ShipProperties);
                Destroy(other.gameObject);
                break;
            case "Enemy":
                var enemy = other.gameObject.GetComponent<Enemy>();
                enemy.DealDamage(enemy.CollisionDamage);
                this.DealDamage(enemy.CollisionDamage);
                break;
            default:
                break;
        }
    }

    private void DealDamage(int damage)
    {
        for (var i = 0; i < damage; i++)
        {
            if (this.ShipProperties.CurrentShield > 0)
            {
                this.ShipProperties.CurrentShield--;
            }
            else
            {
                this.ShipProperties.Armor--;
            }

            if (this.ShipProperties.Armor >= 1) continue;

            Destroy(this);
            break;
        }
    }
}
