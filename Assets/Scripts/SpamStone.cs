using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpamStone : MonoBehaviour
{

    public GameObject stonePrefab;
    public GameObject bigStonePrefab;

    float timer;
    public float timeDuration;
    // Start is called before the first frame update
    void Start()
    {
        timeDuration = Random.Range(3f,10f);
        timer = timeDuration;
    }

    // Update is called once per frame
    void Update()
    {
        SpawnStone();
    }
    public void SpawnStone()
    {
        float randXpos = Random.Range(-9f, 9f);
        Vector2 spawn = new Vector2(randXpos, 7f);

        timer -= Time.deltaTime;
        if (timer <= 0) {
            Instantiate(stonePrefab, spawn, Quaternion.identity);
            timer = timeDuration;
        }

        float randXposBig = Random.Range(-9f, 9f);
        Vector2 spawnBig = new Vector2(randXpos, 7f);

        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Instantiate(bigStonePrefab, spawn, Quaternion.identity);
            timer = timeDuration;
        }
    }
}
