using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehavior : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private float detectionRange = 10f;
    private float proximityRange = 3f;
    private float movementSpeed = 10f;

    private bool isFollwing, isAttacking;
    private string currentColor;

    void Start()
    {
        currentColor = player.GetComponent<GameController>()._enumColor.ToString();
        setColor();
    }

    void Update()
    {
        if (!isFollwing 
            && Vector3.Distance(player.transform.position, transform.position) < detectionRange
            //&& tag == player.GetComponent<GameController>()._enumColor.ToString()
            && player.CompareTag(currentColor)
            )
        {
            isFollwing = true;
        }

        if (isFollwing 
            && Vector3.Distance(player.transform.position, transform.position) > proximityRange 
            )
        {
            Vector3 playerPos = player.transform.position;
            transform.position = Vector3.MoveTowards(transform.position, playerPos, movementSpeed*Time.deltaTime);
        }
    }

    void setColor()
    {
        switch (gameObject.tag)
        {
            case "red": gameObject.GetComponent<Renderer>().material.color = Color.red; break;
            case "green": gameObject.GetComponent<Renderer>().material.color = Color.green; break;
            case "blue": gameObject.GetComponent<Renderer>().material.color = Color.blue; break;
            case "yellow": gameObject.GetComponent<Renderer>().material.color = Color.yellow; break;
        }
    }
}
