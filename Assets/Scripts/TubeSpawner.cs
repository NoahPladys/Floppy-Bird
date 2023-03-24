using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubeSpawner : MonoBehaviour
{
    public GameObject Tubes;
    public float TimeBetweenTubes = 2.0f;
    public float HeightOffsets = 2.0f;
    private float timeSinceLastTube;

    void Update()
    {
        if(StatsManager.GetInstance().Tubes)
        {
            timeSinceLastTube += Time.deltaTime;
            if (timeSinceLastTube > TimeBetweenTubes)
            {
                timeSinceLastTube -= TimeBetweenTubes;
                Instantiate(Tubes, transform.position + (Vector3.up * randomTubeHeightOffset()), transform.rotation);
            }
        }
    }

    private float randomTubeHeightOffset()
    {
        return Random.Range(-HeightOffsets, HeightOffsets);
    }
}
