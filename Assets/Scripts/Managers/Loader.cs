using UnityEngine;

public class Loader : MonoBehaviour
{
    public GameObject GameManager;          //GameManager prefab to instantiate.

    private void Awake()
    {
        //Check if a GameManager has already been assigned to static variable GameManager.instance or if it's still null
        if (global::Managers.GameManager.Instance == null)
        {
            //Instantiate gameManager prefab
            Instantiate(this.GameManager);
        }
    }
}
