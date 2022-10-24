using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MathTimes : MonoBehaviour
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

    public Transform leftCup;
    public Transform rightCup;

    public GameObject apple;
    public GameObject dollar;
    public GameObject cupcake;


    void Start()
    {
        number1 += Random.Range(2, 13);
        Debug.Log("Number1 = " + number1);
        number2 += Random.Range(2, 13);
        Debug.Log("Number2 = " + number2);
        answer = number1 * number2;
        Debug.Log("Answer = " + answer);


        textChoice += Random.Range(1, 4);
        if (textChoice == 1)
        {
            questionText.text = "Kate has " + number1 + " apples, and collected " + number2 + " times what she had, How many apples does Kate have now?";
        }
        if (textChoice == 2)
        {
            questionText.text = "Terry has " + number1 + " cupcakes and made " + number2 + " times more for his visitors, How many cupcakes does Terry have now?";
        }
        if (textChoice >= 3)
        {
            questionText.text = "Olivia has " + number1 + " dollars and was promised " + number2 + " times what he saved up, How much money does Olivia have now?";
        }

        mathQuestionText.text = number1 + " x " + number2 + " =";
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

    public void LeftSpawn()
    {
        Instantiate(apple, leftCup);
    }

}
