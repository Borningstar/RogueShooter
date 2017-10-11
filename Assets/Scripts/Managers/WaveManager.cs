namespace Managers
{
    using System.Collections;
    using UnityEngine;
    using Waves;

    public sealed class WaveManager : MonoBehaviour
    {
        public static WaveManager Instance = null;

        public float Top;
        public float Bottom;
        public float Left;
        public float Right;
        public float Width;
        public float Height;
        public Wave[] Wave1;
        public Wave[] Wave2;

        //Awake is always called before any Start functions
        private void Awake()
        {
            //Check if instance already exists
            if (Instance == null)
            {
                //if not, set instance to this
                Instance = this;
            }

            //If instance already exists and it's not this:
            else if (Instance != this)
            {
                //Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
                Destroy(this.gameObject);
            }

            //Sets this to not be destroyed when reloading scene
            DontDestroyOnLoad(this.gameObject);
        }

        private void Start()
        {
            this.StartCoroutine("SpawnFirstWave");
        }

        private void SpawnWave(Wave wave)
        {
            wave.Trigger();
        }

        private IEnumerator SpawnFirstWave()
        {
            this.SpawnWave(this.Wave1[Random.Range(0, this.Wave1.Length - 1)]);

            yield return new WaitForSeconds(10);

            this.SpawnWave(this.Wave2[Random.Range(0, this.Wave2.Length - 1)]);
        }
    }
}