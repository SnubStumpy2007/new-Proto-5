using UnityEngine;

public class Targets : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private Rigidbody targetRB;
    public GameManager gameManager;
    private float minSpeed = 12;
    private float maxSpeed = 16;
    private float maxTorque = 10;
    private float xRange = 4;
    private float ySpawnPos = -2;

    public int pointValue;
    public ParticleSystem explosionParticle;
    
    void Start()
    {
        targetRB = GetComponent<Rigidbody>();
        targetRB.AddForce(RandomForce(), ForceMode.Impulse);
        targetRB.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse);
        transform.position = RandomSpawnPoint();

        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        //testing to see if it calls.  It doesn't
        //gameManager.GameOver();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (gameManager.isGameActive)
        {
            Destroy(gameObject);
            //gameManager.UpdateScore(pointValue);
            Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);
            if (gameObject.CompareTag("Bad"))
            {
                gameManager.GameOver();
            }
            else
            {
                gameManager.UpdateScore(pointValue);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log($"{gameObject.name} hit the trigger.  Tag = {gameObject.tag}");
        Destroy(gameObject);
        if (!gameObject.CompareTag("Bad"))
        {
            gameManager.GameOver();
        }
    }

    Vector3 RandomForce()
    {
        return Vector3.up * Random.Range(minSpeed, maxSpeed);
    }

    float RandomTorque()
    {
        return Random.Range(-maxTorque, maxTorque);
    }
    Vector3 RandomSpawnPoint()
    {
        return new Vector3(Random.Range(-xRange, xRange), ySpawnPos);
    }
}
