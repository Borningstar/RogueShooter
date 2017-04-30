using UnityEngine;

public sealed class FanGun : Weapon
{
    public override void TriggerEffect(WeaponModifiers weaponModifiers)
    {
        var shots = weaponModifiers.Multiplier;
        var isEven = shots % 2 < 1;

        var halfShots = (shots - (isEven ? 0 : 1)) / 2f;
        
        var angle = 90 / (halfShots * 2);

        var transformRotation = this.transform.rotation;
        if (!isEven)
        {
            Instantiate(this.Projectile, this.transform.position, transformRotation);
        }

        if (shots > 1)
        {
            Shoot(transformRotation, halfShots, angle, weaponModifiers);
        }
    }

    private void Shoot(Quaternion transformRot, float shots, float angle, WeaponModifiers weaponModifiers)
    {
        for (var i = 0; i < shots; i++)
        {
            transformRot.eulerAngles = new Vector3(0, angle);
            Instantiate(this.Projectile.ApplyModifiers(weaponModifiers), this.transform.position, transformRot);

            transformRot.eulerAngles = new Vector3(0, -angle);
            Instantiate(this.Projectile, this.transform.position, transformRot);

            angle += angle;
        }
    }
}