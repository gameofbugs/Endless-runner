using UnityEngine;

public class ObstacleMover : MonoBehaviour
{
    private float obstacleObject = 5f;
   
    void Update()
    {
        transform.Translate(Vector2.left * obstacleObject * Time.deltaTime);
        if (transform.position.x <=-20f)
        {
            Destroy(gameObject);
        }
    }
   
}
