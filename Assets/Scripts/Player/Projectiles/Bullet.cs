namespace Player.Projectiles
{
    public sealed class Bullet : Projectile
    {
        public override Projectile ApplyModifiers(WeaponModifiers weaponModifiers)
        {
            this.Damage += weaponModifiers.Damage;

            return this;
        }
    }
}
