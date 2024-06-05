using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using Unity.VisualScripting;

public class cameraPlayer : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera _virtualCamera;
    // Start is called before the first frame update
    void Start()
    {
        _virtualCamera = GameObject.Find("Cinemacine").GetComponent<CinemachineVirtualCamera>();
        _virtualCamera.Follow = GameObject.Find("Player").GetComponent<Transform>();
    }
}
