using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;




public class GameManager : MonoBehaviour
{

    List<int> simonsButtons = new List<int>();
    
    [SerializeField] private Player _player;

    [SerializeField]
    GameObject[] highlights;

    [SerializeField]
    float delayTime = 1;


    void Start()
    {
        StartCoroutine(SimonsTurn());
    }



    private IEnumerator SimonsTurn()
    {
        int rand_num = Random.Range(0, 3);
        
        simonsButtons.Add(rand_num);
        

        foreach (int buttonToLight in simonsButtons)
        {
            LightOn(buttonToLight);
            yield return new WaitForSeconds(delayTime);
            LightOff(buttonToLight);
            yield return new WaitForSeconds(delayTime);
        }
     }



    void LightOn(int buttonToLight)
    {
        highlights[buttonToLight].SetActive(true);
    }



    void LightOff(int buttonToLight)
    {
        highlights[buttonToLight].SetActive(false);
    }
}