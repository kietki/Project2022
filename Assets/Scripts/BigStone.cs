using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneScripts : MonoBehaviour
{
    public float m_MoveSpeed;
    public Vector2 velocity;

    Vector3 rotationBullet = new Vector3(0, 0, 180);


    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 7f);


    }

    // Update is called once per frame
    void Update()
    {
        this.velocity = Vector2.down * m_MoveSpeed * Time.deltaTime;
        transform.Translate(velocity);
    }

     
}
