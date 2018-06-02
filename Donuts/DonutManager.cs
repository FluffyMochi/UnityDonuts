using UnityEngine;

public class DonutManager : MonoBehaviour
{
    public PlayerHealth playerHealth;       // Reference to the player's heatlh.
    public GameObject donut;                // The enemy prefab to be spawned.
    public float spawnTime = 5f;            // How long between each spawn.
    public Transform[] donutSpawnPoints;         // An array of the spawn points this enemy can spawn from.

    void Start()
    {
        // Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }


    void Spawn()
    {
        Vector3 randomVector = new Vector3(Random.Range(-30.0f, 30.0f), Random.Range(2.0f, 2.0f), Random.Range(-30.0f, 30.0f));


        // If the player has no health left...
        if (playerHealth.currentHealth <= 0f)
        {
            // ... exit the function.
            return;
        }
        // Find a random index between zero and one less than the number of spawn points.
        int donutSpawnPointIndex = Random.Range(0, donutSpawnPoints.Length);

        // Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
        Instantiate(donut, randomVector, Random.rotation);
    }

}