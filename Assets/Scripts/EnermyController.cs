using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnermyController : MonoBehaviour
{
    public float m_MoveSpeed;
    public Transform[] m_WayPoints;

    private int m_CurrenlWayPoinlIndex;


    public Transform posGun;
    public GameObject BulletPrebs;

    float timer;
    public float timeDuration;
    // Start is called before the first frame update
    void Start()
    {
        timeDuration = Random.Range(0.5f, 2f);
        timer = timeDuration;
    }

    // Update is called once per frame
    void Update()
    {
        int nextWayPoint = m_CurrenlWayPoinlIndex + 1;
        if (nextWayPoint > m_WayPoints.Length - 1)
            nextWayPoint = 0;
        transform.position = Vector3.MoveTowards(transform.position, m_WayPoints[nextWayPoint].position, m_MoveSpeed * Time.deltaTime);
        if (transform.position == m_WayPoints[nextWayPoint].position)
            m_CurrenlWayPoinlIndex = nextWayPoint;


        SpawnBullet();
    }

    public void SpawnBullet()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Instantiate(BulletPrebs, posGun.position, Quaternion.identity);
            timer = timeDuration;
        }    
        
    }
     
}
