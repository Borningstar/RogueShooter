namespace Waves
{
    using Enemy;

    public sealed class StaticPattern : Pattern
    {
        public override void InitiatePattern(Enemy enemy)
        {
            foreach (var point in this.SpawnPoints)
            {
                Instantiate(enemy, point.position, point.rotation);
            }
        }
    }
}