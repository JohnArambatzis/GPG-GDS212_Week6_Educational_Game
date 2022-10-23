using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public int startQuestions;
    
    
    public void StartQuestions()
    {
        startQuestions = Random.Range(1, 4);


        if (startQuestions == 1)
        {
            SceneManager.LoadScene(1);
        }
        if (startQuestions == 2)
        {
            SceneManager.LoadScene(2);
        }
        if (startQuestions >= 3)
        {
            SceneManager.LoadScene(3);
        }
    }
}
