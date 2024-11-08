using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class tileaction : MonoBehaviour
{
    public SpriteRenderer color;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0))
        {
        color.color = Color.cyan;
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if(color.color == Color.cyan)
        {
            Debug.Log("You are doing it amazing!");
        }
        else if (col.collider.tag =="border")
        {
            Debug.Log("You suck at this ma boi haha");
        }
    }
}
