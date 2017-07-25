namespace Waves
{
    using Enemy;
    using UnityEngine;

    public abstract class Pattern : MonoBehaviour
    {
        public Transform[] SpawnPoints;

        public abstract void InitiatePattern(Enemy enemy);
    }
}