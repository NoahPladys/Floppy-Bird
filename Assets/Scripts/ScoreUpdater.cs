using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreUpdater : MonoBehaviour
{
    void Update()
    {
        gameObject.GetComponent<TMP_Text>().text = StatsManager.GetInstance().Score.ToString();
    }
}
