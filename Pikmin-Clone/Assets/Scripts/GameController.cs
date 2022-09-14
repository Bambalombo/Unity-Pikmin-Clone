using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public enum EnumColor { none, red, green, blue, yellow }
    public EnumColor _enumColor;

    private void Start()
    {
        _enumColor = EnumColor.none;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _enumColor = EnumColor.red;
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _enumColor = EnumColor.green;
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            _enumColor = EnumColor.blue;
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            _enumColor = EnumColor.yellow;
            gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        }
    }
}
