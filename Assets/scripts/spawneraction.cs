using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawneraction : MonoBehaviour
{
    public float width = 10f;
    public float heigth = 5f;
    public GameObject pianotile;
    public float delay = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        spawnuntill();
    }
    void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(transform.position, new Vector3(width,heigth,0));
    }
    // Update is called once per frame
    void Update()
    {
        if (checkforempty())
        {
            spawnuntill();
        }
    }
    void spawnuntill()
    {
        Transform position = freeposition();
        if(position)
        {
            GameObject piano = Instantiate(pianotile,position.transform.position, Quaternion.identity);
            piano.transform.parent= position;
        }
        if (freeposition())
        {
            Invoke("spawnuntill",delay);
        }
    }
    
    
    
    
    void spawner()
    {
        foreach(Transform child in transform)
        {
            GameObject piano = Instantiate(pianotile,child.position, Quaternion.identity);
            piano.transform.parent= child;
        }
    }
    bool checkforempty()
    {
        foreach(Transform child in transform)
        {
            if(child.childCount>0)
            {
                return false;
            }
        }
        return true;
    }
    Transform freeposition()
    {
        foreach(Transform child in transform)
        {
            if(child.childCount==0)
            {
                return child;
            }
        }
        return null;
    }
}
