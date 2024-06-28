using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeadScore : MonoBehaviour
{
    public Text deadScoreText;


    void Update()
    {
        deadScoreText.text = "" + ScoreManager.score;
    }
}
