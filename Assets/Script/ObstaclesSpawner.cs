using UnityEngine;

public class ObstaclesSpawner : MonoBehaviour
{
    public GameObject[] obstaclesPrefabs;
    private float timer;
    public Transform spawnPoint;
    public float spawnInterval = 100f;

    void Start()
    {
        ObstaclesSpawn();
    }
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            ObstaclesSpawn();
            timer = 0;
        }
    }
   void ObstaclesSpawn()
    {
        int randomIndex = Random.Range(0, obstaclesPrefabs.Length);
        GameObject obstacle = Instantiate(obstaclesPrefabs[randomIndex], spawnPoint.position, Quaternion.identity);
        obstacle.AddComponent<ObstacleMover>();
    }
}

