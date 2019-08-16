using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingplayer : MonoBehaviour
{

    public Vector2 speed = new Vector2(10, 10);

    private Vector2 movement = new Vector2(1, 1);

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      
        if (Input.GetKeyDown("space"))
        {
            transform.Translate(Vector3.up * 260 * Time.deltaTime, Space.World);
        }

    }
    void FixedUpdate()
    {
        // 5 - Move the game object
        GetComponent<Rigidbody2D>().velocity = movement;
        //rigidbody2D.AddForce(movement);

    }
}