using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Windows;



public class Tile : MonoBehaviour
{

    [SerializeField] private GameObject _highlight;
    [SerializeField] private GameObject _cliquayP1, _cliquayP2;
    public int WhosTurn = 1;

    
    void OnMouseEnter()
    {
        _highlight.SetActive(true);
    }

    void OnMouseExit()
    {
        _highlight.SetActive(false);
    }

    void OnMouseDown()
    {
        if (WhosTurn == 1)
        {
            _cliquayP1.SetActive(true);
            _cliquayP2.SetActive(false);
        }
        else if (WhosTurn == 2)
        {
            _cliquayP2.SetActive(true);
            _cliquayP1.SetActive(false);
        }


        ChangePlayer();
    }

    void ChangePlayer()
    {
        if (WhosTurn == 1)
        {
            WhosTurn = 2;
        }
        else if (WhosTurn == 2)
        {
            WhosTurn = 1;
        }
    }
}