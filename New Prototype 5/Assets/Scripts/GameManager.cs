using NUnit.Framework;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int Score;
    public List<GameObject> Targets;
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI GameOverText;
    private float SpawnRate = 1.0f;
    public bool isGameActive;
    public Button restartButton;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SpawnTarget());
        Score = 0;
        isGameActive = true;

        //Testing
        //GameOver();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver()
    {
        Debug.Log("GameOver() called — enabling GameOverText");
        GameOverText.gameObject.SetActive(true);
        isGameActive = false;
        restartButton.gameObject.SetActive(true);
    }



    public void UpdateScore(int ScoreToAdd)
    {
        Score += ScoreToAdd;
        ScoreText.text = "Score: " + Score;
    }

    IEnumerator SpawnTarget()
    {
        while (isGameActive) { 
            yield return new WaitForSeconds(SpawnRate);
            int index = Random.Range(0, Targets.Count);
            Instantiate(Targets[index]);
            //UpdateScore(5);
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
