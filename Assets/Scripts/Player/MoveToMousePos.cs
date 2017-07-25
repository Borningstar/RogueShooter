namespace Player
{
    using UnityEngine;

    public class MoveToMousePos : MonoBehaviour
    {
        public float Speed;
        public float MaxX;
        public float MaxZ;
        public float ShipWidth;
        public float ShipHeight;

        private void Start()
        {
            this.ShipWidth /= 2;
            this.ShipHeight /= 2;
            this.MaxX -= this.ShipWidth;
            this.MaxZ -= this.ShipHeight;
        }

        private void Update ()
        {
            var mousePos = Input.mousePosition;
            //Z needs to be non-zero otherwise ScreenToWorldPoint doesn't work
            mousePos.z = Camera.main.transform.position.y;
            var goalPos = Camera.main.ScreenToWorldPoint(mousePos);
            goalPos.x = Mathf.Clamp(goalPos.x, -this.MaxX, this.MaxX);
            goalPos.z = Mathf.Clamp(goalPos.z, -this.MaxZ, this.MaxZ);
            var currentPos = this.transform.position;

            this.transform.position = Vector3.MoveTowards(currentPos, new Vector3(goalPos.x, 0, goalPos.z),this.Speed * Time.deltaTime);
        }
    }
}