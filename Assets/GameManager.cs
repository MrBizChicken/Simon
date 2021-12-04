using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;




public class GameManager : MonoBehaviour
{

    List<int> Simon = new List<int>();
    [SerializeField] private Player _player;

    public GameObject red, blue, green, yellow;
    
    // Start is called before the first frame update
    void Start()
    {


        SimonsTurn();


    }



    void Blinker(int item)
    {
        if (item == 0)
        {
            red.GetComponent<ColorChanger>().Blink();


        }


        if (item == 1)
        {
            blue.GetComponent<ColorChanger>().Blink();

        }


        if (item == 2)
        {
            green.GetComponent<ColorChanger>().Blink();

        }


        if (item == 3)
        {
            yellow.GetComponent<ColorChanger>().Blink();


        }





    }


    void PlayerTurn()
    {
        for (int i = 0; i < Simon.Count;  i++)
        {
            if (IndexMatches(i))
            {
                
                if (LengthMatches())
                {
                    SimonsTurn();
                    print("hi");

                }
                
            }

            else
            {
                Application.Quit();
            }

        

        }
        
    }



    private void SimonsTurn()
    {
        int rand_num = Random.Range(0, 3);
        Simon.Add(rand_num);




        foreach(var item in Simon)
        {
            Blinker(item);
        }
        PlayerTurn();
        
     }



    bool LengthMatches()
    {
        return Simon.Count == _player.GetComponent<Player>().Input.Count;
    }


    
    bool IndexMatches(int index)
    {
        int playerCount = _player.GetComponent<Player>().Input.Count;
        
        

        if (index <= playerCount && playerCount > 0)
        {
            return Simon[index] == _player.GetComponent<Player>().Input[index];

        }
        return false;
        
    }



    //Players turn.
    //Get players input when we click on a button.
    //Put the button vaule in players list.
    //Compare simons and players indexs.
    //Compare the lengths of simons and players list's.
    //If all is true the simons turn again.


    //Simons turn.
    // Add a new random number into simons list.
    //Light and flash the pattern of simons list.
    //Pass the turn to player.





}