using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreScript : MonoBehaviour
{
    public static int scoreValue = 0;
    Text score;

    void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreValue += 1;
        score.text = System.Convert.ToString(scoreValue);
    }
}
