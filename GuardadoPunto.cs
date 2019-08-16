using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardadoPunto : MonoBehaviour
{
    public LevelManager lvlMN;
    // Start is called before the first frame update
    void Start()
    {
        lvlMN = FindObjectOfType<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "sprite")
        {
            lvlMN.currentCheck = gameObject;
            Debug.Log("Regrese" + transform.position);
        }
    }
}
