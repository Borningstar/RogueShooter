namespace Enemy.Projectiles
{
    using UnityEngine;

    public sealed class StartLinearMoveToPlayer : MonoBehaviour
    {
        public float Speed;

        private void Start()
        {
            this.transform.LookAt(GameManager.Instance.PlayerShip.transform);
        }

        private void Update()
        {
            this.transform.Translate(Vector3.forward * this.Speed * Time.deltaTime);
        }
    }
}
