using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject currentCheck;
    private Movimiento sprite;

    // Start is called before the first frame update
    void Start()
    {
        sprite = FindObjectOfType<Movimiento>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RespPlayer()
    {
        Debug.Log("I know right?");
        sprite.transform.position = currentCheck.transform.position;

    }
}
