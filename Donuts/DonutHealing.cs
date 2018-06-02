using UnityEngine;
using System.Collections;

public class DonutHealing : MonoBehaviour
{
    public int RecoverLife = 30;
    DonutManager donutManager;
    Animator anim;
    GameObject player;
    PlayerHealth playerHealth;
    bool playerInRange;
    float timer;


    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<PlayerHealth>();
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            playerHealth.RecoverLife(RecoverLife);
        }
    }

}




