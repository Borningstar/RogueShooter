namespace Managers
{
    using UnityEngine;

    public class SpawnPointManager : Manager
    {
        public new static SpawnPointManager Instance = null;

        public Transform[ , , ] TopSpawnPoints;

    }
}
