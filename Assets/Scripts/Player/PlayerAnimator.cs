namespace Player
{
    using UnityEngine;

    public class PlayerAnimator : MonoBehaviour
    {
        private Animator animator;

        private void Start()
        {
            this.animator = this.GetComponent<Animator>();
        }

        private void Update()
        {
            var mousePos = Input.mousePosition;
            //Z needs to be non-zero otherwise ScreenToWorldPoint doesn't work
            mousePos.z = Camera.main.transform.position.y;
            var mouseWorldPoint = Camera.main.ScreenToWorldPoint(mousePos);
            var currentPos = this.transform.position;

            if (mouseWorldPoint.x < currentPos.x)
            {
                this.animator.SetInteger("Direction", -1);
            }
            else if (mouseWorldPoint.x > currentPos.x)
            {
                this.animator.SetInteger("Direction", 1);
            }
            else
            {
                this.animator.SetInteger("Direction", 0);
            }
        }
    }
}