using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveAbstic : MonoBehaviour
{
    
    private void Start()
    {
        StartCoroutine(Move());
    }

    void Update()
    {
       
        
    }

    private IEnumerator Move()
    {
        while (Vector3.Distance(transform.position,transform.position + new Vector3(5,0,0)) > 0.2f)
        {
        transform.Translate(transform.right);
        yield return new WaitForEndOfFrame();
        }
        yield return new WaitForSeconds(2);
    }
    
}
