using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;




public class GameManager : MonoBehaviour
{

    List<int> Simon = new List<int>();
    [SerializeField] private Player _player;

    public GameObject Red, Blue, Green, Yellow;
    
    // Start is called before the first frame update
    void Start()
    {


       SimonsTurn();


    }



    void Blinker(int rand_num)
    {
        if (rand_num == 0)
        {
            Red.GetComponent<ColorChanger>().Blink();


        }


        if (rand_num == 1)
        {
            Blue.GetComponent<ColorChanger>().Blink();

        }


        if (rand_num == 2)
        {
            Green.GetComponent<ColorChanger>().Blink();

        }


        if (rand_num == 3)
        {
            Yellow.GetComponent<ColorChanger>().Blink();


        }





    }


    void PlayerTurn()
    {
        for (int i = 0; i < Simon.Count; i++)
        {
            if (IndexMatches(i))
            {

                if (LengthMatches(i))
                {

                    print("boom");
                    SimonsTurn();

                }
                print("omg");

            }

            else
            {
                Application.Quit();
            }



        }
        

    }


    [ContextMenu("Simons Turn")]
    private void SimonsTurn()
    {
        int rand_num = Random.Range(0, 3);
        Simon.Add(rand_num);


        Blinker(rand_num);
        PlayerTurn();
        print(_player.Input);
        
        
     }



    bool LengthMatches(int index)
    {
        return Simon.Count == _player.GetComponent<Player>().Input.Count;
        print("hi");
    }


    
    bool IndexMatches(int index)
    {
        int playerCount = _player.GetComponent<Player>().Input.Count;
        print("lol");



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