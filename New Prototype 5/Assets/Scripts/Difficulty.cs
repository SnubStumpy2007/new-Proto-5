using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Difficulty : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Button button;
    private GameManager gameManager;
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDifficulty);
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetDifficulty()
    {
        Debug.Log(gameObject.name + " was clicked");
        button.onClick.AddListener(SetDifficulty);
    }
}
