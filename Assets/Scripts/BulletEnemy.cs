using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy : MonoBehaviour
{
    public float m_MoveSpeed;
    public Vector2 velocity;
    public GameObject RocketPlayer;
    Vector3 rotationBullet = new Vector3(0, 0, 180);

    

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 3f);
        transform.Rotate(rotationBullet);
    }

    // Update is called once per frame
    void Update()
    {
        this.velocity = Vector2.down * m_MoveSpeed * Time.deltaTime;
        transform.Translate(velocity);
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerController hitPlayer = collision.gameObject.GetComponent<PlayerController>();
            hitPlayer.receiveDame(10);
            Destroy(gameObject);
        }
    }


}
