using UnityEngine;

public class Targets : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private Rigidbody targetRB;
    private float minSpeed = 12;
    private float maxSpeed = 16;
    private float maxTorgue = 10;
    private float xRange = 4;
    private float ySpawnPos = -6;
    void Start()
    {
        targetRB = GetComponent<Rigidbody>();
        targetRB.AddForce(RandomForce(), ForceMode.Impulse);
        targetRB.AddTorque(RandomTorgue(), RandomTorgue(), RandomTorgue(), ForceMode.Impulse);
        transform.position = RandomSpawnPoint();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }

    Vector3 RandomForce()
    {
        return Vector3.up * Random.Range(minSpeed, maxSpeed);
    }

    float RandomTorgue()
    {
        return Random.Range(-maxTorgue, maxTorgue);
    }
    Vector3 RandomSpawnPoint()
    {
        return new Vector3(Random.Range(-xRange, xRange), ySpawnPos);
    }
}
