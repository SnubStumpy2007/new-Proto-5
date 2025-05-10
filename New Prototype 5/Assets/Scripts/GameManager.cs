using NUnit.Framework;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{

    public List<GameObject> Targets;
    private float SpawnRate = 1.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SpawnTarget());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnTarget()
    {
        while (true) { 
            yield return new WaitForSeconds(SpawnRate);
            int index = Random.Range(0, Targets.Count);
            Instantiate(Targets[index]);
        }
    }
}
