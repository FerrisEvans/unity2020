using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D coll)
    {
        var lunaController = coll.GetComponent<LunaController>();
        if (lunaController is null || lunaController.hp >= lunaController.maxHp) return;
        lunaController.ChangeHp();
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
