using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    private Text scoreText;
    public static int score = 0;
    
    public static void AddScore(int value)
    {
        score += value;
    }
}
