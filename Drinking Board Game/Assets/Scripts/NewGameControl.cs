using System.Collections;
using System.Collections.Generic;
// using UnityEditorInternal;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;

public class NewGameControl : MonoBehaviour
{

    public GameObject[] player;
    public GameObject[] playerIcon;
    public GameObject[] playermoveicon;

    public GameObject[] boardTiles;
    public GameObject[] boardTileBacks;
    public GameObject[] boardShortcutTiles;
    public GameObject[] boardShortcutTileBacks;

    public static GameObject whoWinsTextShadow, clicktocontinueText, TakeShortcutButton, DontTakeShortcutButton;

    public static int currentTile;

    public static int numofPlayers = 1;
    public static int diceSideThrown = 0;
    public static int currentPlayer = 0;

    public static int whosturn = 0;

    public bool flipOver = false;
    public static bool gameOver = false;
    
    public void Start()
    {
        // Setting normal tiles default state to off 
        for (int i = 0; i < boardTiles.Length; i++)
        {
            boardTiles[i].SetActive(true);
            boardTileBacks[i].SetActive(false);
        }

        // Setting shortcut tiles default state to off
        for (int i = 0; i < boardShortcutTiles.Length; i++)
        {
            boardShortcutTiles[i].SetActive(true);
            boardShortcutTileBacks[i].SetActive(false);
        }

        // Finding and setting player models and icons off as default
        for (int i = 0; i < player.Length; i++)
        {
            playerIcon[i].gameObject.SetActive(false);
            player[i].gameObject.SetActive(false);
            playermoveicon[i].gameObject.SetActive(false);
        }
        
        // Setting player movement to off as default 
        for (int i = 0; i < player.Length; i++)
        {
            player[i].GetComponent<FollowThePath>().moveAllowed = false;
            player[i].GetComponent<FollowThePath>().shortcutmoveAllowed = false;
            player[i].GetComponent<FollowThePath>().onShortcut = false;
            player[i].GetComponent<FollowThePath>().passed1stShortcut = false;
            player[i].GetComponent<FollowThePath>().StartWaypoint = 0;
            player[i].GetComponent<FollowThePath>().SCStartWaypoint = 0;

        }

        // Setting the players icons on for how many there are
        for (int i = 0; i < numofPlayers; i++)
        {
            playerIcon[i].gameObject.SetActive(true);
            player[i].gameObject.SetActive(true);
            playermoveicon[i].gameObject.SetActive(false);
        }

        // Start with player 1 move icon on  
        playermoveicon[0].gameObject.SetActive(true);

        // Finding Default buttons
        whoWinsTextShadow = GameObject.Find("WhoWinsText");
        clicktocontinueText = GameObject.Find("ClickBoxToContinue");
        TakeShortcutButton = GameObject.Find("TakeShortcutButton");
        DontTakeShortcutButton = GameObject.Find("DontTakeShortcutButton");

        // Default buttons and text turned off at start
        TakeShortcutButton.gameObject.SetActive(false);
        DontTakeShortcutButton.gameObject.SetActive(false);
        whoWinsTextShadow.gameObject.SetActive(false);
        clicktocontinueText.gameObject.SetActive(false);

    }

    
    public void Update()
    {
        
        // MOVE PLAYER 
        if (currentPlayer == whosturn && Dice.diceAllowed == false) // As long as the currentPlayer is whos turn it is and you recently clicked the dice...
        {
           
            if (player[currentPlayer].GetComponent<FollowThePath>().onShortcut == false && player[currentPlayer].GetComponent<FollowThePath>().moveAllowed == true) // If you arent on the shortcut...
            {
                if (player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex >
                player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown)
                {
                    // If you land on red flip a coin tile
                    if (player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown == 1)
                    {
                        ShowTile(0);
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex = 1;
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    }

                    // If you land on blue make a rule tile 
                    if (player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown == 2)
                    {
                        ShowTile(1);
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex = 2;
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex += 1;
                        
                    }

                    // If you land on orange categories tile 
                    if (player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown == 3)
                    {
                        ShowTile(2);
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex = 3;
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    }

                    // If you land on yellow shot for shortcut for the first time 
                    if (player[currentPlayer].GetComponent<FollowThePath>().passed1stShortcut == false)
                    {
                        if (player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown >= 4)
                        {
                            player[currentPlayer].GetComponent<FollowThePath>().transform.position = player[currentPlayer].GetComponent<FollowThePath>().waypoints[4].transform.position;

                            player[currentPlayer].GetComponent<FollowThePath>().passShortcutNormRoll = player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown + 1;
                            player[currentPlayer].GetComponent<FollowThePath>().passShortcutSCRoll = player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown - 4;

                            ChooseRoute(3);
                        }
                    }

                    // If you land on red guys drink tile 
                    if (player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown == 6)
                    {
                        ShowTile(4);
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex = 6;
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    }

                    // If you land on blue pick a mate tile
                    if (player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown == 7)
                    {
                        ShowTile(5);
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex = 7;
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    }

                    // If you land on green never have i ever tile
                    if (player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown == 8)
                    {
                        ShowTile(6);
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex = 8;
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    }


                    // If you land on orange prop hunt tile 
                    if (player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown == 9)
                    {
                        ShowTile(7);
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex = 9;
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    }


                    // If you land on red hold breath tile 
                    if (player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown == 10)
                    {
                        ShowTile(8);
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex = 10;
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    }


                    // If you land on blue girls drink
                    if (player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown == 11)
                    {
                        ShowTile(9);
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex = 11;
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    }


                    // If you land on 2nd yellow shot for shortcut for the first time 
                    if (player[currentPlayer].GetComponent<FollowThePath>().passed2ndShortcut == false)
                    {
                        if (player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown >= 12)
                        {
                            player[currentPlayer].GetComponent<FollowThePath>().transform.position = player[currentPlayer].GetComponent<FollowThePath>().waypoints[12].transform.position;

                            player[currentPlayer].GetComponent<FollowThePath>().passShortcutSCRoll = player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown - 8;
                            player[currentPlayer].GetComponent<FollowThePath>().passShortcutNormRoll = player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown + 1;

                            ChooseRoute(10);
                        }
                    }

                    // If you land on green guess a number tile
                    if (player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown == 14)
                    {
                        ShowTile(11);
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex = 14;
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    }


                    // If you land on orange drive tile
                    if (player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown == 15)
                    {
                        ShowTile(12);
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex = 15;
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    }


                    // If you land on red drink what you roll tile
                    if (player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown == 16)
                    {
                        ShowTile(13);
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex = 16;
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    }


                    // If you land on blue cascade tile
                    if (player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown == 17)
                    {
                        ShowTile(14);
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex = 17;
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    }


                    // If you land on green price is right tile 
                    if (player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown == 18)
                    {
                        ShowTile(15);
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex = 18;
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    }


                    // If you land on yellow shot for shortcut for the first time 
                    if (player[currentPlayer].GetComponent<FollowThePath>().passed3rdShortcut == false)
                    {
                        if (player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown >= 19)
                        {
                            player[currentPlayer].GetComponent<FollowThePath>().transform.position = player[currentPlayer].GetComponent<FollowThePath>().waypoints[19].transform.position;

                            player[currentPlayer].GetComponent<FollowThePath>().passShortcutSCRoll = player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown - 11;
                            player[currentPlayer].GetComponent<FollowThePath>().passShortcutNormRoll = player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown + 1;

                            ChooseRoute(16);
                        }
                    }


                    // If you land on green everyone take a shot tile 
                    if (player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown == 21)
                    {
                        ShowTile(17);
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex = 21;
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    }


                    // If you land on orange pick an age tile
                    if (player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown == 22)
                    {
                        ShowTile(18);
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex = 22;
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    }


                    // If you land on red pick a game tile 
                    if (player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown == 23)
                    {
                        ShowTile(19);
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex = 23;
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    }


                    // If you land on blue you and 2 tile 
                    if (player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown == 24)
                    {
                        ShowTile(20);
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex = 24;
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    }

                    player[currentPlayer].GetComponent<FollowThePath>().moveAllowed = false;

                    player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint = player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex - 1;

                    if (TakeShortcutButton.activeInHierarchy == false && DontTakeShortcutButton.activeInHierarchy == false) // Could use activeSelf here as well
                    {
                        NextPlayerMoveTexts();
                    }
                    
                }

                // END OF PLAYER NORAML ROUTE 
            }




            //// IF PLAYER IS ON THE SHORTCUT ////
            if (player[currentPlayer].GetComponent<FollowThePath>().onShortcut && player[currentPlayer].GetComponent<FollowThePath>().shortcutmoveAllowed) // If player is on the shortcut...
            {
                
                if (player[currentPlayer].GetComponent<FollowThePath>().shortcutwaypointIndex >
                player[currentPlayer].GetComponent<FollowThePath>().SCStartWaypoint + diceSideThrown) 
                {
                    // First spot when choosing the shortcut 
                    if (player[currentPlayer].GetComponent<FollowThePath>().SCStartWaypoint + diceSideThrown == 0)
                    {
                        player[currentPlayer].GetComponent<FollowThePath>().shortcutwaypointIndex = 0;
                        player[currentPlayer].GetComponent<FollowThePath>().shortcutwaypointIndex += 1;
                    }

                    // If you land on go back pink go back one
                    if (player[currentPlayer].GetComponent<FollowThePath>().SCStartWaypoint + diceSideThrown == 1)
                    {
                        ShowTile(0);

                        player[currentPlayer].GetComponent<FollowThePath>().transform.position = player[currentPlayer].GetComponent<FollowThePath>().waypoints[4].transform.position;

                        // player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex = 4;
                        player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint = 4;

                        player[currentPlayer].GetComponent<FollowThePath>().shortcutwaypointIndex = 0;
                        player[currentPlayer].GetComponent<FollowThePath>().SCStartWaypoint = 0;
                        
                        player[currentPlayer].GetComponent<FollowThePath>().passed1stShortcut = false;
                        player[currentPlayer].GetComponent<FollowThePath>().onShortcut = false;
                        player[currentPlayer].GetComponent<FollowThePath>().onShortcutTile = false;

                        diceSideThrown = 0;
                    }


                    // If you land on pink waterfall 
                    if (player[currentPlayer].GetComponent<FollowThePath>().SCStartWaypoint + diceSideThrown == 2)
                    {
                        ShowTile(1);
                        player[currentPlayer].GetComponent<FollowThePath>().shortcutwaypointIndex = 2;
                        player[currentPlayer].GetComponent<FollowThePath>().shortcutwaypointIndex += 1;
                    }

                    // If you land on pink take a half shot 
                    if (player[currentPlayer].GetComponent<FollowThePath>().SCStartWaypoint + diceSideThrown == 3)
                    {
                        ShowTile(2);
                        player[currentPlayer].GetComponent<FollowThePath>().shortcutwaypointIndex = 3;
                        player[currentPlayer].GetComponent<FollowThePath>().shortcutwaypointIndex += 1;
                    }



                    // If you land on pink return to start
                    if (player[currentPlayer].GetComponent<FollowThePath>().SCStartWaypoint + diceSideThrown == 5)
                    {
                        ShowTile(3);
                        player[currentPlayer].GetComponent<FollowThePath>().transform.position = player[currentPlayer].GetComponent<FollowThePath>().waypoints[0].transform.position;

                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex = 0;
                        player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint = 0;

                        player[currentPlayer].GetComponent<FollowThePath>().shortcutwaypointIndex = 0;
                        player[currentPlayer].GetComponent<FollowThePath>().SCStartWaypoint = 0;

                        player[currentPlayer].GetComponent<FollowThePath>().passed1stShortcut = false;
                        player[currentPlayer].GetComponent<FollowThePath>().passed2ndShortcut = false;
                        player[currentPlayer].GetComponent<FollowThePath>().passed3rdShortcut = false;

                        player[currentPlayer].GetComponent<FollowThePath>().onShortcut = false;
                        player[currentPlayer].GetComponent<FollowThePath>().onShortcutTile = false;

                    }


                    // If you land on pink make a rule tile 
                    if (player[currentPlayer].GetComponent<FollowThePath>().SCStartWaypoint + diceSideThrown == 6)
                    {
                        ShowTile(4);
                        player[currentPlayer].GetComponent<FollowThePath>().shortcutwaypointIndex = 6;
                        player[currentPlayer].GetComponent<FollowThePath>().shortcutwaypointIndex += 1;
                    }


                    // If you land on pink take and give 3 tile 
                    if (player[currentPlayer].GetComponent<FollowThePath>().SCStartWaypoint + diceSideThrown == 7)
                    {
                        ShowTile(5);
                        player[currentPlayer].GetComponent<FollowThePath>().shortcutwaypointIndex = 7;
                        player[currentPlayer].GetComponent<FollowThePath>().shortcutwaypointIndex += 1;
                    }


                    // If you land on pink take another shot tile 
                    if (player[currentPlayer].GetComponent<FollowThePath>().SCStartWaypoint + diceSideThrown == 9)
                    {
                        ShowTile(6);
                        player[currentPlayer].GetComponent<FollowThePath>().shortcutwaypointIndex = 9;
                        player[currentPlayer].GetComponent<FollowThePath>().shortcutwaypointIndex += 1;
                    }


                    // If you land on pink go back and give a shot tile 
                    if (player[currentPlayer].GetComponent<FollowThePath>().SCStartWaypoint + diceSideThrown == 10)
                    {
                        ShowTile(7);
                        player[currentPlayer].GetComponent<FollowThePath>().transform.position = player[currentPlayer].GetComponent<FollowThePath>().shortcutwaypoints[9].transform.position;
                        player[currentPlayer].GetComponent<FollowThePath>().shortcutwaypointIndex = 9;
                        player[currentPlayer].GetComponent<FollowThePath>().shortcutwaypointIndex += 1;
                    }



                    // If you land on pink finish drink tile 
                    if (player[currentPlayer].GetComponent<FollowThePath>().SCStartWaypoint + diceSideThrown == 11)
                    {
                        ShowTile(8);
                        player[currentPlayer].GetComponent<FollowThePath>().shortcutwaypointIndex = 11;
                        player[currentPlayer].GetComponent<FollowThePath>().shortcutwaypointIndex += 1;
                    }

                    player[currentPlayer].GetComponent<FollowThePath>().moveAllowed = false;
                    player[currentPlayer].GetComponent<FollowThePath>().shortcutmoveAllowed = false;

                    player[currentPlayer].GetComponent<FollowThePath>().shortcutwaypointIndex -= 1;
                    player[currentPlayer].GetComponent<FollowThePath>().SCStartWaypoint = player[currentPlayer].GetComponent<FollowThePath>().shortcutwaypointIndex;

                    if (TakeShortcutButton.activeInHierarchy == false && DontTakeShortcutButton.activeInHierarchy == false)
                    {
                        NextPlayerMoveTexts();
                    }
                    
                }

            }
            
        }


        // IF PLAYER WINS 
        if (player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex ==
          player[currentPlayer].GetComponent<FollowThePath>().waypoints.Length)
        {
            whoWinsTextShadow.gameObject.SetActive(true);
            for (int i = 0; i < numofPlayers; i++)
            {
                playermoveicon[i].gameObject.SetActive(false);
            }

            currentPlayer += 1;
            whoWinsTextShadow.GetComponent<Text>().text = "Player 0 Wins";
            whoWinsTextShadow.GetComponent<Text>().text = whoWinsTextShadow.GetComponent<Text>().text.Replace("0", currentPlayer.ToString());
            gameOver = true;
        }

        ///// END OF UPDATE FUNCTION /////
    }

    // Determines whether to move on shortcut or normal route when youre rolling onto shortcut or off shortcut as well as the movements inbetween shortcuts
    public void DiceClickMove()
    {
        if (player[currentPlayer].GetComponent<FollowThePath>().onShortcut  == true && player[currentPlayer].GetComponent<FollowThePath>().SCStartWaypoint + diceSideThrown <= 3
        && player[currentPlayer].GetComponent<FollowThePath>().passed1stShortcut == true && player[currentPlayer].GetComponent<FollowThePath>().passed2ndShortcut == false)
        {

            ShortcutMovePlayer();

        }else if (player[currentPlayer].GetComponent<FollowThePath>().onShortcut == true && player[currentPlayer].GetComponent<FollowThePath>().SCStartWaypoint + diceSideThrown <= 7
                && player[currentPlayer].GetComponent<FollowThePath>().passed1stShortcut == true && player[currentPlayer].GetComponent<FollowThePath>().passed2ndShortcut == true)
              {

                    ShortcutMovePlayer();

              }else if (player[currentPlayer].GetComponent<FollowThePath>().onShortcut == true && player[currentPlayer].GetComponent<FollowThePath>().SCStartWaypoint + diceSideThrown <= 11
                && player[currentPlayer].GetComponent<FollowThePath>().passed1stShortcut == true && player[currentPlayer].GetComponent<FollowThePath>().passed2ndShortcut == true
                && player[currentPlayer].GetComponent<FollowThePath>().passed3rdShortcut == true)
                    {

                        ShortcutMovePlayer();

                    }else if (player[currentPlayer].GetComponent<FollowThePath>().onShortcut == true && player[currentPlayer].GetComponent<FollowThePath>().SCStartWaypoint + diceSideThrown > 3
                        && player[currentPlayer].GetComponent<FollowThePath>().passed1stShortcut == true && player[currentPlayer].GetComponent<FollowThePath>().passed2ndShortcut == false
                        && player[currentPlayer].GetComponent<FollowThePath>().passed3rdShortcut == false)
                           {
                                player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex = player[currentPlayer].GetComponent<FollowThePath>().shortcutwaypointIndex + diceSideThrown + 7;

                                if (player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown > 13)
                                {
                                    player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex += 1;
                                }

                                player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint = player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex - diceSideThrown;

                                MovePlayer();

                                player[currentPlayer].GetComponent<FollowThePath>().onShortcut = false;

                          }else if (player[currentPlayer].GetComponent<FollowThePath>().onShortcut == true && player[currentPlayer].GetComponent<FollowThePath>().SCStartWaypoint + diceSideThrown > 7
                                && player[currentPlayer].GetComponent<FollowThePath>().passed1stShortcut == true && player[currentPlayer].GetComponent<FollowThePath>().passed2ndShortcut == true
                                && player[currentPlayer].GetComponent<FollowThePath>().passed3rdShortcut == false)
                                {
                                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex = player[currentPlayer].GetComponent<FollowThePath>().shortcutwaypointIndex + diceSideThrown + 10;
                                        player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint = player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex - diceSideThrown;

                                        MovePlayer();

                                        player[currentPlayer].GetComponent<FollowThePath>().onShortcut = false;

                                }else if (player[currentPlayer].GetComponent<FollowThePath>().onShortcut == true && player[currentPlayer].GetComponent<FollowThePath>().SCStartWaypoint + diceSideThrown > 11
                                        && player[currentPlayer].GetComponent<FollowThePath>().passed1stShortcut == true && player[currentPlayer].GetComponent<FollowThePath>().passed2ndShortcut == true
                                        && player[currentPlayer].GetComponent<FollowThePath>().passed3rdShortcut == true)
                                      {
                                                player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex = player[currentPlayer].GetComponent<FollowThePath>().waypoints.Length - 1;
                                                player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint = player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex;

                                                MovePlayer();

                                                player[currentPlayer].GetComponent<FollowThePath>().onShortcut = false;

                                      }else
                                      {
                                          MovePlayer();
                                      }

        Dice.diceAllowed = false;

    }

    public void MovePlayer()
    {
        player[currentPlayer].GetComponent<FollowThePath>().moveAllowed = true;
    }

    public void ShortcutMovePlayer()
    {
        player[currentPlayer].GetComponent<FollowThePath>().shortcutmoveAllowed = true;
    }

    public void NextPlayerMoveTexts()
    {
        playermoveicon[currentPlayer].gameObject.SetActive(false);

        if (currentPlayer < numofPlayers - 1 && Dice.diceAllowed == false)
        {
            whosturn += 1;
            playermoveicon[whosturn].gameObject.SetActive(true);
        }
        else
        {
            whosturn = 0;
            playermoveicon[whosturn].gameObject.SetActive(true);
        }

        Dice.diceAllowed = true;
    }

    // Shows and flips the tile you land on
    public void ShowTile(int tile)
    {
        currentTile = tile;

        // As long as the shotforshortcut tile isnt showing the other tiles can be flipped and shown
        if (player[currentPlayer].GetComponent<FollowThePath>().LandedOnTile)
        {
            if (player[currentPlayer].GetComponent<FollowThePath>().onShortcutTile == false)
            {
                if (player[currentPlayer].GetComponent<FollowThePath>().onShortcut)
                {
                    boardShortcutTiles[tile].GetComponent<TileController>().StartFlip();
                    boardShortcutTiles[tile].GetComponent<TileController>().moveToMiddleAllowed = true;
                    player[currentPlayer].GetComponent<FollowThePath>().LandedOnTile = false;
                }
                else
                {
                    boardTiles[tile].GetComponent<TileController>().StartFlip();
                    boardTiles[tile].GetComponent<TileController>().moveToMiddleAllowed = true;
                    player[currentPlayer].GetComponent<FollowThePath>().LandedOnTile = false;
                }
            }
        }
        
    }


    // On mouse click will clear board of any boardtiles showing
    public void OnMouseDown()
    {
        clicktocontinueText.gameObject.SetActive(false);

        // Version 4
        if (player[currentPlayer].GetComponent<FollowThePath>().LandedOnTile == false && player[currentPlayer].GetComponent<FollowThePath>().onShortcutTile == false)
        {
            if (player[currentPlayer].GetComponent<FollowThePath>().onShortcut == false && boardTiles[currentTile].GetComponent<TileController>().tileBackisactive)
            {
                boardTiles[currentTile].GetComponent<TileController>().StartFlip();
                boardTiles[currentTile].GetComponent<TileController>().moveToOriginAllowed = true;
                player[currentPlayer].GetComponent<FollowThePath>().LandedOnTile = true;
            }
            else if (player[currentPlayer].GetComponent<FollowThePath>().onShortcut && boardShortcutTiles[currentTile].GetComponent<TileController>().tileBackisactive) 
            {
                boardShortcutTiles[currentTile].GetComponent<TileController>().StartFlip();
                boardShortcutTiles[currentTile].GetComponent<TileController>().moveToOriginAllowed = true;
                player[currentPlayer].GetComponent<FollowThePath>().LandedOnTile = true;
            }
            else if (boardShortcutTiles[currentTile].GetComponent<TileController>().tileBackisactive)
            {
                boardShortcutTiles[currentTile].GetComponent<TileController>().StartFlip();
                boardShortcutTiles[currentTile].GetComponent<TileController>().moveToOriginAllowed = true;
                player[currentPlayer].GetComponent<FollowThePath>().LandedOnTile = true;
            }
            else
            {
                return;
            }
            
        }
            
    }

    // When player is on shortcut tile choosing whether or not to take the shortcut
    public void ChooseRoute(int tile)
    {
        TakeShortcutButton.gameObject.SetActive(true);
        DontTakeShortcutButton.gameObject.SetActive(true);
        boardTileBacks[tile].SetActive(true);
        player[currentPlayer].GetComponent<FollowThePath>().onShortcutTile = true;
    }

    // Shortcut buttons
    public void TakeShortcut()
    {
        // We set the shortcutwaypointIndex here so we dont actually move passed the shotforshortcut tile before we choose which route to go
        player[currentPlayer].GetComponent<FollowThePath>().shortcutwaypointIndex = player[currentPlayer].GetComponent<FollowThePath>().passShortcutSCRoll;
        player[currentPlayer].GetComponent<FollowThePath>().SCStartWaypoint = player[currentPlayer].GetComponent<FollowThePath>().shortcutwaypointIndex - diceSideThrown;

        // Now player is onShortcut and moved off the shortcut tile
        player[currentPlayer].GetComponent<FollowThePath>().onShortcut = true;
        player[currentPlayer].GetComponent<FollowThePath>().onShortcutTile = false;

        // Sets the buttons to inactive after being pressed
        TakeShortcutButton.gameObject.SetActive(false);
        DontTakeShortcutButton.gameObject.SetActive(false);

        // If player is choosing from the 1st choose a shortcut tile
        if (player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown >= 4 && player[currentPlayer].GetComponent<FollowThePath>().passed1stShortcut == false)
        {
            // Player did pass 1st shortcut after button press and sets the tile inactive
            player[currentPlayer].GetComponent<FollowThePath>().passed1stShortcut = true;
            boardTileBacks[3].SetActive(false);

            // If players roll from the shortcut is passing all shortcut tiles ELSE move onto shortcut
            if (player[currentPlayer].GetComponent<FollowThePath>().SCStartWaypoint + diceSideThrown > 3)
            {
                player[currentPlayer].GetComponent<FollowThePath>().onShortcut = false;
                player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex = player[currentPlayer].GetComponent<FollowThePath>().passShortcutNormRoll + 2;
                player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint = player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex - diceSideThrown;
                MovePlayer();
            }else
            {
                ShortcutMovePlayer();
            }
        }

        // If player is choosing from the 2nd choose a shortcut tile
        if (player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown >= 12 && player[currentPlayer].GetComponent<FollowThePath>().passed2ndShortcut == false)
        {
            // Player did pass 2nd shortcut after button press and sets the tile inactive
            player[currentPlayer].GetComponent<FollowThePath>().passed2ndShortcut = true;
            boardTileBacks[10].SetActive(false);

            // If players roll from the shortcut is passing all shortcut tiles ELSE move onto shortcut
            if (player[currentPlayer].GetComponent<FollowThePath>().SCStartWaypoint + diceSideThrown > 7)
            {
                player[currentPlayer].GetComponent<FollowThePath>().onShortcut = false;
                player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex = player[currentPlayer].GetComponent<FollowThePath>().passShortcutNormRoll + 1;
                player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint = player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex - diceSideThrown;
                MovePlayer();
            }else
            {
                ShortcutMovePlayer();
            }
        }

        // If player is choosing from the 3rd choose a shortcut tile
        if (player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown >= 19 && player[currentPlayer].GetComponent<FollowThePath>().passed3rdShortcut == false)
        {
            // Player did pass 3rd shortcut after button press and sets the tile inactive
            player[currentPlayer].GetComponent<FollowThePath>().passed3rdShortcut = true;
            boardTileBacks[16].SetActive(false);

            ShortcutMovePlayer();
        }

        clicktocontinueText.SetActive(false);

    }

    public void DontTakeShortcut()
    {
        // Sets the StartwaypointIndex here so we dont pass the shotforshortcuttile before we choose our route
        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex = player[currentPlayer].GetComponent<FollowThePath>().passShortcutNormRoll;
        player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint = player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex - diceSideThrown;

        // Player chooses not to be on shortcut and moves off the shortcut tile
        player[currentPlayer].GetComponent<FollowThePath>().onShortcut = false;
        player[currentPlayer].GetComponent<FollowThePath>().onShortcutTile = false;

        // Sets the buttons to inactive after being pressed
        TakeShortcutButton.gameObject.SetActive(false);
        DontTakeShortcutButton.gameObject.SetActive(false);

        if (player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown >= 4)
        {
            player[currentPlayer].GetComponent<FollowThePath>().passed1stShortcut = true;
            boardTileBacks[3].SetActive(false);
        }

        if (player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown >= 12)
        {
            player[currentPlayer].GetComponent<FollowThePath>().passed2ndShortcut = true;
            boardTileBacks[10].SetActive(false);
        }

        if (player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown >= 19)
        {
            player[currentPlayer].GetComponent<FollowThePath>().passed3rdShortcut = true;
            boardTileBacks[16].SetActive(false);
        }

        // Allows player to move after clicking DontTakeShortcut button and sets clicktocontinue text inactive
        MovePlayer();
        clicktocontinueText.SetActive(false);
    }

    // Quit Game button
    public void QuitGame()
    {
        Application.Quit();
    }

}
