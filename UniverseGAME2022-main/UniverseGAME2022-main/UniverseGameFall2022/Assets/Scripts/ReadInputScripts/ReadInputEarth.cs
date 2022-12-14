using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReadInputEarth : MonoBehaviour
{
    private string input;
    public GameObject greenCheckMark;
    public GameObject redXMark;
    // Start is called before the first frame update
    void Start()
    {
        greenCheckMark.SetActive(false);
        redXMark.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene(14); //After Earth Dialogue = 14
        }
    }

    public void ReadStringInput(string str)
    {
        input = str.ToLower();
        if (input == "third")
        {
            Debug.Log("Correct!");
            greenCheckMark.SetActive(true);
            redXMark.SetActive(false);
        }
        else
        {
            redXMark.SetActive(true);
            greenCheckMark.SetActive(false);
        }

    }
}
