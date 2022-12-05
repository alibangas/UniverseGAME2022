using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarSystemMusic : MonoBehaviour
{
    public static SolarSystemMusic instance;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);

        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
