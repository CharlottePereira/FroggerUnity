using UnityEngine;

public class CarSpawner : MonoBehaviour
{

    public int size = 1;
    public Vector2 direction = Vector2.right;
    public float speed = 1f;
    private Vector3 leftEdge;
    private Vector3 rightEdge;


    private void Start()
    {
        leftEdge = Camera.main.ViewportToWorldPoint(Vector3.zero);
        rightEdge = Camera.main.ViewportToWorldPoint(Vector3.right);
    }

    private void Update()
    {
        if(direction.x > 0 && (transform.position.x - size) > rightEdge.x)
        {
            Vector3 position = transform.position;
            position.x = leftEdge.x - size;
            transform.position = position;
        }

        else if ( direction.x < 0 && (transform.position.x + size) < leftEdge.x)
        {
            Vector3 position = transform.position;
            position.x = rightEdge.x + size;
            transform.position = position;
        }

        else
        {
            transform.Translate(direction * speed * Time.deltaTime);
        }
    }










    /* public float spawnDelay = .3f;

     public GameObject car;

     public Transform[] spawnPoints;

     float nextTimeToSpawn = 0f;

     void Update()
     {
         if (nextTimeToSpawn <= Time.time)
         {
             SpawnCar();
             nextTimeToSpawn = Time.time + spawnDelay;
         }
     }

     void SpawnCar()
     {
         int randomIndex = Random.Range(0, spawnPoints.Length);
         Transform spawnPoint = spawnPoints[randomIndex];

         Instantiate(car, spawnPoint.position, spawnPoint.rotation);
     }
     */
}