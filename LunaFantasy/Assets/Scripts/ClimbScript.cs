using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClimbScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D c)
    {
        if (c.CompareTag("Luna"))
        {
            LunaController luna = c.GetComponent<LunaController>();
            luna.Climb(true);
        }
    }

    private void OnTriggerExit2D(Collider2D c)
    {
        if (c.CompareTag("Luna"))
        {
            LunaController luna = c.GetComponent<LunaController>();
            luna.Climb(false);
        }
    }
}
