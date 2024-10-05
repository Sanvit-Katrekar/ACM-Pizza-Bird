using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ThroughMiddleScript : MonoBehaviour
{
    public LogicScript logic;

    private void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Start is called before the first frame update
    public void OnTriggerEnter2D(Collider2D collision)
    {
        logic.addScore();

    }
}
