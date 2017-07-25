namespace Enemy
{
    using UnityEngine;

    public class Cleaner : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            switch (other.gameObject.tag)
            {
                case "Enemy":
                    Destroy(other.gameObject);
                    break;
                case "EnemyProjectile":
                    Destroy(other.gameObject);
                    break;
            }
        }
    }
}