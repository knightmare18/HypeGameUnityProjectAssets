using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingKeys : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("button pressed");
        }
        if(Input.GetMouseButton(0))
        {
            Debug.Log("button is pressed");
        }
        if(Input.GetMouseButtonUp(0))
        {
            Debug.Log("button released");
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Using Keycode. You can use this to make the player jump");
        }
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        if (horizontal < 0f || horizontal > 0f)
        {
            Debug.Log("Horizontal axis is " + horizontal);
        }
        if(vertical < 0f || vertical > 0f)
        {
            Debug.Log("Vertical axis is " + vertical);
        }
    }
}
