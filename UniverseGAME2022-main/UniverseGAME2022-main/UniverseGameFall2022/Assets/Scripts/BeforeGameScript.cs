using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeforeGameScript : MonoBehaviour
{
    public GameObject obj;
    //// Start is called before the first frame update
    void Start()
    {
        obj.SetActive(false);
    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            obj.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
