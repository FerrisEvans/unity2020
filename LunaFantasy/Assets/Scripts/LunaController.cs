using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LunaController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        Debug.Log("Horizontal, " + horizontal);
        // Vector2 position = transform.position;
        // position.x += 0.1F;
        // transform.position = position;
    }
}
