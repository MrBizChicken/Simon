using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    //[SerializeField]  Player player;

    [SerializeField]
    int delay = 1;

    [SerializeField]
    GameObject highLight;



    [ContextMenu("Blink")]
    public void Blink()
    {
        StartCoroutine(ChangeColor());
        
    }


    public IEnumerator ChangeColor()
    {

        //higlight on and off
        highLight.SetActive(true);
        yield return new WaitForSeconds(delay);
        highLight.SetActive(false);
        yield return new WaitForSeconds(delay);
    }



    

}