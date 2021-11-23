using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    List<int> Simon = new List<int>();
    
    public GameObject  red, blue, green, yellow; 
    // Start is called before the first frame update
    void Start()
    {
        int rand_num = Random.Range(0, 3);
        Simon.Add(rand_num);
        Blinker(rand_num);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void Blinker(int rand_num)
    {
        if (rand_num == 0)
        {
            Debug.Log("woof");
            red.GetComponent<Red_changer>().Blink();
        }


        if (rand_num == 1)
        {

            Debug.Log("bark");
            blue.GetComponent<Blue_changer>().Blink();
        }


        if (rand_num == 2)
        {

            Debug.Log("moo");
            green.GetComponent<Green_changer>().Blink();
        }


        if (rand_num == 3)
        {

            Debug.Log("meow");
            yellow.GetComponent<Yellow_changer>().Blink();

        }

        
    }

}
