using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreInfo: Naveen.ISaveID
{
    public int levelCount;
}


public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameObject PausePanel;
    public GameObject StartButton;
    public GameObject LevelCompleled;

    public GameObject[] Buttons;
    [HideInInspector]
    public bool isStarted = false;

    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
            instance = this;
        else
        {
            Debug.LogError("Two GameManager Instance Excits");
            Destroy(gameObject);
        }
        PausePanel.SetActive(false);
    }

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        isStarted = true;
        StartButton.SetActive(false);
    }

    public void PauseMenu()
    {
        PausePanel.SetActive(!PausePanel.activeSelf);
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void LevelCompleted()
    {
        Debug.Log("Level Completed");
        LevelCompleled.SetActive(true);

    }
}
