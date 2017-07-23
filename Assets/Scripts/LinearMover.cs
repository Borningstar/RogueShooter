using UnityEngine;

public class LinearMover : MonoBehaviour
{
    public float Speed;

    private void Update()
    {
        this.transform.Translate(Vector3.forward * this.Speed * Time.deltaTime);
    }
}