using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public bool vertical;
    public float speed = 2F;
    public float changeTime = 2F;
    private float _timer;
    private int _direction = 1;
    private Rigidbody2D _rigidbody2D;
    private Animator _animator;
    
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _timer = changeTime;
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        _timer -= Time.deltaTime;
        if (_timer < 0)
        {
            _direction *= -1;
            _timer = changeTime;
        }
    }

    private void FixedUpdate()
    {
        Vector3 pos = _rigidbody2D.position;
        if (vertical)
        {
            pos.y += speed * _direction * Time.fixedDeltaTime;
        }
        else
        {
            pos.x += speed * _direction * Time.fixedDeltaTime;
        }
        
        _rigidbody2D.MovePosition(pos);
    }
}
