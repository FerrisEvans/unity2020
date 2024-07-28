using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candle : MonoBehaviour
{
    public GameObject effectGo;
    public int necessaryCount = 3;

    private static int _collected;
    
    void Start()
    {
        _collected = 0;
    }
    private void OnTriggerEnter2D(Collider2D c)
    {
        Instantiate(effectGo, transform.position, Quaternion.identity);
        _collected++;
        if (_collected > necessaryCount)
        {
            _collected = necessaryCount;
        }
        else
        {
            Destroy(gameObject);
        }
        Debug.Log("collected candles: " + _collected);
    }
}
