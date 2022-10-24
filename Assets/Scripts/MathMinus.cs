using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MathMinus : MonoBehaviour
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
    public GameObject leftApple;
    public GameObject rightApple;
    public GameObject leftCupcake;
    public GameObject rightCupcake;
    public GameObject leftAppleCheck;
    public GameObject rightAppleCheck;
    public GameObject leftCupcakeCheck;
    public GameObject rightCupcakeCheck;
    public int objectSpawnChoice;
    public float spawnTimerLeft;
    public float spawnTimerRight;
    public int leftObjectCounter;
    public int rightObjectCounter;

    public TextMeshProUGUI leftCupCounterText;
    public TextMeshProUGUI rightCupCounterText;
    public TextMeshProUGUI counterCombinedText;
    public int leftCupCounter;
    public int rightCupCounter;
    public int counterCombined;


    void Start()
    {
        number1 += Random.Range(2, 61);
        Debug.Log("Number1 = " + number1);
        number2 += Random.Range(2, 61);
        Debug.Log("Number2 = " + number2);
        answer = number1 - number2;
        Debug.Log("Answer = " + answer);


        textChoice += Random.Range(1, 3);
        if (textChoice == 1)
        {
            questionText.text = "David has " + number1 + " apples, but lost " + number2 + " from falling over, How many apples does David have now?";
            objectSpawnChoice = 1;
        }
        if (textChoice >= 2)
        {
            questionText.text = "Chris has " + number1 + " cupcakes and gave away " + number2 + " to his visitors, How many cupcakes does Chris have now?";
            objectSpawnChoice = 2;
        }

        mathQuestionText.text = number1 + " - " + number2 + " =";
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

        if (spawnTimerLeft > 0)
        {
            spawnTimerLeft -= Time.deltaTime;
        }
        if (spawnTimerRight > 0)
        {
            spawnTimerRight -= Time.deltaTime;
        }

        if(leftObjectCounter > 0)
        {
            if(objectSpawnChoice == 1)
            {
                leftAppleCheck = GameObject.FindWithTag("Left Apple");
            }
            if (objectSpawnChoice == 2)
            {
                leftCupcakeCheck = GameObject.FindWithTag("Left Cupcake");
            }
        }
        if (rightObjectCounter > 0)
        {
            if (objectSpawnChoice == 1)
            {
                rightAppleCheck = GameObject.FindWithTag("Right Apple");
            }
            if (objectSpawnChoice == 2)
            {
                rightCupcakeCheck = GameObject.FindWithTag("Right Cupcake");
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
        if (spawnTimerLeft <=0 && leftCupCounter < 60)
        {
            if (objectSpawnChoice == 1)
            {
                Instantiate(leftApple, leftCup);
                spawnTimerLeft = 0.3f;
                leftCupCounter += 1;
                counterCombined = leftCupCounter - rightCupCounter;
                leftCupCounterText.text = leftCupCounter.ToString("0");
                counterCombinedText.text = counterCombined.ToString("0");
            }
            if (objectSpawnChoice == 2)
            {
                Instantiate(leftCupcake, leftCup);
                spawnTimerLeft = 0.3f;
                leftCupCounter += 1;
                counterCombined = leftCupCounter - rightCupCounter;
                leftCupCounterText.text = leftCupCounter.ToString("0");
                counterCombinedText.text = counterCombined.ToString("0");
            }
        }
    }

    public void RightSpawn()
    {
        if (spawnTimerRight <= 0 && rightCupCounter < 60)
        {
            if (objectSpawnChoice == 1)
            {
                Instantiate(rightApple, rightCup);
                spawnTimerRight = 0.3f;
                rightCupCounter += 1;
                counterCombined = leftCupCounter - rightCupCounter;
                rightCupCounterText.text = rightCupCounter.ToString("0");
                counterCombinedText.text = counterCombined.ToString("0");
            }
            if (objectSpawnChoice == 2)
            {
                Instantiate(rightCupcake, rightCup);
                spawnTimerRight = 0.3f;
                rightCupCounter += 1;
                counterCombined = leftCupCounter - rightCupCounter;
                rightCupCounterText.text = rightCupCounter.ToString("0");
                counterCombinedText.text = counterCombined.ToString("0");
            }
        }
    }

    public void LeftDespawn()
    {
        if (objectSpawnChoice == 1 && leftCupCounter > 0)
        {
            leftAppleCheck = GameObject.FindWithTag("Left Apple");
            Destroy(leftAppleCheck);
            leftCupCounter -= 1;
            counterCombined = leftCupCounter - rightCupCounter;
            leftCupCounterText.text = leftCupCounter.ToString("0");
            counterCombinedText.text = counterCombined.ToString("0");
        }
        if (objectSpawnChoice == 2 && leftCupCounter > 0)
        {
            leftCupcakeCheck = GameObject.FindWithTag("Left Cupcake");
            Destroy(leftCupcakeCheck);
            leftCupCounter -= 1;
            counterCombined = leftCupCounter - rightCupCounter;
            leftCupCounterText.text = leftCupCounter.ToString("0");
            counterCombinedText.text = counterCombined.ToString("0");
        }
    }
    public void RightDespawn()
    {
        if (objectSpawnChoice == 1 && rightCupCounter > 0)
        {
            rightAppleCheck = GameObject.FindWithTag("Right Apple");
            Destroy(rightAppleCheck);
            rightCupCounter -= 1;
            counterCombined = leftCupCounter - rightCupCounter;
            rightCupCounterText.text = rightCupCounter.ToString("0");
            counterCombinedText.text = counterCombined.ToString("0");
        }
        if (objectSpawnChoice == 2 && rightCupCounter > 0)
        {
            rightCupcakeCheck = GameObject.FindWithTag("Right Cupcake");
            Destroy(rightCupcakeCheck);
            rightCupCounter -= 1;
            counterCombined = leftCupCounter - rightCupCounter;
            rightCupCounterText.text = rightCupCounter.ToString("0");
            counterCombinedText.text = counterCombined.ToString("0");
        }
    }
}
