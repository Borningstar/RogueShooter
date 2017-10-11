namespace Waves
{
    using Enemy;
    using UnityEngine;

    public sealed class StaticPattern : Pattern
    {
        public override void InitiatePattern(Enemy enemy)
        {
            foreach (var point in this.SpawnPoints)
            {
                Instantiate(enemy, point.position, point.rotation * Quaternion.Euler(0, this.Angle, 0));
            }
        }
    }
}