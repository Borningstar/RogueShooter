namespace Items
{
    public sealed class ShotsUp : Item
    {
        public override void ActivateEffect(WeaponModifiers weaponModifiers, ShipProperties shipProperties)
        {
            weaponModifiers.Multiplier += 1;
        }
    }
}