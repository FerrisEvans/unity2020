using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class LunaController : MonoBehaviour
{
    private float _speed;
    public float walkSpeed = 3.0F;
    public float runSpeed = 5.0F;

    
    private Rigidbody2D _rigidbody2D;
    private Animator _animator;

    private Vector2 _direction = new(1, 0);
    private float _moveThreshold;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _animator = GetComponentInChildren<Animator>();
        _speed = walkSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        _move = new(horizontal, vertical);

        if (!Mathf.Approximately(_move.x, 0) || !Mathf.Approximately(_move.y, 0))
        {
            _direction.Set(_move.x, _move.y);
            _direction.Normalize();
        }
        _animator.SetFloat("X", _direction.x);
        _animator.SetFloat("Y", _direction.y);
        _moveThreshold = _move.magnitude;
        if (_move.magnitude > 0)
        { 
            if (Input.GetKey(KeyCode.LeftShift))
            {
                _moveThreshold = 1.0F;
                _speed = walkSpeed;
            }
            else
            {
                _moveThreshold = 2.0F;
                _speed = runSpeed;
            }
        }
        _animator.SetFloat("Move", _moveThreshold);
    }

    private Vector2 _move;

    private void FixedUpdate()
    {        
        Vector2 position = transform.position;
        position += _move * (_speed * Time.fixedDeltaTime);
        // transform.position = position;
        _rigidbody2D.MovePosition(position);
        
    }

    public void Climb(bool climb)
    {
        _animator.SetBool("Climb", climb);
    }

    public void Jump(bool jump)
    {
        _animator.SetBool("Jump", jump);
        _rigidbody2D.simulated = !jump;
    }
}
