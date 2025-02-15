using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;

public class AreaEntrance : MonoBehaviour
{
    [SerializeField] private string transitionName;

    private void Start()
    {
        if (transitionName == SceneManagement.Instance.SceneTransitionName)
        {
            PlayerController.Instance.transform.position = this.transform.position;
            UIFade.Instance.FadeToClear();
        }
    }
}
