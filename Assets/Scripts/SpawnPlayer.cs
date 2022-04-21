using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{
    public GameObject PlayerPrefabs;
    public Transform PosSpawnPlayer;
    void Start()
    {
        Instantiate(PlayerPrefabs, PosSpawnPlayer.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
