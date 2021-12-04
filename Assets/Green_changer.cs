using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Green_changer : MonoBehaviour
{

    [SerializeField] Player player;


    public void Blink()
    {
        StartCoroutine(ChangeColor());

    }


    public IEnumerator ChangeColor()
    {
        Renderer r = gameObject.GetComponent<Renderer>();


        r.material.color = new Color(0, 255, 0);
        yield return new WaitForSeconds(3);
        r.material.color = new Color(90, 185, 60);
        yield return new WaitForSeconds(3);
    }


    void OnMouseDown()
    {
        if (Input.GetMouseButton(0))
        {
            player.Red_input();
            print("calll");

        }
    }
}




