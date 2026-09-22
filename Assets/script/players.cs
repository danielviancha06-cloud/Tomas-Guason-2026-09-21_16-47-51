using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class players : MonoBehaviour
{
    [SerializeField] InputActionReference cambio;
    public GameObject player1, player2, player3, player4; //player5;
    [SerializeField] Vector2 posicion;

    void Update()
    {
        if (cambio.action.WasPressedThisFrame())

        {
            posicion = player1.transform.position;
            player1.transform.position = player2.transform.position;
            player2.transform.position = player3.transform.position;
            player3.transform.position = player4.transform.position;
            // player4.transform.position = player5.transform.position;

            player1.transform.position = posicion;
            player2.transform.position = posicion;
            player3.transform.position = posicion;
            player4.transform.position = posicion;
            // player5.transform.position = posicion;

            player1.SetActive(player1.activeSelf);
            player2.SetActive(player3.activeSelf);
            player3.SetActive(player4.activeSelf);
            //player5.SetActive(player1.activeSelf);
        }

    }
}
