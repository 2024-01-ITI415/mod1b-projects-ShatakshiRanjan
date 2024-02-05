using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatTracker : MonoBehaviour
{
    [SerializeField] Text scoreText;
    int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }
    public void AddScore(int scoreArg)
    {
        score += scoreArg;
    }
}
