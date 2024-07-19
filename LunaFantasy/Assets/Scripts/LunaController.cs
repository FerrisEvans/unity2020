using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LunaController : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    public float speed = 10.0F;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
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
}
