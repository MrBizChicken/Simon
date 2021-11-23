using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blue_changer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Blink()
    {
        StartCoroutine(col());
        col();
    }


    public IEnumerator col()
    {
        gameObject.GetComponent<Renderer>().material.color = new Color(0, 0, 255);
        yield return new WaitForSeconds(3);
        gameObject.GetComponent<Renderer>().material.color = new Color(41, 131, 212);
        yield return new WaitForSeconds(3);
    }
}
