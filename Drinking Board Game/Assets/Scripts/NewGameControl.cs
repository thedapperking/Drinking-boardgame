using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewGameControl : MonoBehaviour
{

    public GameObject[] player;
    public GameObject[] playerIcon;
    public GameObject[] playermoveicon;

    private static GameObject whoWinsTextShadow, clicktocontinueText, TakeShortcutButton, DontTakeShortcutButton;

    public GameObject redFlipacointile, blueMakearuletile, orangeCategoriestile, shotforshortcutTile, pinkGobackonetile, pinkWaterfalltile, pinkTakehalfshottile,
        redGuysdrinktile, bluePickamatetile, greenNeverhaveievertile, orangeProphunttile, redHoldbreathtile, blueGirlsdrinktile, pinkReturntostarttile, pinkMakearuletile,
        pinkTakeandgive3tile, greenGuessanumbertile, orangeDrivetile, redDrinkwhatyourolltile, blueCascadetile, greenPriceisrighttile, pinkTakeanothershottile,
        pinkGobackandgiveashottile, pinkFinishdrinktile, greenEveryonetakeashottile, orangePickanagetile, redPickagametile, blueYouand2tile;

    public static int numofPlayers = 1;
    public static int diceSideThrown = 0;
    public static int currentPlayer = 0;

    public static int whosturn = 0;

    public static bool gameOver = false;
    

    // public GameObject Players;
    public void Start()
    {
        
        redFlipacointile = GameObject.Find("redFlipacointile");
        blueMakearuletile = GameObject.Find("blueMakearuletile");
        orangeCategoriestile = GameObject.Find("orangeCategoriestile");
        shotforshortcutTile = GameObject.Find("shotforshortcutTile");
        pinkGobackonetile = GameObject.Find("pinkGobackonetile");
        pinkWaterfalltile = GameObject.Find("pinkWaterfalltile");
        pinkTakehalfshottile = GameObject.Find("pinkTakehalfshottile");
        redGuysdrinktile = GameObject.Find("redGuysdrinktile");
        bluePickamatetile = GameObject.Find("bluePickamatetile");
        greenNeverhaveievertile = GameObject.Find("greenNeverhaveievertile");
        orangeProphunttile = GameObject.Find("orangeProphunttile");
        redHoldbreathtile = GameObject.Find("redHoldbreathtile");
        blueGirlsdrinktile = GameObject.Find("blueGirlsdrinktile");
        pinkReturntostarttile = GameObject.Find("pinkReturntostarttile");
        pinkMakearuletile = GameObject.Find("pinkMakearuletile");
        pinkTakeandgive3tile = GameObject.Find("pinkTakeandgive3tile");
        greenGuessanumbertile = GameObject.Find("greenGuessanumbertile");
        orangeDrivetile = GameObject.Find("orangeDrivetile");
        redDrinkwhatyourolltile = GameObject.Find("redDrinkwhatyourolltile");
        blueCascadetile = GameObject.Find("blueCascadetile");
        greenPriceisrighttile = GameObject.Find("greenPriceisrighttile");
        pinkTakeanothershottile = GameObject.Find("pinkTakeanothershottile");
        pinkGobackandgiveashottile = GameObject.Find("pinkGobackandgiveashottile");
        pinkFinishdrinktile = GameObject.Find("pinkFinishdrinktile");
        greenEveryonetakeashottile = GameObject.Find("greenEveryonetakeashottile");
        orangePickanagetile = GameObject.Find("orangePickanagetile");
        redPickagametile = GameObject.Find("redPickagametile");
        blueYouand2tile = GameObject.Find("blueYouand2tile");

        whoWinsTextShadow = GameObject.Find("WhoWinsText");
        clicktocontinueText = GameObject.Find("ClickBoxToContinue");
        TakeShortcutButton = GameObject.Find("TakeShortcutButton");
        DontTakeShortcutButton = GameObject.Find("DontTakeShortcutButton");

        
        for (int i = 0; i < player.Length; i++)
        {
            playerIcon[i].gameObject.SetActive(false);
            player[i].gameObject.SetActive(false);
            playermoveicon[i].gameObject.SetActive(false);
        }
        

        for (int i = 0; i < player.Length; i++)
        {
            player[i].GetComponent<FollowThePath>().moveAllowed = false;
            player[i].GetComponent<FollowThePath>().shortcutmoveAllowed = false;
            player[i].GetComponent<FollowThePath>().onShortcut = false;
            player[i].GetComponent<FollowThePath>().passed1stShortcut = false;
            player[i].GetComponent<FollowThePath>().StartWaypoint = 0;
            player[i].GetComponent<FollowThePath>().SCStartWaypoint = 0;
        }

        
        for (int i = 0; i < numofPlayers; i++)
        {
            playerIcon[i].gameObject.SetActive(true);
            player[i].gameObject.SetActive(true);
            playermoveicon[i].gameObject.SetActive(false);

            player[i].GetComponent<FollowThePath>().moveAllowed = false;
            player[i].GetComponent<FollowThePath>().shortcutmoveAllowed = false;
            player[i].GetComponent<FollowThePath>().onShortcut = false;
            player[i].GetComponent<FollowThePath>().passed1stShortcut = false;
            player[i].GetComponent<FollowThePath>().StartWaypoint = 0;
            player[i].GetComponent<FollowThePath>().SCStartWaypoint = 0;
        }

        playermoveicon[0].gameObject.SetActive(true);
        
        


        // Initial start of game event tiles showing
        redFlipacointile.gameObject.SetActive(false);
        blueMakearuletile.gameObject.SetActive(false);
        orangeCategoriestile.gameObject.SetActive(false);
        shotforshortcutTile.gameObject.SetActive(false);
        pinkGobackonetile.gameObject.SetActive(false);
        pinkWaterfalltile.gameObject.SetActive(false);
        pinkTakehalfshottile.gameObject.SetActive(false);
        redGuysdrinktile.gameObject.SetActive(false);
        bluePickamatetile.gameObject.SetActive(false);
        greenNeverhaveievertile.gameObject.SetActive(false);
        orangeProphunttile.gameObject.SetActive(false);
        redHoldbreathtile.gameObject.SetActive(false);
        blueGirlsdrinktile.gameObject.SetActive(false);
        pinkReturntostarttile.gameObject.SetActive(false);
        pinkMakearuletile.gameObject.SetActive(false);
        pinkTakeandgive3tile.gameObject.SetActive(false);
        greenGuessanumbertile.gameObject.SetActive(false);
        orangeDrivetile.gameObject.SetActive(false);
        redDrinkwhatyourolltile.gameObject.SetActive(false);
        blueCascadetile.gameObject.SetActive(false);
        greenPriceisrighttile.gameObject.SetActive(false);
        pinkTakeanothershottile.gameObject.SetActive(false);
        pinkGobackandgiveashottile.gameObject.SetActive(false);
        pinkFinishdrinktile.gameObject.SetActive(false);
        greenEveryonetakeashottile.gameObject.SetActive(false);
        orangePickanagetile.gameObject.SetActive(false);
        redPickagametile.gameObject.SetActive(false);
        blueYouand2tile.gameObject.SetActive(false);

        TakeShortcutButton.gameObject.SetActive(false);
        DontTakeShortcutButton.gameObject.SetActive(false);
        whoWinsTextShadow.gameObject.SetActive(false);
        clicktocontinueText.gameObject.SetActive(false);

        // Debug.Log("start is working");
    }

    
    public void Update()
    {
        
        // MOVE PLAYER 
        if (currentPlayer == whosturn && Dice.diceAllowed == false)
        {
           
            if (player[currentPlayer].GetComponent<FollowThePath>().onShortcut == false) // && whosturn == currentPlayer) 
            {
                if (player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex >
                player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown)
                {
                    // If you land on red flip a coin tile
                    if (player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown == 1)
                    {
                        redFlipacointile.gameObject.SetActive(true);
                        clicktocontinueText.gameObject.SetActive(true);
                        player[currentPlayer].GetComponent<FollowThePath>().transform.position = player[currentPlayer].GetComponent<FollowThePath>().transform.position;
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex = 1;
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex += 1;
                        MovePlayer();
                    }

                    // If you land on blue make a rule tile 
                    if (player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown == 2)
                    {
                        blueMakearuletile.gameObject.SetActive(true);
                        clicktocontinueText.gameObject.SetActive(true);
                        player[currentPlayer].GetComponent<FollowThePath>().transform.position = player[currentPlayer].GetComponent<FollowThePath>().waypoints[2].transform.position;
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex = 2;
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex += 1;
                        MovePlayer();
                        
                    }

                    // If you land on orange categories tile 
                    if (player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown == 3)
                    {
                        orangeCategoriestile.gameObject.SetActive(true);
                        clicktocontinueText.gameObject.SetActive(true);
                        player[currentPlayer].GetComponent<FollowThePath>().transform.position = player[currentPlayer].GetComponent<FollowThePath>().waypoints[3].transform.position;
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex = 3;
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex += 1;
                        MovePlayer();
                    }

                    // If you land on yellow shot for shortcut for the first time 
                    if (player[currentPlayer].GetComponent<FollowThePath>().passed1stShortcut == false && player[currentPlayer].GetComponent<FollowThePath>().onShortcut == false)
                    {
                        if (player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown >= 4)
                        {
                            shotforshortcutTile.gameObject.SetActive(true);

                            player[currentPlayer].GetComponent<FollowThePath>().transform.position = player[currentPlayer].GetComponent<FollowThePath>().waypoints[4].transform.position;

                            player[currentPlayer].GetComponent<FollowThePath>().shortcutwaypointIndex = player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown - 4;
                            player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex = player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown + 1;

                            player[currentPlayer].GetComponent<FollowThePath>().onShortcut = true;
                            player[currentPlayer].GetComponent<FollowThePath>().passed1stShortcut = true;

                            ChooseRoute();

                        }
                    }

                    // If you land on red guys drink tile 
                    if (player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown == 6 && player[currentPlayer].GetComponent<FollowThePath>().passed1stShortcut == true)
                    {
                        redGuysdrinktile.gameObject.SetActive(true);
                        clicktocontinueText.gameObject.SetActive(true);
                        player[currentPlayer].GetComponent<FollowThePath>().transform.position = player[currentPlayer].GetComponent<FollowThePath>().waypoints[6].transform.position;
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex = 6;
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex += 1;
                        MovePlayer();
                    }


                    // If you land on blue pick a mate tile
                    if (player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown == 7)
                    {
                        bluePickamatetile.gameObject.SetActive(true);
                        clicktocontinueText.gameObject.SetActive(true);
                        player[currentPlayer].GetComponent<FollowThePath>().transform.position = player[currentPlayer].GetComponent<FollowThePath>().waypoints[7].transform.position;
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex = 7;
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex += 1;
                        MovePlayer();
                    }

                    // If you land on green never have i ever tile
                    if (player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown == 8)
                    {
                        greenNeverhaveievertile.gameObject.SetActive(true);
                        clicktocontinueText.gameObject.SetActive(true);
                        player[currentPlayer].GetComponent<FollowThePath>().transform.position = player[currentPlayer].GetComponent<FollowThePath>().waypoints[8].transform.position;
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex = 8;
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex += 1;
                        MovePlayer();
                    }


                    // If you land on orange prop hunt tile 
                    if (player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown == 9)
                    {
                        orangeProphunttile.gameObject.SetActive(true);
                        clicktocontinueText.gameObject.SetActive(true);
                        player[currentPlayer].GetComponent<FollowThePath>().transform.position = player[currentPlayer].GetComponent<FollowThePath>().waypoints[9].transform.position;
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex = 9;
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex += 1;
                        MovePlayer();
                    }


                    // If you land on red hold breath tile 
                    if (player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown == 10)
                    {
                        redHoldbreathtile.gameObject.SetActive(true);
                        clicktocontinueText.gameObject.SetActive(true);
                        player[currentPlayer].GetComponent<FollowThePath>().transform.position = player[currentPlayer].GetComponent<FollowThePath>().waypoints[10].transform.position;
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex = 10;
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex += 1;
                        MovePlayer();
                    }


                    // If you land on blue girls drink
                    if (player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown == 11)
                    {
                        blueGirlsdrinktile.gameObject.SetActive(true);
                        clicktocontinueText.gameObject.SetActive(true);

                        player[currentPlayer].GetComponent<FollowThePath>().transform.position = player[currentPlayer].GetComponent<FollowThePath>().waypoints[11].transform.position;
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex = 11;
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex += 1;
                        MovePlayer();
                    }


                    // If you land on yellow shot for shortcut for the first time 
                    if (player[currentPlayer].GetComponent<FollowThePath>().passed2ndShortcut == false)
                    {
                        if (player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown >= 12)
                        {
                            shotforshortcutTile.gameObject.SetActive(true);
                            player[currentPlayer].GetComponent<FollowThePath>().transform.position = player[currentPlayer].GetComponent<FollowThePath>().waypoints[12].transform.position;

                            player[currentPlayer].GetComponent<FollowThePath>().shortcutwaypointIndex = player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown - 8;
                            player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex = player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown + 1;

                            ChooseRoute();

                            player[currentPlayer].GetComponent<FollowThePath>().passed2ndShortcut = true;
                        }
                    }



                    // If you land on green guess a number tile
                    if (player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown == 14)
                    {
                        greenGuessanumbertile.gameObject.SetActive(true);
                        clicktocontinueText.gameObject.SetActive(true);
                        player[currentPlayer].GetComponent<FollowThePath>().transform.position = player[currentPlayer].GetComponent<FollowThePath>().waypoints[14].transform.position;
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex = 14;
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex += 1;
                        MovePlayer();
                    }


                    // If you land on orange drive tile
                    if (player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown == 15)
                    {
                        orangeDrivetile.gameObject.SetActive(true);
                        clicktocontinueText.gameObject.SetActive(true);
                        player[currentPlayer].GetComponent<FollowThePath>().transform.position = player[currentPlayer].GetComponent<FollowThePath>().waypoints[15].transform.position;
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex = 15;
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex += 1;
                        MovePlayer();
                    }


                    // If you land on red drink what you roll tile
                    if (player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown == 16)
                    {
                        redDrinkwhatyourolltile.gameObject.SetActive(true);
                        clicktocontinueText.gameObject.SetActive(true);
                        player[currentPlayer].GetComponent<FollowThePath>().transform.position = player[currentPlayer].GetComponent<FollowThePath>().waypoints[16].transform.position;
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex = 16;
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex += 1;
                        MovePlayer();
                    }


                    // If you land on blue cascade tile
                    if (player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown == 17)
                    {
                        blueCascadetile.gameObject.SetActive(true);
                        clicktocontinueText.gameObject.SetActive(true);
                        player[currentPlayer].GetComponent<FollowThePath>().transform.position = player[currentPlayer].GetComponent<FollowThePath>().waypoints[17].transform.position;
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex = 17;
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex += 1;
                        MovePlayer();
                    }


                    // If you land on green price is right tile 
                    if (player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown == 18)
                    {
                        greenPriceisrighttile.gameObject.SetActive(true);
                        clicktocontinueText.gameObject.SetActive(true);
                        player[currentPlayer].GetComponent<FollowThePath>().transform.position = player[currentPlayer].GetComponent<FollowThePath>().waypoints[18].transform.position;
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex = 18;
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex += 1;
                        MovePlayer();
                    }


                    // If you land on yellow shot for shortcut for the first time 
                    if (player[currentPlayer].GetComponent<FollowThePath>().passed3rdShortcut == false)
                    {
                        if (player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown >= 19)
                        {
                            shotforshortcutTile.gameObject.SetActive(true);
                            player[currentPlayer].GetComponent<FollowThePath>().transform.position = player[currentPlayer].GetComponent<FollowThePath>().waypoints[19].transform.position;


                            player[currentPlayer].GetComponent<FollowThePath>().shortcutwaypointIndex = player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown - 11;
                            player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex = player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown + 1;

                            ChooseRoute();


                            player[currentPlayer].GetComponent<FollowThePath>().passed3rdShortcut = true;


                        }
                    }


                    // If you land on green everyone take a shot tile 
                    if (player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown == 21)
                    {
                        greenEveryonetakeashottile.gameObject.SetActive(true);
                        clicktocontinueText.gameObject.SetActive(true);
                        player[currentPlayer].GetComponent<FollowThePath>().transform.position = player[currentPlayer].GetComponent<FollowThePath>().waypoints[21].transform.position;
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex = 21;
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex += 1;
                        MovePlayer();
                    }


                    // If you land on orange pick an age tile
                    if (player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown == 22)
                    {
                        orangePickanagetile.gameObject.SetActive(true);
                        clicktocontinueText.gameObject.SetActive(true);
                        player[currentPlayer].GetComponent<FollowThePath>().transform.position = player[currentPlayer].GetComponent<FollowThePath>().waypoints[22].transform.position;
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex = 22;
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex += 1;
                        MovePlayer();
                    }


                    // If you land on red pick a game tile 
                    if (player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown == 23)
                    {
                        redPickagametile.gameObject.SetActive(true);
                        clicktocontinueText.gameObject.SetActive(true);
                        player[currentPlayer].GetComponent<FollowThePath>().transform.position = player[currentPlayer].GetComponent<FollowThePath>().waypoints[23].transform.position;
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex = 23;
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex += 1;
                        MovePlayer();
                    }


                    // If you land on blue you and 2 tile 
                    if (player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown == 24)
                    {
                        blueYouand2tile.gameObject.SetActive(true);
                        clicktocontinueText.gameObject.SetActive(true);
                        player[currentPlayer].GetComponent<FollowThePath>().transform.position = player[currentPlayer].GetComponent<FollowThePath>().waypoints[24].transform.position;
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex = 24;
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex += 1;
                        MovePlayer();
                    }




                    player[currentPlayer].GetComponent<FollowThePath>().moveAllowed = false;


                    player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint = player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex - 1;

                    if (TakeShortcutButton.activeInHierarchy == false && DontTakeShortcutButton.activeInHierarchy == false)
                    {
                        NextPlayerMoveTexts();
                    }
                    
                }

                // END OF PLAYER NORAML ROUTE 
            }




            // IF PLAYER IS ON THE SHORTCUT 
            if (player[currentPlayer].GetComponent<FollowThePath>().onShortcut == true) // && Dice.diceAllowed == false && currentPlayer == whosturn) 
            {
                // Debug.Log("POSITION " + player[currentPlayer].GetComponent<FollowThePath>().transform.position);
                // Debug.Log("P1SC + DICEROLL :" + player[currentPlayer].GetComponent<FollowThePath>().SCStartWaypoint + diceSideThrown);

                if (player[currentPlayer].GetComponent<FollowThePath>().shortcutwaypointIndex >
                player[currentPlayer].GetComponent<FollowThePath>().SCStartWaypoint + diceSideThrown) // || player[currentPlayer].GetComponent<FollowThePath>().shortcutwaypointIndex == 0)
                {
                    // First spot when choosing the shortcut 
                    if (player[currentPlayer].GetComponent<FollowThePath>().SCStartWaypoint + diceSideThrown == 0)
                    {
                        player[currentPlayer].GetComponent<FollowThePath>().transform.position = player[currentPlayer].GetComponent<FollowThePath>().shortcutwaypoints[0].transform.position;
                        player[currentPlayer].GetComponent<FollowThePath>().shortcutwaypointIndex = 0;
                        player[currentPlayer].GetComponent<FollowThePath>().shortcutwaypointIndex += 1;
                        ShortcutMovePlayer();

                    }

                    // If you land on go back pink go back one
                    if (player[currentPlayer].GetComponent<FollowThePath>().SCStartWaypoint + diceSideThrown == 1)
                    {
                        pinkGobackonetile.gameObject.SetActive(true);
                        clicktocontinueText.gameObject.SetActive(true);
                        player[currentPlayer].GetComponent<FollowThePath>().transform.position = player[currentPlayer].GetComponent<FollowThePath>().waypoints[4].transform.position;
                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex = 4;
                        
                        diceSideThrown = 0;
                        player[currentPlayer].GetComponent<FollowThePath>().SCStartWaypoint = 0;
                        player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint = 4;
                        player[currentPlayer].GetComponent<FollowThePath>().passed1stShortcut = false;
                        player[currentPlayer].GetComponent<FollowThePath>().onShortcut = false;
                    }


                    // If you land on pink waterfall 
                    if (player[currentPlayer].GetComponent<FollowThePath>().SCStartWaypoint + diceSideThrown == 2)

                    {
                        pinkWaterfalltile.gameObject.SetActive(true);
                        clicktocontinueText.gameObject.SetActive(true);
                        player[currentPlayer].GetComponent<FollowThePath>().transform.position = player[currentPlayer].GetComponent<FollowThePath>().shortcutwaypoints[2].transform.position;
                        player[currentPlayer].GetComponent<FollowThePath>().shortcutwaypointIndex = 2;
                        player[currentPlayer].GetComponent<FollowThePath>().shortcutwaypointIndex += 1;
                        ShortcutMovePlayer();

                    }

                    // If you land on pink take a half shot 
                    if (player[currentPlayer].GetComponent<FollowThePath>().SCStartWaypoint + diceSideThrown == 3)
                    {
                        pinkTakehalfshottile.gameObject.SetActive(true);
                        clicktocontinueText.gameObject.SetActive(true);
                        player[currentPlayer].GetComponent<FollowThePath>().transform.position = player[currentPlayer].GetComponent<FollowThePath>().shortcutwaypoints[3].transform.position;
                        player[currentPlayer].GetComponent<FollowThePath>().shortcutwaypointIndex = 3;
                        player[currentPlayer].GetComponent<FollowThePath>().shortcutwaypointIndex += 1;
                        ShortcutMovePlayer();

                    }



                    // If you land on pink return to start
                    if (player[currentPlayer].GetComponent<FollowThePath>().SCStartWaypoint + diceSideThrown == 5)
                    {
                        pinkReturntostarttile.gameObject.SetActive(true);
                        clicktocontinueText.gameObject.SetActive(true);
                        player[currentPlayer].GetComponent<FollowThePath>().transform.position = player[currentPlayer].GetComponent<FollowThePath>().waypoints[0].transform.position;


                        player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex = 0;

                        player[currentPlayer].GetComponent<FollowThePath>().passed1stShortcut = false;
                        player[currentPlayer].GetComponent<FollowThePath>().passed2ndShortcut = false;
                        player[currentPlayer].GetComponent<FollowThePath>().passed3rdShortcut = false;

                        diceSideThrown = 0;
                        player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint = 0;

                        MovePlayer();

                        player[currentPlayer].GetComponent<FollowThePath>().onShortcut = false;

                        
                    }


                    // If you land on pink make a rule tile 
                    if (player[currentPlayer].GetComponent<FollowThePath>().SCStartWaypoint + diceSideThrown == 6)
                    {
                        pinkMakearuletile.gameObject.SetActive(true);
                        clicktocontinueText.gameObject.SetActive(true);
                        player[currentPlayer].GetComponent<FollowThePath>().transform.position = player[currentPlayer].GetComponent<FollowThePath>().shortcutwaypoints[6].transform.position;
                        player[currentPlayer].GetComponent<FollowThePath>().shortcutwaypointIndex = 6;
                        player[currentPlayer].GetComponent<FollowThePath>().shortcutwaypointIndex += 1;
                        ShortcutMovePlayer();

                    }


                    // If you land on pink take and give 3 tile 
                    if (player[currentPlayer].GetComponent<FollowThePath>().SCStartWaypoint + diceSideThrown == 7)
                    {
                        pinkTakeandgive3tile.gameObject.SetActive(true);
                        clicktocontinueText.gameObject.SetActive(true);
                        player[currentPlayer].GetComponent<FollowThePath>().transform.position = player[currentPlayer].GetComponent<FollowThePath>().shortcutwaypoints[7].transform.position;
                        player[currentPlayer].GetComponent<FollowThePath>().shortcutwaypointIndex = 7;
                        player[currentPlayer].GetComponent<FollowThePath>().shortcutwaypointIndex += 1;
                        ShortcutMovePlayer();

                    }


                    // If you land on pink take another shot tile 
                    if (player[currentPlayer].GetComponent<FollowThePath>().SCStartWaypoint + diceSideThrown == 9)
                    {
                        pinkTakeanothershottile.gameObject.SetActive(true);
                        clicktocontinueText.gameObject.SetActive(true);
                        player[currentPlayer].GetComponent<FollowThePath>().transform.position = player[currentPlayer].GetComponent<FollowThePath>().shortcutwaypoints[9].transform.position;
                        player[currentPlayer].GetComponent<FollowThePath>().shortcutwaypointIndex = 9;
                        player[currentPlayer].GetComponent<FollowThePath>().shortcutwaypointIndex += 1;
                        ShortcutMovePlayer();

                    }


                    // If you land on pink go back and give a shot tile 
                    if (player[currentPlayer].GetComponent<FollowThePath>().SCStartWaypoint + diceSideThrown == 10)
                    {
                        pinkGobackandgiveashottile.gameObject.SetActive(true);
                        clicktocontinueText.gameObject.SetActive(true);
                        player[currentPlayer].GetComponent<FollowThePath>().transform.position = player[currentPlayer].GetComponent<FollowThePath>().shortcutwaypoints[9].transform.position;
                        player[currentPlayer].GetComponent<FollowThePath>().shortcutwaypointIndex = 9;
                        player[currentPlayer].GetComponent<FollowThePath>().shortcutwaypointIndex += 1;
                        ShortcutMovePlayer();

                        // Debugs 
                        
                    }



                    // If you land on pink finish drink tile 
                    if (player[currentPlayer].GetComponent<FollowThePath>().SCStartWaypoint + diceSideThrown == 11)
                    {
                        pinkFinishdrinktile.gameObject.SetActive(true);
                        clicktocontinueText.gameObject.SetActive(true);
                        player[currentPlayer].GetComponent<FollowThePath>().transform.position = player[currentPlayer].GetComponent<FollowThePath>().shortcutwaypoints[11].transform.position;
                        player[currentPlayer].GetComponent<FollowThePath>().shortcutwaypointIndex = 11;
                        player[currentPlayer].GetComponent<FollowThePath>().shortcutwaypointIndex += 1;
                        ShortcutMovePlayer();

                    }



                    player[currentPlayer].GetComponent<FollowThePath>().moveAllowed = false;
                    player[currentPlayer].GetComponent<FollowThePath>().shortcutmoveAllowed = false;

                    

                    player[currentPlayer].GetComponent<FollowThePath>().shortcutwaypointIndex -= 1;
                    player[currentPlayer].GetComponent<FollowThePath>().SCStartWaypoint = player[currentPlayer].GetComponent<FollowThePath>().shortcutwaypointIndex;

                    if (TakeShortcutButton.activeInHierarchy == false && DontTakeShortcutButton.activeInHierarchy == false)
                    {
                        NextPlayerMoveTexts();
                    }


                    // Debugs
                    
                }
            }

            
            // this is where currentplayer == whosturn stops 
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

            Dice.diceAllowed = true;
            
        }
        else
        {
            whosturn = 0;
            playermoveicon[whosturn].gameObject.SetActive(true);
            Dice.diceAllowed = true;
            Debug.Log("IN NEXTPLAYERMOVETEXT whosturn " + whosturn);
        }


        Dice.diceAllowed = true;
    }

    public void ChooseRoute()
    {
        TakeShortcutButton.gameObject.SetActive(true);
        DontTakeShortcutButton.gameObject.SetActive(true);
    }

    public void TakeShortcut()
    {

        player[currentPlayer].GetComponent<FollowThePath>().SCStartWaypoint = player[currentPlayer].GetComponent<FollowThePath>().shortcutwaypointIndex;

        diceSideThrown = 0;

        player[currentPlayer].GetComponent<FollowThePath>().onShortcut = true;

        if (player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown >= 4)
        {
            player[currentPlayer].GetComponent<FollowThePath>().passed1stShortcut = true;
        }

        if (player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown >= 12)
        {
            player[currentPlayer].GetComponent<FollowThePath>().passed2ndShortcut = true;
        }

        if (player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown >= 19)
        {
            player[currentPlayer].GetComponent<FollowThePath>().passed3rdShortcut = true;
        }


        TakeShortcutButton.gameObject.SetActive(false);
        DontTakeShortcutButton.gameObject.SetActive(false);
        shotforshortcutTile.gameObject.SetActive(false);



        player[currentPlayer].GetComponent<FollowThePath>().shortcutmoveAllowed = true;

    }

    public void DontTakeShortcut()
    {

        player[currentPlayer].GetComponent<FollowThePath>().onShortcut = false;

        if (player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown >= 4)
        {
            player[currentPlayer].GetComponent<FollowThePath>().passed1stShortcut = true;
        }

        if (player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown >= 12)
        {
            player[currentPlayer].GetComponent<FollowThePath>().passed2ndShortcut = true;

        }

        if (player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint + diceSideThrown >= 19)
        {
            player[currentPlayer].GetComponent<FollowThePath>().passed3rdShortcut = true;
        }


        player[currentPlayer].GetComponent<FollowThePath>().StartWaypoint = player[currentPlayer].GetComponent<FollowThePath>().StartwaypointIndex - diceSideThrown;

        TakeShortcutButton.gameObject.SetActive(false);
        DontTakeShortcutButton.gameObject.SetActive(false);
        shotforshortcutTile.gameObject.SetActive(false);



        player[currentPlayer].GetComponent<FollowThePath>().moveAllowed = true;
    }
}
