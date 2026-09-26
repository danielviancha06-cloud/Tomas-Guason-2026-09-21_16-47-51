using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections.Generic;
public class PlayersController : MonoBehaviour
{
    [SerializeField] private InputActionAsset inputActionAseet;
    private InputAction inputAction;


    [SerializeField]
    private List<MonomedPlayer> players = new List<MonomedPlayer>();
    public int currPlayer = 0;


    private void OnEnable()
    {
        inputActionAseet.FindActionMap("Player").Enable();
    }

    private void OnDisable()
    {
        inputActionAseet.FindActionMap("Player").Enable();
    }

    private void Awake()
    {

        inputAction = inputActionAseet.FindAction("interact");
        players[currPlayer].isActive = true;
    }

    private void Update()

    {
        if (inputAction.WasPressedThisFrame())
        {
            players[currPlayer].isActive = false;
            if (currPlayer + 1 < players.Count)
            {
                currPlayer++;
            }

            else
            {
                currPlayer = 0;
            }


            players[currPlayer].isActive = true;
        }
    }
}


