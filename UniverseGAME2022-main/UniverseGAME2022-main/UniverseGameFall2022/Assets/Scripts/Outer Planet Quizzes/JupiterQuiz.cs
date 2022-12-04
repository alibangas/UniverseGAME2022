using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class JupiterQuiz : MonoBehaviour
{

    public GameObject QuestionBox;
    public GameObject Answer1;
    public GameObject Answer2;
    public GameObject Answer3;
    public GameObject Answer4;
    public int ChoiceMade;

    public void ChoiceOption1()
    {
        QuestionBox.GetComponent<Text>().text = "That is incorrect! Try again.";
        ChoiceMade = 1;
    }

    public void ChoiceOption2()
    {
        QuestionBox.GetComponent<Text>().text = "That is incorrect! Try again.";
        ChoiceMade = 2;
    }

    public void ChoiceOption3()
    {
        QuestionBox.GetComponent<Text>().text = "That is incorrect! Try again.";
        ChoiceMade = 3;
    }

    public void ChoiceOption4()
    {
        QuestionBox.GetComponent<Text>().text = "That is correct!";
        ChoiceMade = 4;
    }

    void Update()
    {
        if (ChoiceMade == 1)
        {
            Answer2.SetActive(true);
            Answer3.SetActive(true);
            Answer4.SetActive(true);
        }
        if (ChoiceMade == 2)
        {
            Answer1.SetActive(true);
            Answer3.SetActive(true);
            Answer4.SetActive(true);
        }
        if (ChoiceMade == 3)
        {
            Answer1.SetActive(true);
            Answer2.SetActive(true);
            Answer4.SetActive(true);
        }
        if (ChoiceMade == 4)
        {
            Answer1.SetActive(false);
            Answer2.SetActive(false);
            Answer3.SetActive(false);
        }

        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("After Jupiter Dialogue");
        }
    }
}