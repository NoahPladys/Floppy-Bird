using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubePassedTrigger : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider)
    {
        StatsManager sm = StatsManager.GetInstance();
        if (collider.gameObject.tag == "Player" && sm.IsPlaying)
            sm.Score++;
    }
}
