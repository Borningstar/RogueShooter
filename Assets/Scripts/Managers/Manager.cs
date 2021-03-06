﻿namespace Managers
{
    using UnityEngine;

    public class Manager : MonoBehaviour
    {
        public static Manager Instance = null;

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
    }
}
