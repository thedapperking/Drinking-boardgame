using System;
using System.Collections;
using UnityEngine;

public class Dice : MonoBehaviour {

    private Sprite[] diceSides;
    private SpriteRenderer rend;
    // [SerializeField]
    public GameObject[] player;

    public NewGameControl newGameControl;

    public int diceWhosturn = 0;
    
    public bool coroutineAllowed = true;
    public static bool diceAllowed = true;

    // private static GameObject player1, player2, player3, player4, player5, player6;

    // make a game.control whosturn = int here

    // Use this for initialization
    private void Start () {
        rend = GetComponent<SpriteRenderer>();
        diceSides = Resources.LoadAll<Sprite>("DiceSides/");
        rend.sprite = diceSides[3];

    }

    
    private void OnMouseDown()
    {
        if (!NewGameControl.gameOver && coroutineAllowed)
            StartCoroutine("RollTheDice");
        
        if (NewGameControl.currentPlayer < NewGameControl.numofPlayers - 1 && NewGameControl.currentPlayer != NewGameControl.whosturn)
        {
            NewGameControl.currentPlayer += 1;

        }
        else
            NewGameControl.currentPlayer = 0;
        
    }

    public IEnumerator RollTheDice()
    {
        coroutineAllowed = false;
        int randomDiceSide = 0;
        for (int i = 0; i <= 20; i++)
        {
            randomDiceSide = UnityEngine.Random.Range(0, 3);
            rend.sprite = diceSides[randomDiceSide];
            yield return new WaitForSeconds(0.05f);
        }

        NewGameControl.diceSideThrown = randomDiceSide + 1;

        /////////// DICE MOVEMENT ///////////
        
        if (NewGameControl.whosturn == NewGameControl.currentPlayer && diceAllowed == true)
        {
           
            if (player[NewGameControl.currentPlayer].GetComponent<FollowThePath>().onShortcut == true && player[NewGameControl.currentPlayer].GetComponent<FollowThePath>().SCStartWaypoint + NewGameControl.diceSideThrown <= 3
                && player[NewGameControl.currentPlayer].GetComponent<FollowThePath>().passed1stShortcut == true && player[NewGameControl.currentPlayer].GetComponent<FollowThePath>().passed2ndShortcut == false)
            {
                newGameControl.ShortcutMovePlayer();

            }
            else
            if (player[NewGameControl.currentPlayer].GetComponent<FollowThePath>().onShortcut == true && player[NewGameControl.currentPlayer].GetComponent<FollowThePath>().SCStartWaypoint + NewGameControl.diceSideThrown <= 7
                && player[NewGameControl.currentPlayer].GetComponent<FollowThePath>().passed1stShortcut == true && player[NewGameControl.currentPlayer].GetComponent<FollowThePath>().passed2ndShortcut == true)
            {
                newGameControl.ShortcutMovePlayer();
            }
            else
            if (player[NewGameControl.currentPlayer].GetComponent<FollowThePath>().onShortcut == true && player[NewGameControl.currentPlayer].GetComponent<FollowThePath>().SCStartWaypoint + NewGameControl.diceSideThrown <= 11
                && player[NewGameControl.currentPlayer].GetComponent<FollowThePath>().passed1stShortcut == true && player[NewGameControl.currentPlayer].GetComponent<FollowThePath>().passed2ndShortcut == true
                && player[NewGameControl.currentPlayer].GetComponent<FollowThePath>().passed3rdShortcut == true)
            {
                newGameControl.ShortcutMovePlayer();
            }

            else
            if (player[NewGameControl.currentPlayer].GetComponent<FollowThePath>().onShortcut == true && player[NewGameControl.currentPlayer].GetComponent<FollowThePath>().SCStartWaypoint + NewGameControl.diceSideThrown > 3
                && player[NewGameControl.currentPlayer].GetComponent<FollowThePath>().passed1stShortcut == true && player[NewGameControl.currentPlayer].GetComponent<FollowThePath>().passed2ndShortcut == false
                && player[NewGameControl.currentPlayer].GetComponent<FollowThePath>().passed3rdShortcut == false)
            {
                player[NewGameControl.currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex = player[NewGameControl.currentPlayer].GetComponent<FollowThePath>().shortcutwaypointIndex + NewGameControl.diceSideThrown + 7;

                if (player[NewGameControl.currentPlayer].GetComponent<FollowThePath>().StartWaypoint + NewGameControl.diceSideThrown > 13)
                {
                    player[NewGameControl.currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex += 1;
                }

                player[NewGameControl.currentPlayer].GetComponent<FollowThePath>().StartWaypoint = player[NewGameControl.currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex - NewGameControl.diceSideThrown;

                newGameControl.MovePlayer();



                player[NewGameControl.currentPlayer].GetComponent<FollowThePath>().moveAllowed = true;
                player[NewGameControl.currentPlayer].GetComponent<FollowThePath>().onShortcut = false;


                // Debugs
               
            }
            else
            if (player[NewGameControl.currentPlayer].GetComponent<FollowThePath>().onShortcut == true && player[NewGameControl.currentPlayer].GetComponent<FollowThePath>().SCStartWaypoint + NewGameControl.diceSideThrown > 7
                && player[NewGameControl.currentPlayer].GetComponent<FollowThePath>().passed1stShortcut == true && player[NewGameControl.currentPlayer].GetComponent<FollowThePath>().passed2ndShortcut == true
                && player[NewGameControl.currentPlayer].GetComponent<FollowThePath>().passed3rdShortcut == false)
            {
                player[NewGameControl.currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex = player[NewGameControl.currentPlayer].GetComponent<FollowThePath>().shortcutwaypointIndex + NewGameControl.diceSideThrown + 10;
                player[NewGameControl.currentPlayer].GetComponent<FollowThePath>().StartWaypoint = player[NewGameControl.currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex - NewGameControl.diceSideThrown;

                newGameControl.MovePlayer();

                player[NewGameControl.currentPlayer].GetComponent<FollowThePath>().moveAllowed = true;
                player[NewGameControl.currentPlayer].GetComponent<FollowThePath>().onShortcut = false;


                // Debugs
                
            }
            else
            if (player[NewGameControl.currentPlayer].GetComponent<FollowThePath>().onShortcut == true && player[NewGameControl.currentPlayer].GetComponent<FollowThePath>().SCStartWaypoint + NewGameControl.diceSideThrown > 11
                && player[NewGameControl.currentPlayer].GetComponent<FollowThePath>().passed1stShortcut == true && player[NewGameControl.currentPlayer].GetComponent<FollowThePath>().passed2ndShortcut == true
                && player[NewGameControl.currentPlayer].GetComponent<FollowThePath>().passed3rdShortcut == true)
            {
                player[NewGameControl.currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex = player[NewGameControl.currentPlayer].GetComponent<FollowThePath>().waypoints.Length - 1;
                player[NewGameControl.currentPlayer].GetComponent<FollowThePath>().StartWaypoint = player[NewGameControl.currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex;

                

                newGameControl.MovePlayer();



                player[NewGameControl.currentPlayer].GetComponent<FollowThePath>().moveAllowed = true;
                player[NewGameControl.currentPlayer].GetComponent<FollowThePath>().onShortcut = false;


                // Debugs
                
            }
            else
            {
                newGameControl.MovePlayer();
            }

            diceAllowed = false;

        }
    
        coroutineAllowed = true;
    }

}
