using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L1AnswerScript : MonoBehaviour
{
    public bool isCorrect = false;
    public L1QuizManager quizManager;

    void Awake()
    {
        // Move the FindObjectOfType call here
        quizManager = FindObjectOfType<L1QuizManager>();
    }

    public void Answer()
    {
        if (isCorrect)
        {
            Debug.Log("Correct Answer");
            quizManager.correct();
        }
        else
        {
            Debug.Log("Wrong Answer");
            quizManager.correct();
        }

        quizManager.questionCanvas.SetActive(false);

        Time.timeScale = 1f;

        quizManager.StartQuestionRound();

    }
}