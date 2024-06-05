using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : Singleton<SceneManagement>
{
    public string SceneTransitionName { get; private set; }

    private GameObject AreaExit;
    public GameObject Tamat;
    private void Start()
    {
        AreaExit = GameObject.FindWithTag("AreaExit");
        if (AreaExit != null)
        {
            AreaExit.SetActive(false);
        }
        else
        {
            Debug.LogError("ExitArea object not found!");
        }
    }

    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "Scene 1")
        {
            if (GameObject.FindWithTag("Slime") == null)
            {
                if (AreaExit != null)
                {
                    AreaExit.SetActive(true);
                }
            }
        }
        if (SceneManager.GetActiveScene().name == "Scene 3")
        {
            if (GameObject.FindWithTag("Bos") == null)
            {
                if (Tamat != null)
                {
                    Tamat.SetActive(true);
                    Time.timeScale = 0;
                }
            }
        }

    }

    public void SetTransitionName(string sceneTransitionName) {
        this.SceneTransitionName = sceneTransitionName;
    }
}

