using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject pauseMenu;

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }

    public void QuitGame()
    {
        pauseMenu.SetActive(false);
        Destroy(GameObject.FindWithTag("Player"));
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1;
    }
}
