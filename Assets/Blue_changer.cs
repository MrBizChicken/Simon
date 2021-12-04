using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blue_changer : MonoBehaviour
{
    [SerializeField] private Player player;
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
        StartCoroutine(ChangeColor());

    }


    public IEnumerator ChangeColor()
    {
        Renderer r = gameObject.GetComponent<Renderer>();
        r.material.color = new Color(255, 0, 0);
        yield return new WaitForSeconds(3);
        r.material.color = new Color(192, 43, 43);
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