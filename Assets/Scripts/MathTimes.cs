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

    public Transform cup1;
    public Transform cup2;
    public Transform cup3;
    public Transform cup4;
    public Transform cup5;
    public Transform cup6;
    public Transform cup7;
    public Transform cup8;
    public Transform cup9;
    public Transform cup10;
    public Transform cup11;
    public Transform cup12;
    public GameObject apple1;
    public GameObject apple2;
    public GameObject apple3;
    public GameObject apple4;
    public GameObject apple5;
    public GameObject apple6;
    public GameObject apple7;
    public GameObject apple8;
    public GameObject apple9;
    public GameObject apple10;
    public GameObject apple11;
    public GameObject apple12;

    public GameObject apple1Check;
    public GameObject apple2Check;
    public GameObject apple3Check;
    public GameObject apple4Check;
    public GameObject apple5Check;
    public GameObject apple6Check;
    public GameObject apple7Check;
    public GameObject apple8Check;
    public GameObject apple9Check;
    public GameObject apple10Check;
    public GameObject apple11Check;
    public GameObject apple12Check;


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
        number1 += Random.Range(2, 13);
        Debug.Log("Number1 = " + number1);
        number2 += Random.Range(2, 13);
        Debug.Log("Number2 = " + number2);
        answer = number1 * number2;
        Debug.Log("Answer = " + answer);

        leftCupCounter = number1;
        counterCombined = leftCupCounter * rightCupCounter;
        leftCupCounterText.text = leftCupCounter.ToString("0");
        counterCombinedText.text = counterCombined.ToString("0");

        textChoice += Random.Range(1, 2);
        if (textChoice >= 1)
        {
            questionText.text = "Kate has " + number2 + " apples, and collected " + number1 + " times what she had, How many apples does Kate have now?";
            objectSpawnChoice = 1;
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

        if (spawnTimerLeft > 0)
        {
            spawnTimerLeft -= Time.deltaTime;
        }
        if (spawnTimerRight > 0)
        {
            spawnTimerRight -= Time.deltaTime;
        }

        if (leftObjectCounter > 0)
        {
            if (objectSpawnChoice == 1)
            {
                apple1Check = GameObject.FindWithTag("Apple1");
            }
            if (objectSpawnChoice == 1)
            {
                apple2Check = GameObject.FindWithTag("Apple2");
            }
            if (objectSpawnChoice == 1)
            {
                apple3Check = GameObject.FindWithTag("Apple3");
            }
            if (objectSpawnChoice == 1)
            {
                apple4Check = GameObject.FindWithTag("Apple4");
            }
            if (objectSpawnChoice == 1)
            {
                apple5Check = GameObject.FindWithTag("Apple5");
            }
            if (objectSpawnChoice == 1)
            {
                apple6Check = GameObject.FindWithTag("Apple6");
            }
            if (objectSpawnChoice == 1)
            {
                apple7Check = GameObject.FindWithTag("Apple7");
            }
            if (objectSpawnChoice == 1)
            {
                apple8Check = GameObject.FindWithTag("Apple8");
            }
            if (objectSpawnChoice == 1)
            {
                apple9Check = GameObject.FindWithTag("Apple9");
            }
            if (objectSpawnChoice == 1)
            {
                apple10Check = GameObject.FindWithTag("Apple10");
            }
            if (objectSpawnChoice == 1)
            {
                apple11Check = GameObject.FindWithTag("Apple11");
            }
            if (objectSpawnChoice == 1)
            {
                apple12Check = GameObject.FindWithTag("Apple12");
            }

        }


        if (leftCupCounter == 1 && rightCupCounter == 1)
        {

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
    #region spawn
    public void Spawn()
    {
        if (spawnTimerLeft <= 0 && rightCupCounter < 12)
        {
            if (objectSpawnChoice == 1 && number1 == 2)
            {


                Instantiate(apple1, cup1);
                Instantiate(apple2, cup2);
                spawnTimerLeft = 0.3f;
                rightCupCounter += 1;
                counterCombined = leftCupCounter * rightCupCounter;
                rightCupCounterText.text = rightCupCounter.ToString("0");
                counterCombinedText.text = counterCombined.ToString("0");
            }
            if (objectSpawnChoice == 1 && number1 == 3)
            {


                Instantiate(apple1, cup1);
                Instantiate(apple2, cup2);
                Instantiate(apple3, cup3);
                spawnTimerLeft = 0.3f;
                rightCupCounter += 1;
                counterCombined = leftCupCounter * rightCupCounter;
                rightCupCounterText.text = rightCupCounter.ToString("0");
                counterCombinedText.text = counterCombined.ToString("0");
            }
            if (objectSpawnChoice == 1 && number1 == 4)
            {


                Instantiate(apple1, cup1);
                Instantiate(apple2, cup2);
                Instantiate(apple3, cup3);
                Instantiate(apple4, cup4);
                spawnTimerLeft = 0.3f;
                rightCupCounter += 1;
                counterCombined = leftCupCounter * rightCupCounter;
                rightCupCounterText.text = rightCupCounter.ToString("0");
                counterCombinedText.text = counterCombined.ToString("0");
            }
            if (objectSpawnChoice == 1 && number1 == 5)
            {


                Instantiate(apple1, cup1);
                Instantiate(apple2, cup2);
                Instantiate(apple3, cup3);
                Instantiate(apple4, cup4);
                Instantiate(apple5, cup5);
                spawnTimerLeft = 0.3f;
                rightCupCounter += 1;
                counterCombined = leftCupCounter * rightCupCounter;
                rightCupCounterText.text = rightCupCounter.ToString("0");
                counterCombinedText.text = counterCombined.ToString("0");
            }
            if (objectSpawnChoice == 1 && number1 == 6)
            {


                Instantiate(apple1, cup1);
                Instantiate(apple2, cup2);
                Instantiate(apple3, cup3);
                Instantiate(apple4, cup4);
                Instantiate(apple5, cup5);
                Instantiate(apple6, cup6);
                spawnTimerLeft = 0.3f;
                rightCupCounter += 1;
                counterCombined = leftCupCounter * rightCupCounter;
                rightCupCounterText.text = rightCupCounter.ToString("0");
                counterCombinedText.text = counterCombined.ToString("0");
            }
            if (objectSpawnChoice == 1 && number1 == 7)
            {


                Instantiate(apple1, cup1);
                Instantiate(apple2, cup2);
                Instantiate(apple3, cup3);
                Instantiate(apple4, cup4);
                Instantiate(apple5, cup5);
                Instantiate(apple6, cup6);
                Instantiate(apple7, cup7);
                spawnTimerLeft = 0.3f;
                rightCupCounter += 1;
                counterCombined = leftCupCounter * rightCupCounter;
                rightCupCounterText.text = rightCupCounter.ToString("0");
                counterCombinedText.text = counterCombined.ToString("0");
            }
            if (objectSpawnChoice == 1 && number1 == 8)
            {


                Instantiate(apple1, cup1);
                Instantiate(apple2, cup2);
                Instantiate(apple3, cup3);
                Instantiate(apple4, cup4);
                Instantiate(apple5, cup5);
                Instantiate(apple6, cup6);
                Instantiate(apple7, cup7);
                Instantiate(apple8, cup8);
                spawnTimerLeft = 0.3f;
                rightCupCounter += 1;
                counterCombined = leftCupCounter * rightCupCounter;
                rightCupCounterText.text = rightCupCounter.ToString("0");
                counterCombinedText.text = counterCombined.ToString("0");
            }
            if (objectSpawnChoice == 1 && number1 == 9)
            {


                Instantiate(apple1, cup1);
                Instantiate(apple2, cup2);
                Instantiate(apple3, cup3);
                Instantiate(apple4, cup4);
                Instantiate(apple5, cup5);
                Instantiate(apple6, cup6);
                Instantiate(apple7, cup7);
                Instantiate(apple8, cup8);
                Instantiate(apple9, cup9);
                spawnTimerLeft = 0.3f;
                rightCupCounter += 1;
                counterCombined = leftCupCounter * rightCupCounter;
                rightCupCounterText.text = rightCupCounter.ToString("0");
                counterCombinedText.text = counterCombined.ToString("0");
            }
            if (objectSpawnChoice == 1 && number1 == 10)
            {


                Instantiate(apple1, cup1);
                Instantiate(apple2, cup2);
                Instantiate(apple3, cup3);
                Instantiate(apple4, cup4);
                Instantiate(apple5, cup5);
                Instantiate(apple6, cup6);
                Instantiate(apple7, cup7);
                Instantiate(apple8, cup8);
                Instantiate(apple9, cup9);
                Instantiate(apple10, cup10);
                spawnTimerLeft = 0.3f;
                rightCupCounter += 1;
                counterCombined = leftCupCounter * rightCupCounter;
                rightCupCounterText.text = rightCupCounter.ToString("0");
                counterCombinedText.text = counterCombined.ToString("0");
            }
            if (objectSpawnChoice == 1 && number1 == 11)
            {


                Instantiate(apple1, cup1);
                Instantiate(apple2, cup2);
                Instantiate(apple3, cup3);
                Instantiate(apple4, cup4);
                Instantiate(apple5, cup5);
                Instantiate(apple6, cup6);
                Instantiate(apple7, cup7);
                Instantiate(apple8, cup8);
                Instantiate(apple9, cup9);
                Instantiate(apple10, cup10);
                Instantiate(apple11, cup11);
                spawnTimerLeft = 0.3f;
                rightCupCounter += 1;
                counterCombined = leftCupCounter * rightCupCounter;
                rightCupCounterText.text = rightCupCounter.ToString("0");
                counterCombinedText.text = counterCombined.ToString("0");
            }
            if (objectSpawnChoice == 1 && number1 == 12)
            {


                Instantiate(apple1, cup1);
                Instantiate(apple2, cup2);
                Instantiate(apple3, cup3);
                Instantiate(apple4, cup4);
                Instantiate(apple5, cup5);
                Instantiate(apple6, cup6);
                Instantiate(apple7, cup7);
                Instantiate(apple8, cup8);
                Instantiate(apple9, cup9);
                Instantiate(apple10, cup10);
                Instantiate(apple11, cup11);
                Instantiate(apple12, cup12);
                spawnTimerLeft = 0.3f;
                rightCupCounter += 1;
                counterCombined = leftCupCounter * rightCupCounter;
                rightCupCounterText.text = rightCupCounter.ToString("0");
                counterCombinedText.text = counterCombined.ToString("0");
            }


        }
    }
    #endregion


    public void Despawn()
    {
        if (objectSpawnChoice == 1 && rightCupCounter > 0 && number1 == 2)
        {
            apple1Check = GameObject.FindWithTag("Apple1");
            Destroy(apple1Check);
            apple2Check = GameObject.FindWithTag("Apple2");
            Destroy(apple2Check);
            rightCupCounter -= 1;
            counterCombined = leftCupCounter * rightCupCounter;
            rightCupCounterText.text = rightCupCounter.ToString("0");
            counterCombinedText.text = counterCombined.ToString("0");
        }
        if (objectSpawnChoice == 1 && rightCupCounter > 0 && number1 == 3)
        {
            apple1Check = GameObject.FindWithTag("Apple1");
            Destroy(apple1Check);
            apple2Check = GameObject.FindWithTag("Apple2");
            Destroy(apple2Check);
            apple3Check = GameObject.FindWithTag("Apple3");
            Destroy(apple3Check);
            rightCupCounter -= 1;
            counterCombined = leftCupCounter * rightCupCounter;
            rightCupCounterText.text = rightCupCounter.ToString("0");
            counterCombinedText.text = counterCombined.ToString("0");
        }
        if (objectSpawnChoice == 1 && rightCupCounter > 0 && number1 == 4)
        {
            apple1Check = GameObject.FindWithTag("Apple1");
            Destroy(apple1Check);
            apple2Check = GameObject.FindWithTag("Apple2");
            Destroy(apple2Check);
            apple3Check = GameObject.FindWithTag("Apple3");
            Destroy(apple3Check);
            apple4Check = GameObject.FindWithTag("Apple4");
            Destroy(apple4Check);
            rightCupCounter -= 1;
            counterCombined = leftCupCounter * rightCupCounter;
            rightCupCounterText.text = rightCupCounter.ToString("0");
            counterCombinedText.text = counterCombined.ToString("0");
        }
        if (objectSpawnChoice == 1 && rightCupCounter > 0 && number1 == 5)
        {
            apple1Check = GameObject.FindWithTag("Apple1");
            Destroy(apple1Check);
            apple2Check = GameObject.FindWithTag("Apple2");
            Destroy(apple2Check);
            apple3Check = GameObject.FindWithTag("Apple3");
            Destroy(apple3Check);
            apple4Check = GameObject.FindWithTag("Apple4");
            Destroy(apple4Check);
            apple5Check = GameObject.FindWithTag("Apple5");
            Destroy(apple5Check);
            rightCupCounter -= 1;
            counterCombined = leftCupCounter * rightCupCounter;
            rightCupCounterText.text = rightCupCounter.ToString("0");
            counterCombinedText.text = counterCombined.ToString("0");
        }
        if (objectSpawnChoice == 1 && rightCupCounter > 0 && number1 == 6)
        {
            apple1Check = GameObject.FindWithTag("Apple1");
            Destroy(apple1Check);
            apple2Check = GameObject.FindWithTag("Apple2");
            Destroy(apple2Check);
            apple3Check = GameObject.FindWithTag("Apple3");
            Destroy(apple3Check);
            apple4Check = GameObject.FindWithTag("Apple4");
            Destroy(apple4Check);
            apple5Check = GameObject.FindWithTag("Apple5");
            Destroy(apple5Check);
            apple6Check = GameObject.FindWithTag("Apple6");
            Destroy(apple6Check);
            rightCupCounter -= 1;
            counterCombined = leftCupCounter * rightCupCounter;
            rightCupCounterText.text = rightCupCounter.ToString("0");
            counterCombinedText.text = counterCombined.ToString("0");
        }
        if (objectSpawnChoice == 1 && rightCupCounter > 0 && number1 == 7)
        {
            apple1Check = GameObject.FindWithTag("Apple1");
            Destroy(apple1Check);
            apple2Check = GameObject.FindWithTag("Apple2");
            Destroy(apple2Check);
            apple3Check = GameObject.FindWithTag("Apple3");
            Destroy(apple3Check);
            apple4Check = GameObject.FindWithTag("Apple4");
            Destroy(apple4Check);
            apple5Check = GameObject.FindWithTag("Apple5");
            Destroy(apple5Check);
            apple6Check = GameObject.FindWithTag("Apple6");
            Destroy(apple6Check);
            apple7Check = GameObject.FindWithTag("Apple7");
            Destroy(apple7Check);
            rightCupCounter -= 1;
            counterCombined = leftCupCounter * rightCupCounter;
            rightCupCounterText.text = rightCupCounter.ToString("0");
            counterCombinedText.text = counterCombined.ToString("0");
        }
        if (objectSpawnChoice == 1 && rightCupCounter > 0 && number1 == 8)
        {
            apple1Check = GameObject.FindWithTag("Apple1");
            Destroy(apple1Check);
            apple2Check = GameObject.FindWithTag("Apple2");
            Destroy(apple2Check);
            apple3Check = GameObject.FindWithTag("Apple3");
            Destroy(apple3Check);
            apple4Check = GameObject.FindWithTag("Apple4");
            Destroy(apple4Check);
            apple5Check = GameObject.FindWithTag("Apple5");
            Destroy(apple5Check);
            apple6Check = GameObject.FindWithTag("Apple6");
            Destroy(apple6Check);
            apple7Check = GameObject.FindWithTag("Apple7");
            Destroy(apple7Check);
            apple8Check = GameObject.FindWithTag("Apple8");
            Destroy(apple8Check);
            rightCupCounter -= 1;
            counterCombined = leftCupCounter * rightCupCounter;
            rightCupCounterText.text = rightCupCounter.ToString("0");
            counterCombinedText.text = counterCombined.ToString("0");
        }
        if (objectSpawnChoice == 1 && rightCupCounter > 0 && number1 == 9)
        {
            apple1Check = GameObject.FindWithTag("Apple1");
            Destroy(apple1Check);
            apple2Check = GameObject.FindWithTag("Apple2");
            Destroy(apple2Check);
            apple3Check = GameObject.FindWithTag("Apple3");
            Destroy(apple3Check);
            apple4Check = GameObject.FindWithTag("Apple4");
            Destroy(apple4Check);
            apple5Check = GameObject.FindWithTag("Apple5");
            Destroy(apple5Check);
            apple6Check = GameObject.FindWithTag("Apple6");
            Destroy(apple6Check);
            apple7Check = GameObject.FindWithTag("Apple7");
            Destroy(apple7Check);
            apple8Check = GameObject.FindWithTag("Apple8");
            Destroy(apple8Check);
            apple9Check = GameObject.FindWithTag("Apple9");
            Destroy(apple9Check);
            rightCupCounter -= 1;
            counterCombined = leftCupCounter * rightCupCounter;
            rightCupCounterText.text = rightCupCounter.ToString("0");
            counterCombinedText.text = counterCombined.ToString("0");
        }
        if (objectSpawnChoice == 1 && rightCupCounter > 0 && number1 == 10)
        {
            apple1Check = GameObject.FindWithTag("Apple1");
            Destroy(apple1Check);
            apple2Check = GameObject.FindWithTag("Apple2");
            Destroy(apple2Check);
            apple3Check = GameObject.FindWithTag("Apple3");
            Destroy(apple3Check);
            apple4Check = GameObject.FindWithTag("Apple4");
            Destroy(apple4Check);
            apple5Check = GameObject.FindWithTag("Apple5");
            Destroy(apple5Check);
            apple6Check = GameObject.FindWithTag("Apple6");
            Destroy(apple6Check);
            apple7Check = GameObject.FindWithTag("Apple7");
            Destroy(apple7Check);
            apple8Check = GameObject.FindWithTag("Apple8");
            Destroy(apple8Check);
            apple9Check = GameObject.FindWithTag("Apple9");
            Destroy(apple9Check);
            apple10Check = GameObject.FindWithTag("Apple10");
            Destroy(apple10Check);
            rightCupCounter -= 1;
            counterCombined = leftCupCounter * rightCupCounter;
            rightCupCounterText.text = rightCupCounter.ToString("0");
            counterCombinedText.text = counterCombined.ToString("0");
        }
        if (objectSpawnChoice == 1 && rightCupCounter > 0 && number1 == 11)
        {
            apple1Check = GameObject.FindWithTag("Apple1");
            Destroy(apple1Check);
            apple2Check = GameObject.FindWithTag("Apple2");
            Destroy(apple2Check);
            apple3Check = GameObject.FindWithTag("Apple3");
            Destroy(apple3Check);
            apple4Check = GameObject.FindWithTag("Apple4");
            Destroy(apple4Check);
            apple5Check = GameObject.FindWithTag("Apple5");
            Destroy(apple5Check);
            apple6Check = GameObject.FindWithTag("Apple6");
            Destroy(apple6Check);
            apple7Check = GameObject.FindWithTag("Apple7");
            Destroy(apple7Check);
            apple8Check = GameObject.FindWithTag("Apple8");
            Destroy(apple8Check);
            apple9Check = GameObject.FindWithTag("Apple9");
            Destroy(apple9Check);
            apple10Check = GameObject.FindWithTag("Apple10");
            Destroy(apple10Check);
            apple11Check = GameObject.FindWithTag("Apple11");
            Destroy(apple11Check);
            rightCupCounter -= 1;
            counterCombined = leftCupCounter * rightCupCounter;
            rightCupCounterText.text = rightCupCounter.ToString("0");
            counterCombinedText.text = counterCombined.ToString("0");
        }
        if (objectSpawnChoice == 1 && rightCupCounter > 0 && number1 == 12)
        {
            apple1Check = GameObject.FindWithTag("Apple1");
            Destroy(apple1Check);
            apple2Check = GameObject.FindWithTag("Apple2");
            Destroy(apple2Check);
            apple3Check = GameObject.FindWithTag("Apple3");
            Destroy(apple3Check);
            apple4Check = GameObject.FindWithTag("Apple4");
            Destroy(apple4Check);
            apple5Check = GameObject.FindWithTag("Apple5");
            Destroy(apple5Check);
            apple6Check = GameObject.FindWithTag("Apple6");
            Destroy(apple6Check);
            apple7Check = GameObject.FindWithTag("Apple7");
            Destroy(apple7Check);
            apple8Check = GameObject.FindWithTag("Apple8");
            Destroy(apple8Check);
            apple9Check = GameObject.FindWithTag("Apple9");
            Destroy(apple9Check);
            apple10Check = GameObject.FindWithTag("Apple10");
            Destroy(apple10Check);
            apple11Check = GameObject.FindWithTag("Apple11");
            Destroy(apple11Check);
            apple12Check = GameObject.FindWithTag("Apple12");
            Destroy(apple12Check);
            rightCupCounter -= 1;
            counterCombined = leftCupCounter * rightCupCounter;
            rightCupCounterText.text = rightCupCounter.ToString("0");
            counterCombinedText.text = counterCombined.ToString("0");
        }

    }


}
