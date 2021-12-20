using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    GameObject highlight;
    [SerializeField] private GameManager g;
    [SerializeField] float selfid = 0;

    void OnMouseDown()
    {
        if  (selfid == 0)
        {
            g.playerSlections.Add(0);
            PlayerTurn();

        }

        if (selfid == 1)
        {
            g.playerSlections.Add(1);
            PlayerTurn();
        }


        if (selfid == 2)
        {
            g.playerSlections.Add(2);
            PlayerTurn();
        }

        if (selfid == 3)
        {
            g.playerSlections.Add(3);
            PlayerTurn();
        }
    }


    public void PlayerTurn()
    {
        for (int i = 0; i < g.simonsButtons.Count; i++)
        {


            if (g.simonsButtons.Count == g.playerSlections.Count && g.simonsButtons[i] == g.playerSlections[i])
            {
                print("Working");
                g.playerSlections.Clear();
                StartCoroutine(g.SimonsTurn());

            }

            else
            {
                Application.Quit();
            }

        }
    }


}



