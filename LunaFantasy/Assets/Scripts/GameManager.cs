using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;
    public int maxHp = 5;
    public int hp;
    public GameObject battleGo;

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        hp = maxHp;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void ChangeHp(int offset = 1)
    {
        hp = Mathf.Clamp(hp + offset, 0, maxHp);
    }

    public void Battle(bool enter = true)
    {
        battleGo.SetActive(enter);
    }
}
