using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    public PlayerHealth playerHealth;


    void Update()
    {
        if (playerHealth.currentHealth <= 0)
        {
            GetComponent<Animator>().SetTrigger("GameOver");
        }
    }
}
