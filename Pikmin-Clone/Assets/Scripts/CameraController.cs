using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private GameObject player;

    private GameObject camera;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        camera = gameObject;
    }
    
    void Update()
    {
        Vector3 playerPos = player.transform.position;
        camera.transform.position = playerPos + new Vector3(0f,12.5f,-18f);
    }
}
