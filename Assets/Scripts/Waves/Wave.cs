namespace Waves
{
    using System;
    using System.Collections;
    using Enemy;
    using UnityEngine;

    [Serializable]
    public class Wave : MonoBehaviour
    {
        public Enemy[] Enemies;
        public int SubWaves;
        public float SubWaveInterval;
        public int NumSubWaves;
        public Pattern Pattern;

        public void Trigger()
        {
            this.StartCoroutine("TriggerPattern");
        }

        IEnumerator TriggerPattern()
        {
            for (var i = 0; i < this.NumSubWaves; i++)
            {
                this.Pattern.InitiatePattern(this.Enemies[0]);

                yield return new WaitForSeconds(this.SubWaveInterval);
            }
        }
    }
}