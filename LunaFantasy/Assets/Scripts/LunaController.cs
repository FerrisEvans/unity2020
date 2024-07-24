using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LunaController : MonoBehaviour
{
    public float speed = 10.0F;
    public int maxHp = 5;
    public int hp;
    
    private Rigidbody2D _rigidbody2D;
    private Animator _animator;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _animator = GetComponentInChildren<Animator>();
        _animator.SetFloat("MoveValue", 1.0F);
        hp = maxHp;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 position = transform.position;
        position.x += speed * horizontal * Time.deltaTime;
        position.y += speed * vertical * Time.deltaTime;
        // transform.position = position;
        _rigidbody2D.MovePosition(position);
    }

    public void ChangeHp(int offset = 1)
    {
        hp = Mathf.Clamp(hp + offset, 0, maxHp);
    }
}
