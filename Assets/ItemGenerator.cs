﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{

    public GameObject carPrefab;
    public GameObject coinPrefab;
    public GameObject conePrefab;

    private int startPos = -160;
    private int goalPos = 120;
    private float posRange = 3.4f;

    private GameObject unitychan;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.unitychan = GameObject.Find("unitychan");
        if (unitychan.transform.position.z > startPos)
        {
            int num = Random.Range(0, 10);
            if (num <= 1)
            {
                for (float j = -1; j <= 1; j += 0.4f)
                {
                    GameObject cone = Instantiate(conePrefab) as GameObject;
                    cone.transform.position = new Vector3(4 * j, cone.transform.position.y, unitychan.transform.position.z + 40);
                }
            }
            else
            {
                for (int j = -1; j < 2; j++)
                {
                    int item = Random.Range(1, 11);
                    int offsetZ = Random.Range(-5, 6);
                    if (1 <= item && item <= 6)
                    {
                        GameObject coin = Instantiate(coinPrefab) as GameObject;
                        coin.transform.position = new Vector3(posRange * j, coin.transform.position.y, unitychan.transform.position.z + 40 + offsetZ);
                    }
                    else if (7 <= item && item <= 9)
                    {
                        GameObject car = Instantiate(carPrefab) as GameObject;
                        car.transform.position = new Vector3(posRange * j, car.transform.position.y, unitychan.transform.position.z + 40 + offsetZ);
                    }
                }
            }
            startPos += 15;
        }
    }
}