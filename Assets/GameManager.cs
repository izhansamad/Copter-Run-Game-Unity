using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //public GameObject Spawner;
    public GameObject pauseScreen;

    //private void Awake()
    //{
    //    Spawner = GameObject.FindGameObjectWithTag("Spawner");
    //}
    //public void TapToPlay()
    //{
    //    Spawner.SetActive(true);
    //}
    public void Play()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;

    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void Pause()
    {
        Time.timeScale = 0;
        pauseScreen.SetActive(true);
    }
    public void Resume()
    {
        Time.timeScale = 1;
        pauseScreen.SetActive(false);
    }
}
