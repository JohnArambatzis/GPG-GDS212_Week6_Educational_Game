using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MathPlus : MonoBehaviour
{
    public GameObject nextQuestionButton;
    public GameObject answerCorrect;
    public GameObject answerWrong;
    public float answerWrongTimer = 3f;
    public bool answerWrongBool;

    public TextMeshProUGUI questionText;
    public TextMeshProUGUI mathQuestionText;
    public TMP_InputField inputAnswer;

    public int number1;
    public int number2;
    public int answer;
    public int playersAnswer;
    public int textChoice;
    public int nextQuestion;


    void Start()
    {
        number1 += Random.Range(2, 61);
        Debug.Log("Number1 = " + number1);
        number2 += Random.Range(2, 61);
        Debug.Log("Number2 = " + number2);
        answer = number1 + number2;
        Debug.Log("Answer = " + answer);


        textChoice += Random.Range(1, 4);
        if (textChoice == 1)
        {
            questionText.text = "Tom has " + number1 + " apples and picked up " + number2 + " more from his fruit tree, How many apples does Tom have now?";
        }
        if (textChoice == 2)
        {
            questionText.text = "Henry has " + number1 + " cupcakes and made " + number2 + " more in his kitchen, How many cupcakes does Henry have now?";
        }
        if (textChoice >= 3)
        {
            questionText.text = "Pete has " + number1 + " dollars and was given " + number2 + " more from his Grandmother, How much money does Pete have now?";
        }

        mathQuestionText.text = number1 + " + " + number2 + " =";
    }

    void Update()
    {
        if (answerWrongBool == true)
        {
            answerWrongTimer -= Time.deltaTime;

            if (answerWrongTimer <= 0)
            {
                answerWrong.SetActive(false);
                answerWrongBool = false;
                answerWrongTimer = 3f;
            }
        }
    }


    public void CheckAnswer()
    {
        int.TryParse(inputAnswer.text, out playersAnswer);
        Debug.Log("The Players Answer = " + playersAnswer);

        if (playersAnswer == answer)
        {
            nextQuestionButton.SetActive(true);
            answerCorrect.SetActive(true);
        }

        if (playersAnswer != answer)
        {
            answerWrongTimer = 3f;
            answerWrongBool = true;
            answerWrong.SetActive(true);
        }
    }

    public void NextQuestion()
    {
        Debug.Log("Next Question!");

        nextQuestion = Random.Range(1, 4);


        if (nextQuestion == 1)
        {
            SceneManager.LoadScene(1);
        }
        if (nextQuestion == 2)
        {
            SceneManager.LoadScene(2);
        }
        if (nextQuestion >= 3)
        {
            SceneManager.LoadScene(3);
        }
    }
}
