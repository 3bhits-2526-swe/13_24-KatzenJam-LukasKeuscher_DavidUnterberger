using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    public int cost;

    public int coleIncrease;

    public float timeBTWINcreases;
    private float nextIncreaseTime;

    private GameManager gm;

    private void Update()
    {
        if(Time.time > nextIncreaseTime)
        {
            nextIncreaseTime = Time.time + timeBTWINcreases;
            gm.cole += coleIncrease;
        }
    }
}
