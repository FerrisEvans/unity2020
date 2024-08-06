using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionScript : MonoBehaviour
{
    public GameObject effectGo;

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (GameManager.Instance.hp >= GameManager.Instance.maxHp) return;
        GameManager.Instance.ChangeHp();
        Instantiate(effectGo, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}