using System.Collections;
using UnityEngine;

public class Dice : MonoBehaviour {

    private Sprite[] diceSides;
    private SpriteRenderer rend;
    private static int whosTurn = 1; // private 
    private bool coroutineAllowed = true;

    private static GameObject player1, player2, player3, player4, player5, player6;

    // make a game.control whosturn = int here

    // Use this for initialization
    private void Start () {
        rend = GetComponent<SpriteRenderer>();
        diceSides = Resources.LoadAll<Sprite>("DiceSides/");
        rend.sprite = diceSides[3];

        player1 = GameObject.Find("Player1");
        player2 = GameObject.Find("Player2");
        player3 = GameObject.Find("Player3");
        player4 = GameObject.Find("Player4");
        player5 = GameObject.Find("Player5");
        player6 = GameObject.Find("Player6");
    }

    
    private void OnMouseDown()
    {
        if (!GameControl.gameOver && coroutineAllowed)
            StartCoroutine("RollTheDice");
    }

    public IEnumerator RollTheDice()
    {
        coroutineAllowed = false;
        int randomDiceSide = 0;
        for (int i = 0; i <= 20; i++)
        {
            randomDiceSide = Random.Range(0, 3);
            rend.sprite = diceSides[randomDiceSide];
            yield return new WaitForSeconds(0.05f);
        }

        GameControl.diceSideThrown = randomDiceSide + 1;
        if (whosTurn == 1)
        {
            // player1.GetComponent<Renderer>().sortingOrder = 6;
            // GameControl.PlayerTurn(1);
            GameControl.whosturn = 1;

            if (player1.GetComponent<FollowThePath>().onShortcut == true && GameControl.player1SCStartWaypoint + GameControl.diceSideThrown <= 3
                && player1.GetComponent<FollowThePath>().passed1stShortcut == true && player1.GetComponent<FollowThePath>().passed2ndShortcut == false)
            {
                GameControl.ShortcutMovePlayer(1);

            }
            else
            if (player1.GetComponent<FollowThePath>().onShortcut == true && GameControl.player1SCStartWaypoint + GameControl.diceSideThrown <= 7
                && player1.GetComponent<FollowThePath>().passed1stShortcut == true && player1.GetComponent<FollowThePath>().passed2ndShortcut == true)
            {
                GameControl.ShortcutMovePlayer(1);
            }
            else
            if (player1.GetComponent<FollowThePath>().onShortcut == true && GameControl.player1SCStartWaypoint + GameControl.diceSideThrown <= 11
                && player1.GetComponent<FollowThePath>().passed1stShortcut == true && player1.GetComponent<FollowThePath>().passed2ndShortcut == true
                && player1.GetComponent<FollowThePath>().passed3rdShortcut == true)
            {
                GameControl.ShortcutMovePlayer(1);
            }

            else
            if (player1.GetComponent<FollowThePath>().onShortcut == true && GameControl.player1SCStartWaypoint + GameControl.diceSideThrown > 3
                && player1.GetComponent<FollowThePath>().passed1stShortcut == true && player1.GetComponent<FollowThePath>().passed2ndShortcut == false
                && player1.GetComponent<FollowThePath>().passed3rdShortcut == false)
            {
                player1.GetComponent<FollowThePath>().StartwaypointIndex = player1.GetComponent<FollowThePath>().shortcutwaypointIndex + GameControl.diceSideThrown + 7;

                if (GameControl.player1StartWaypoint + GameControl.diceSideThrown > 13)
                {
                    player1.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                }

                GameControl.player1StartWaypoint = player1.GetComponent<FollowThePath>().StartwaypointIndex - GameControl.diceSideThrown;

                GameControl.MovePlayer(1);



                player1.GetComponent<FollowThePath>().moveAllowed = true;
                player1.GetComponent<FollowThePath>().onShortcut = false;


                // Debugs
                Debug.Log("P1START WAYPOINT " + GameControl.player1StartWaypoint);
                Debug.Log("P1WP INDEX " + player1.GetComponent<FollowThePath>().StartwaypointIndex);
                Debug.Log("last dice roll " + GameControl.diceSideThrown);
                Debug.Log("SHORTCUTWAYPOINT INDEX" + player1.GetComponent<FollowThePath>().shortcutwaypointIndex);
                // Debug.Log("passed 2nd shortcut??? " + player1.GetComponent<FollowThePath>().passed2ndShortcut);


                // Debug.Log("P1START WAYPOINT after moving " + GameControl.player1StartWaypoint);

            }
            else
            if (player1.GetComponent<FollowThePath>().onShortcut == true && GameControl.player1SCStartWaypoint + GameControl.diceSideThrown > 7
                && player1.GetComponent<FollowThePath>().passed1stShortcut == true && player1.GetComponent<FollowThePath>().passed2ndShortcut == true
                && player1.GetComponent<FollowThePath>().passed3rdShortcut == false)
            {
                player1.GetComponent<FollowThePath>().StartwaypointIndex = player1.GetComponent<FollowThePath>().shortcutwaypointIndex + GameControl.diceSideThrown + 10;
                GameControl.player1StartWaypoint = player1.GetComponent<FollowThePath>().StartwaypointIndex - GameControl.diceSideThrown;

                GameControl.MovePlayer(1);

                // GameControl.player1StartWaypoint += 1;

                player1.GetComponent<FollowThePath>().moveAllowed = true;
                player1.GetComponent<FollowThePath>().onShortcut = false;


                // Debugs
                Debug.Log("P1START WAYPOINT " + GameControl.player1StartWaypoint);
                Debug.Log("P1WP INDEX " + player1.GetComponent<FollowThePath>().StartwaypointIndex);
                Debug.Log("last dice roll " + GameControl.diceSideThrown);
                Debug.Log("SHORTCUTWAYPOINT INDEX" + player1.GetComponent<FollowThePath>().shortcutwaypointIndex);


                // Debug.Log("P1START WAYPOINT after moving " + GameControl.player1StartWaypoint);

            }
            else
            if (player1.GetComponent<FollowThePath>().onShortcut == true && GameControl.player1SCStartWaypoint + GameControl.diceSideThrown > 11
                && player1.GetComponent<FollowThePath>().passed1stShortcut == true && player1.GetComponent<FollowThePath>().passed2ndShortcut == true
                && player1.GetComponent<FollowThePath>().passed3rdShortcut == true)
            {
                player1.GetComponent<FollowThePath>().StartwaypointIndex = player1.GetComponent<FollowThePath>().waypoints.Length - 1;
                GameControl.player1StartWaypoint = player1.GetComponent<FollowThePath>().StartwaypointIndex;

                // player1.GetComponent<FollowThePath>().StartwaypointIndex = player1.GetComponent<FollowThePath>().shortcutwaypointIndex + GameControl.diceSideThrown + 10;
                // GameControl.player1StartWaypoint = player1.GetComponent<FollowThePath>().StartwaypointIndex - GameControl.diceSideThrown;

                GameControl.MovePlayer(1);



                player1.GetComponent<FollowThePath>().moveAllowed = true;
                player1.GetComponent<FollowThePath>().onShortcut = false;


                // Debugs
                Debug.Log("P1START WAYPOINT " + GameControl.player1StartWaypoint);
                Debug.Log("P1WP INDEX " + player1.GetComponent<FollowThePath>().StartwaypointIndex);
                Debug.Log("last dice roll " + GameControl.diceSideThrown);
                Debug.Log("SHORTCUTWAYPOINT INDEX" + player1.GetComponent<FollowThePath>().shortcutwaypointIndex);


                // Debug.Log("P1START WAYPOINT after moving " + GameControl.player1StartWaypoint);

            }
            else
            {
                GameControl.MovePlayer(1);

                // Debug.Log("dice working normal route");
            }



            // player1.GetComponent<Renderer>().sortingOrder -= 1;
            // GameControl.player2MoveText.gameObject.SetActive(true);
            // GameControl.player1MoveText.gameObject.SetActive(false);


        }
        else if (whosTurn == 2)        // switch player turns 
        {
            // player2.GetComponent<Renderer>().sortingOrder = 6;
            // GameControl.PlayerTurn(2);
            GameControl.whosturn = 2;

            if (player2.GetComponent<FollowThePath>().onShortcut == true && GameControl.player2SCStartWaypoint + GameControl.diceSideThrown <= 3
                 && player2.GetComponent<FollowThePath>().passed1stShortcut == true && player2.GetComponent<FollowThePath>().passed2ndShortcut == false)
            {
                GameControl.ShortcutMovePlayer(2);

            }
            else
             if (player2.GetComponent<FollowThePath>().onShortcut == true && GameControl.player2SCStartWaypoint + GameControl.diceSideThrown <= 7
                 && player2.GetComponent<FollowThePath>().passed1stShortcut == true && player2.GetComponent<FollowThePath>().passed2ndShortcut == true)
            {
                GameControl.ShortcutMovePlayer(2);
            }
            else
             if (player2.GetComponent<FollowThePath>().onShortcut == true && GameControl.player2SCStartWaypoint + GameControl.diceSideThrown <= 11
                 && player2.GetComponent<FollowThePath>().passed1stShortcut == true && player2.GetComponent<FollowThePath>().passed2ndShortcut == true
                 && player2.GetComponent<FollowThePath>().passed3rdShortcut == true)
            {
                GameControl.ShortcutMovePlayer(2);
            }

            else
             if (player2.GetComponent<FollowThePath>().onShortcut == true && GameControl.player2SCStartWaypoint + GameControl.diceSideThrown > 3
                 && player2.GetComponent<FollowThePath>().passed1stShortcut == true && player2.GetComponent<FollowThePath>().passed2ndShortcut == false
                 && player2.GetComponent<FollowThePath>().passed3rdShortcut == false)
            {
                player2.GetComponent<FollowThePath>().StartwaypointIndex = player2.GetComponent<FollowThePath>().shortcutwaypointIndex + GameControl.diceSideThrown + 7;

                if (GameControl.player2StartWaypoint + GameControl.diceSideThrown > 13)
                {
                    player2.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                }


                GameControl.player2StartWaypoint = player2.GetComponent<FollowThePath>().StartwaypointIndex - GameControl.diceSideThrown;

                GameControl.MovePlayer(2);


                player2.GetComponent<FollowThePath>().moveAllowed = true;
                player2.GetComponent<FollowThePath>().onShortcut = false;


            }
            else
             if (player2.GetComponent<FollowThePath>().onShortcut == true && GameControl.player2SCStartWaypoint + GameControl.diceSideThrown > 7
                 && player2.GetComponent<FollowThePath>().passed1stShortcut == true && player2.GetComponent<FollowThePath>().passed2ndShortcut == true
                 && player2.GetComponent<FollowThePath>().passed3rdShortcut == false)
            {
                player2.GetComponent<FollowThePath>().StartwaypointIndex = player2.GetComponent<FollowThePath>().shortcutwaypointIndex + GameControl.diceSideThrown + 10;
                GameControl.player2StartWaypoint = player2.GetComponent<FollowThePath>().StartwaypointIndex - GameControl.diceSideThrown;

                GameControl.MovePlayer(2);

                player2.GetComponent<FollowThePath>().moveAllowed = true;
                player2.GetComponent<FollowThePath>().onShortcut = false;


            }
            else
             if (player2.GetComponent<FollowThePath>().onShortcut == true && GameControl.player2SCStartWaypoint + GameControl.diceSideThrown > 11
                 && player2.GetComponent<FollowThePath>().passed1stShortcut == true && player2.GetComponent<FollowThePath>().passed2ndShortcut == true
                 && player2.GetComponent<FollowThePath>().passed3rdShortcut == true)
            {
                player2.GetComponent<FollowThePath>().StartwaypointIndex = player2.GetComponent<FollowThePath>().waypoints.Length - 1;
                GameControl.player2StartWaypoint = player2.GetComponent<FollowThePath>().StartwaypointIndex;

                GameControl.MovePlayer(2);



                player2.GetComponent<FollowThePath>().moveAllowed = true;
                player2.GetComponent<FollowThePath>().onShortcut = false;


            }
            else
            {
                GameControl.MovePlayer(2);

            }
            // player2.GetComponent<Renderer>().sortingOrder -= 1;

        }
        else
         if (whosTurn == 3)        // switch player turns 
         {

            GameControl.whosturn = 3;

            if (player3.GetComponent<FollowThePath>().onShortcut == true && GameControl.player3SCStartWaypoint + GameControl.diceSideThrown <= 3
                 && player3.GetComponent<FollowThePath>().passed1stShortcut == true && player3.GetComponent<FollowThePath>().passed2ndShortcut == false)
            {
                GameControl.ShortcutMovePlayer(3);

            }
            else
             if (player3.GetComponent<FollowThePath>().onShortcut == true && GameControl.player3SCStartWaypoint + GameControl.diceSideThrown <= 7
                 && player3.GetComponent<FollowThePath>().passed1stShortcut == true && player3.GetComponent<FollowThePath>().passed2ndShortcut == true)
            {
                GameControl.ShortcutMovePlayer(3);
            }
            else
             if (player3.GetComponent<FollowThePath>().onShortcut == true && GameControl.player3SCStartWaypoint + GameControl.diceSideThrown <= 11
                 && player3.GetComponent<FollowThePath>().passed1stShortcut == true && player3.GetComponent<FollowThePath>().passed2ndShortcut == true
                 && player3.GetComponent<FollowThePath>().passed3rdShortcut == true)
            {
                GameControl.ShortcutMovePlayer(3);
            }

            else
             if (player3.GetComponent<FollowThePath>().onShortcut == true && GameControl.player3SCStartWaypoint + GameControl.diceSideThrown > 3
                 && player3.GetComponent<FollowThePath>().passed1stShortcut == true && player3.GetComponent<FollowThePath>().passed2ndShortcut == false
                 && player3.GetComponent<FollowThePath>().passed3rdShortcut == false)
            {
                player3.GetComponent<FollowThePath>().StartwaypointIndex = player3.GetComponent<FollowThePath>().shortcutwaypointIndex + GameControl.diceSideThrown + 7;

                if (GameControl.player3StartWaypoint + GameControl.diceSideThrown > 13)
                {
                    player3.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                }


                GameControl.player3StartWaypoint = player3.GetComponent<FollowThePath>().StartwaypointIndex - GameControl.diceSideThrown;

                GameControl.MovePlayer(3);


                player3.GetComponent<FollowThePath>().moveAllowed = true;
                player3.GetComponent<FollowThePath>().onShortcut = false;


            }
            else
             if (player3.GetComponent<FollowThePath>().onShortcut == true && GameControl.player3SCStartWaypoint + GameControl.diceSideThrown > 7
                 && player3.GetComponent<FollowThePath>().passed1stShortcut == true && player3.GetComponent<FollowThePath>().passed2ndShortcut == true
                 && player3.GetComponent<FollowThePath>().passed3rdShortcut == false)
            {
                player3.GetComponent<FollowThePath>().StartwaypointIndex = player3.GetComponent<FollowThePath>().shortcutwaypointIndex + GameControl.diceSideThrown + 10;
                GameControl.player3StartWaypoint = player3.GetComponent<FollowThePath>().StartwaypointIndex - GameControl.diceSideThrown;

                GameControl.MovePlayer(3);

                player3.GetComponent<FollowThePath>().moveAllowed = true;
                player3.GetComponent<FollowThePath>().onShortcut = false;


            }
            else
             if (player3.GetComponent<FollowThePath>().onShortcut == true && GameControl.player3SCStartWaypoint + GameControl.diceSideThrown > 11
                 && player3.GetComponent<FollowThePath>().passed1stShortcut == true && player3.GetComponent<FollowThePath>().passed2ndShortcut == true
                 && player3.GetComponent<FollowThePath>().passed3rdShortcut == true)
            {
                player3.GetComponent<FollowThePath>().StartwaypointIndex = player3.GetComponent<FollowThePath>().waypoints.Length - 1;
                GameControl.player3StartWaypoint = player3.GetComponent<FollowThePath>().StartwaypointIndex;

                GameControl.MovePlayer(3);



                player3.GetComponent<FollowThePath>().moveAllowed = true;
                player3.GetComponent<FollowThePath>().onShortcut = false;


            }
            else
            {
                GameControl.MovePlayer(3);

            }






         }
         else 
         if (whosTurn == 4)        // switch player turns 
         {

            // GameControl.PlayerTurn(3);
            GameControl.whosturn = 4;

            if (player4.GetComponent<FollowThePath>().onShortcut == true && GameControl.player4SCStartWaypoint + GameControl.diceSideThrown <= 3
                 && player4.GetComponent<FollowThePath>().passed1stShortcut == true && player4.GetComponent<FollowThePath>().passed2ndShortcut == false)
            {
                GameControl.ShortcutMovePlayer(4);

            }
            else
             if (player4.GetComponent<FollowThePath>().onShortcut == true && GameControl.player4SCStartWaypoint + GameControl.diceSideThrown <= 7
                 && player4.GetComponent<FollowThePath>().passed1stShortcut == true && player4.GetComponent<FollowThePath>().passed2ndShortcut == true)
            {
                GameControl.ShortcutMovePlayer(4);
            }
            else
             if (player4.GetComponent<FollowThePath>().onShortcut == true && GameControl.player4SCStartWaypoint + GameControl.diceSideThrown <= 11
                 && player4.GetComponent<FollowThePath>().passed1stShortcut == true && player4.GetComponent<FollowThePath>().passed2ndShortcut == true
                 && player4.GetComponent<FollowThePath>().passed3rdShortcut == true)
            {
                GameControl.ShortcutMovePlayer(4);
            }

            else
             if (player4.GetComponent<FollowThePath>().onShortcut == true && GameControl.player4SCStartWaypoint + GameControl.diceSideThrown > 3
                 && player4.GetComponent<FollowThePath>().passed1stShortcut == true && player4.GetComponent<FollowThePath>().passed2ndShortcut == false
                 && player4.GetComponent<FollowThePath>().passed3rdShortcut == false)
            {
                player4.GetComponent<FollowThePath>().StartwaypointIndex = player4.GetComponent<FollowThePath>().shortcutwaypointIndex + GameControl.diceSideThrown + 7;

                if (GameControl.player4StartWaypoint + GameControl.diceSideThrown > 13)
                {
                    player4.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                }


                GameControl.player4StartWaypoint = player4.GetComponent<FollowThePath>().StartwaypointIndex - GameControl.diceSideThrown;

                GameControl.MovePlayer(4);


                player4.GetComponent<FollowThePath>().moveAllowed = true;
                player4.GetComponent<FollowThePath>().onShortcut = false;


            }
            else
             if (player4.GetComponent<FollowThePath>().onShortcut == true && GameControl.player4SCStartWaypoint + GameControl.diceSideThrown > 7
                 && player4.GetComponent<FollowThePath>().passed1stShortcut == true && player4.GetComponent<FollowThePath>().passed2ndShortcut == true
                 && player4.GetComponent<FollowThePath>().passed3rdShortcut == false)
            {
                player4.GetComponent<FollowThePath>().StartwaypointIndex = player4.GetComponent<FollowThePath>().shortcutwaypointIndex + GameControl.diceSideThrown + 10;
                GameControl.player4StartWaypoint = player4.GetComponent<FollowThePath>().StartwaypointIndex - GameControl.diceSideThrown;

                GameControl.MovePlayer(4);

                player4.GetComponent<FollowThePath>().moveAllowed = true;
                player4.GetComponent<FollowThePath>().onShortcut = false;


            }
            else
             if (player4.GetComponent<FollowThePath>().onShortcut == true && GameControl.player4SCStartWaypoint + GameControl.diceSideThrown > 11
                 && player4.GetComponent<FollowThePath>().passed1stShortcut == true && player4.GetComponent<FollowThePath>().passed2ndShortcut == true
                 && player4.GetComponent<FollowThePath>().passed3rdShortcut == true)
            {
                player4.GetComponent<FollowThePath>().StartwaypointIndex = player4.GetComponent<FollowThePath>().waypoints.Length - 1;
                GameControl.player4StartWaypoint = player4.GetComponent<FollowThePath>().StartwaypointIndex;

                GameControl.MovePlayer(4);



                player4.GetComponent<FollowThePath>().moveAllowed = true;
                player4.GetComponent<FollowThePath>().onShortcut = false;


             }
            else
            {
                GameControl.MovePlayer(4);

            }


         }
        else 
        if (whosTurn == 5)        // switch player turns 
        {

            // GameControl.PlayerTurn(5);
            GameControl.whosturn = 5;

            if (player5.GetComponent<FollowThePath>().onShortcut == true && GameControl.player5SCStartWaypoint + GameControl.diceSideThrown <= 3
                 && player5.GetComponent<FollowThePath>().passed1stShortcut == true && player5.GetComponent<FollowThePath>().passed2ndShortcut == false)
            {
                GameControl.ShortcutMovePlayer(5);

            }
            else
             if (player5.GetComponent<FollowThePath>().onShortcut == true && GameControl.player5SCStartWaypoint + GameControl.diceSideThrown <= 7
                 && player5.GetComponent<FollowThePath>().passed1stShortcut == true && player5.GetComponent<FollowThePath>().passed2ndShortcut == true)
            {
                GameControl.ShortcutMovePlayer(5);
            }
            else
             if (player5.GetComponent<FollowThePath>().onShortcut == true && GameControl.player5SCStartWaypoint + GameControl.diceSideThrown <= 11
                 && player5.GetComponent<FollowThePath>().passed1stShortcut == true && player5.GetComponent<FollowThePath>().passed2ndShortcut == true
                 && player5.GetComponent<FollowThePath>().passed3rdShortcut == true)
            {
                GameControl.ShortcutMovePlayer(5);
            }

            else
             if (player5.GetComponent<FollowThePath>().onShortcut == true && GameControl.player5SCStartWaypoint + GameControl.diceSideThrown > 3
                 && player5.GetComponent<FollowThePath>().passed1stShortcut == true && player5.GetComponent<FollowThePath>().passed2ndShortcut == false
                 && player5.GetComponent<FollowThePath>().passed3rdShortcut == false)
            {
                player5.GetComponent<FollowThePath>().StartwaypointIndex = player5.GetComponent<FollowThePath>().shortcutwaypointIndex + GameControl.diceSideThrown + 7;

                if (GameControl.player5StartWaypoint + GameControl.diceSideThrown > 13)
                {
                    player5.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                }


                GameControl.player5StartWaypoint = player5.GetComponent<FollowThePath>().StartwaypointIndex - GameControl.diceSideThrown;

                GameControl.MovePlayer(5);


                player5.GetComponent<FollowThePath>().moveAllowed = true;
                player5.GetComponent<FollowThePath>().onShortcut = false;


            }
            else
             if (player5.GetComponent<FollowThePath>().onShortcut == true && GameControl.player5SCStartWaypoint + GameControl.diceSideThrown > 7
                 && player5.GetComponent<FollowThePath>().passed1stShortcut == true && player5.GetComponent<FollowThePath>().passed2ndShortcut == true
                 && player5.GetComponent<FollowThePath>().passed3rdShortcut == false)
            {
                player5.GetComponent<FollowThePath>().StartwaypointIndex = player5.GetComponent<FollowThePath>().shortcutwaypointIndex + GameControl.diceSideThrown + 10;
                GameControl.player5StartWaypoint = player5.GetComponent<FollowThePath>().StartwaypointIndex - GameControl.diceSideThrown;

                GameControl.MovePlayer(5);

                player5.GetComponent<FollowThePath>().moveAllowed = true;
                player5.GetComponent<FollowThePath>().onShortcut = false;


            }
            else
             if (player5.GetComponent<FollowThePath>().onShortcut == true && GameControl.player5SCStartWaypoint + GameControl.diceSideThrown > 11
                 && player5.GetComponent<FollowThePath>().passed1stShortcut == true && player5.GetComponent<FollowThePath>().passed2ndShortcut == true
                 && player5.GetComponent<FollowThePath>().passed3rdShortcut == true)
            {
                player5.GetComponent<FollowThePath>().StartwaypointIndex = player5.GetComponent<FollowThePath>().waypoints.Length - 1;
                GameControl.player5StartWaypoint = player5.GetComponent<FollowThePath>().StartwaypointIndex;

                GameControl.MovePlayer(5);



                player5.GetComponent<FollowThePath>().moveAllowed = true;
                player5.GetComponent<FollowThePath>().onShortcut = false;


            }
            else
            {
                GameControl.MovePlayer(5);

            }
        }
        else 
        if (whosTurn == 6)        // switch player turns 
        {

            // GameControl.PlayerTurn(6);
            GameControl.whosturn = 6;

            if (player6.GetComponent<FollowThePath>().onShortcut == true && GameControl.player6SCStartWaypoint + GameControl.diceSideThrown <= 3
                 && player6.GetComponent<FollowThePath>().passed1stShortcut == true && player6.GetComponent<FollowThePath>().passed2ndShortcut == false)
            {
                GameControl.ShortcutMovePlayer(6);

            }
            else
             if (player6.GetComponent<FollowThePath>().onShortcut == true && GameControl.player6SCStartWaypoint + GameControl.diceSideThrown <= 7
                 && player6.GetComponent<FollowThePath>().passed1stShortcut == true && player6.GetComponent<FollowThePath>().passed2ndShortcut == true)
            {
                GameControl.ShortcutMovePlayer(6);
            }
            else
             if (player6.GetComponent<FollowThePath>().onShortcut == true && GameControl.player6SCStartWaypoint + GameControl.diceSideThrown <= 11
                 && player6.GetComponent<FollowThePath>().passed1stShortcut == true && player6.GetComponent<FollowThePath>().passed2ndShortcut == true
                 && player6.GetComponent<FollowThePath>().passed3rdShortcut == true)
            {
                GameControl.ShortcutMovePlayer(6);
            }

            else
             if (player6.GetComponent<FollowThePath>().onShortcut == true && GameControl.player6SCStartWaypoint + GameControl.diceSideThrown > 3
                 && player6.GetComponent<FollowThePath>().passed1stShortcut == true && player6.GetComponent<FollowThePath>().passed2ndShortcut == false
                 && player6.GetComponent<FollowThePath>().passed3rdShortcut == false)
            {
                player6.GetComponent<FollowThePath>().StartwaypointIndex = player6.GetComponent<FollowThePath>().shortcutwaypointIndex + GameControl.diceSideThrown + 7;

                if (GameControl.player6StartWaypoint + GameControl.diceSideThrown > 13)
                {
                    player6.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                }


                GameControl.player6StartWaypoint = player6.GetComponent<FollowThePath>().StartwaypointIndex - GameControl.diceSideThrown;

                GameControl.MovePlayer(6);


                player6.GetComponent<FollowThePath>().moveAllowed = true;
                player6.GetComponent<FollowThePath>().onShortcut = false;


            }
            else
             if (player6.GetComponent<FollowThePath>().onShortcut == true && GameControl.player6SCStartWaypoint + GameControl.diceSideThrown > 7
                 && player6.GetComponent<FollowThePath>().passed1stShortcut == true && player6.GetComponent<FollowThePath>().passed2ndShortcut == true
                 && player6.GetComponent<FollowThePath>().passed3rdShortcut == false)
            {
                player6.GetComponent<FollowThePath>().StartwaypointIndex = player6.GetComponent<FollowThePath>().shortcutwaypointIndex + GameControl.diceSideThrown + 10;
                GameControl.player6StartWaypoint = player6.GetComponent<FollowThePath>().StartwaypointIndex - GameControl.diceSideThrown;

                GameControl.MovePlayer(6);

                player6.GetComponent<FollowThePath>().moveAllowed = true;
                player6.GetComponent<FollowThePath>().onShortcut = false;


            }
            else
             if (player6.GetComponent<FollowThePath>().onShortcut == true && GameControl.player6SCStartWaypoint + GameControl.diceSideThrown > 11
                 && player6.GetComponent<FollowThePath>().passed1stShortcut == true && player6.GetComponent<FollowThePath>().passed2ndShortcut == true
                 && player6.GetComponent<FollowThePath>().passed3rdShortcut == true)
            {
                player6.GetComponent<FollowThePath>().StartwaypointIndex = player6.GetComponent<FollowThePath>().waypoints.Length - 1;
                GameControl.player6StartWaypoint = player6.GetComponent<FollowThePath>().StartwaypointIndex;

                GameControl.MovePlayer(6);



                player6.GetComponent<FollowThePath>().moveAllowed = true;
                player6.GetComponent<FollowThePath>().onShortcut = false;


            }
            else
            {
                GameControl.MovePlayer(6);

            }
        }





        if (whosTurn < GameControl.numofPlayers)
        {
            whosTurn += 1;
        }
        else
            whosTurn = 1;



        coroutineAllowed = true;
    }
}
