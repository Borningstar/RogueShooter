using UnityEngine;

public sealed class FanGun : Weapon
{
    public override void TriggerEffect(WeaponModifiers weaponModifiers)
    {
        var shots = Mathf.FloorToInt(weaponModifiers.Multiplier);

        if (shots >= 1)
        {
            Shoot(shots, weaponModifiers);
        }
    }

    private void Shoot(int shots, WeaponModifiers weaponModifiers)
    {
        var isEven = shots % 2 < 1;

        if (!isEven)
        {
            Instantiate(this.Projectile, this.transform.position, this.transform.rotation);
        }

        if (shots == 1)
        {
            return;
        }

        var halfShots = (shots - (isEven ? 0 : 1)) / 2f;

        var angle = 90 / (halfShots * 2);

        var rotation = this.transform.rotation;

        this.ShootFanShots(shots, angle, weaponModifiers, rotation);
    }

    private void ShootFanShots(
        int shots,
        float angle,
        WeaponModifiers weaponModifiers,
        Quaternion rotation)
    {
        for (var i = 0; i < shots; i++)
        {
            rotation.eulerAngles = new Vector3(0, angle);
            Instantiate(this.Projectile.ApplyModifiers(weaponModifiers), this.transform.position, rotation);

            rotation.eulerAngles = new Vector3(0, -angle);
            Instantiate(this.Projectile, this.transform.position, rotation);

            angle += angle;
        }
    }
}