using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubeBehaviour : MonoBehaviour
{
    public float Speed = 5.0f;
    public GameObject Player;
    private int despawnRange = 10;

    void Update()
    {
        if(StatsManager.GetInstance().Tubes)
        {
            transform.position += (Vector3.left * Speed) * Time.deltaTime;

            if (Player.transform.position.x - transform.position.x > despawnRange)
            {
                Destroy(gameObject);
            }
        }
    }
}
