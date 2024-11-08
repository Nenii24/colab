using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class positionscript : MonoBehaviour
{
    public float width = 10f;
    public float heigth = 5f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireCube(transform.position, new Vector3(width,heigth,0));
    }
    // Update is called once per frame
    void Update()
    {
        
    }

}
