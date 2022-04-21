using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Slider sliderHealth;


    public float m_MoveSpeed;
    public GameObject RocketPlayer;
    public GameObject m_Projectile;
    public Transform m_FiringPoint;
    [SerializeField] private float m_FiringCooldown;
    private float m_TempCooldown;


    //Ceate Health
    float currentHealth;
    float maxHealth;
    // Start is called before the first frame update
    void Start()
    {
        maxHealth = 100f;
        currentHealth = maxHealth;

        sliderHealth.maxValue = maxHealth;
        sliderHealth.value = currentHealth;

    }

    // Update is called once per frame
    void Update()
    {
        
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector2 direction = new Vector2(horizontal, vertical);
        transform.Translate(direction * Time.deltaTime * m_MoveSpeed);

        if (vertical > 0 || vertical < 0)
        {
            RocketPlayer.SetActive(true);
        }
        else

            RocketPlayer.SetActive(false);


        if (Input.GetKey(KeyCode.Space)) 
        {
            m_TempCooldown = m_TempCooldown - Time.deltaTime;
            if (m_TempCooldown <= 0) 
            {
                Fire();
                m_TempCooldown = m_FiringCooldown;
            }
             
        }
       
    }

    private void Fire()
    {
        Instantiate(m_Projectile, m_FiringPoint.position, Quaternion.identity);
    }


    public void receiveDame(int dame)
    {
        currentHealth -= dame;
        sliderHealth.value = currentHealth;
        if (currentHealth <= 0)
        {
            DeadPlayer();
        }
        Debug.Log(currentHealth);
    }
    public void DeadPlayer()
    {
        Destroy(gameObject);
    }
}
