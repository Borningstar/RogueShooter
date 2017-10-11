namespace Waves
{
    using System;
    using System.Collections;
    using Enemy;
    using UnityEngine;

    [Serializable]
    public class Wave : MonoBehaviour
    {
        public Enemy Enemy;
        public int SubWaves;
        public float SubWaveInterval;
        public int NumSubWaves;
        public Pattern Pattern;

        public void Trigger()
        {
            this.StartCoroutine("TriggerPattern");
        }

        private IEnumerator TriggerPattern()
        {
            for (var i = 0; i < this.NumSubWaves; i++)
            {
                this.Pattern.InitiatePattern(this.Enemy);

                yield return new WaitForSeconds(this.SubWaveInterval);
            }
        }
    }
}