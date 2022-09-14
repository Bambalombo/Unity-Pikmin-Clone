using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 15f;
    private GameObject player;

    void Start()
    {
        player = gameObject;
    }
    
    void FixedUpdate()
    {
        Vector3 moveVector = new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));
        player.transform.Translate(moveVector*(movementSpeed*Time.deltaTime));
    }
}
