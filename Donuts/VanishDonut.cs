using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class VanishDonut : MonoBehaviour
{

    GameObject player;
    void Awake()
    {
        player = GameObject.Find("Player");
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            Destroy(gameObject);

        }
    }
}
