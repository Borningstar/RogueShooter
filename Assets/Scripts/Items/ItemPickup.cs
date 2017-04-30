namespace Items
{
    using UnityEngine;

    public sealed class ItemPickup : MonoBehaviour
    {
        public Item Item;
        public float Speed;

        private void Update()
        {
            this.transform.Translate(Vector3.forward * this.Speed * Time.deltaTime);
        }
    }
}