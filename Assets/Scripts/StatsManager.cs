using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsManager : MonoBehaviour
{
    private static StatsManager instance;
    private int score;
    private int highScore;
    public bool IsPlaying { get; set; } = true;
    public bool Tubes { get; set; } = false;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public static StatsManager GetInstance()
    {
        return instance;
    }

    public int Score
    {
        get { return score; }
        set
        {
            score = value;
            if (score > highScore)
            {
                highScore = score;
            }
        }
    }

    public int HighScore
    {
        get { return highScore; }
    }
}
