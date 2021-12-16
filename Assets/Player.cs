using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public List<int> Input = new List<int>();
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }





   public void Red_input()
    {
        Input.Add(0);



    }




    public void Blue_input()
    {
        Input.Add(1);


    }




    public void Green_input()
    {
        Input.Add(2);


    }



    public void Yellow_input()
    {
        Input.Add(3);


    }

}
