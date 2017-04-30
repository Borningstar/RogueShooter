namespace Items
{
    public sealed class SpeedUp : Item
    {
        public override void ActivateEffect(WeaponModifiers weaponModifiers, ShipProperties shipProperties)
        {
            weaponModifiers.Speed -= 0.1f;
        }
    }
}