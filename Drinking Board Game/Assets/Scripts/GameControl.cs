using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{

    private static GameObject whoWinsTextShadow, clicktocontinueText, P1TakeShortcutButton, P1DontTakeShortcutButton,
        P2TakeShortcutButton, P2DontTakeShortcutButton, P3TakeShortcutButton, P3DontTakeShortcutButton, P4TakeShortcutButton, P4DontTakeShortcutButton,
        P5TakeShortcutButton, P5DontTakeShortcutButton, P6TakeShortcutButton, P6DontTakeShortcutButton;

    public static GameObject Player1Icon, player1MoveText, Player2Icon, player2MoveText, Player3Icon, player3MoveText, Player4Icon, player4MoveText,
        Player5Icon, player5MoveText, Player6Icon, player6MoveText;

    public GameObject redFlipacointile, blueMakearuletile, orangeCategoriestile, shotforshortcutTile, pinkGobackonetile, pinkWaterfalltile, pinkTakehalfshottile,
        redGuysdrinktile, bluePickamatetile, greenNeverhaveievertile, orangeProphunttile, redHoldbreathtile, blueGirlsdrinktile, pinkReturntostarttile, pinkMakearuletile,
        pinkTakeandgive3tile, greenGuessanumbertile, orangeDrivetile, redDrinkwhatyourolltile, blueCascadetile, greenPriceisrighttile, pinkTakeanothershottile,
        pinkGobackandgiveashottile, pinkFinishdrinktile, greenEveryonetakeashottile, orangePickanagetile, redPickagametile, blueYouand2tile;


    private static GameObject player1, player2, player3, player4, player5, player6;

    public static int numofPlayers = 1;
    public static int diceSideThrown = 0;
    public static int whosturn = 0;

    public static int player1StartWaypoint = 0;
    public static int player1SCStartWaypoint = 0;


    public static int player2StartWaypoint = 0;
    public static int player2SCStartWaypoint = 0;

    public static int player3StartWaypoint = 0;
    public static int player3SCStartWaypoint = 0;

    public static int player4StartWaypoint = 0;
    public static int player4SCStartWaypoint = 0;

    public static int player5StartWaypoint = 0;
    public static int player5SCStartWaypoint = 0;

    public static int player6StartWaypoint = 0;
    public static int player6SCStartWaypoint = 0;

    public static bool gameOver = false;

    // Use this for initialization
    void Start()
    {

        // Setting tile Descriptions that show up on landing
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

        // Canvas texts that show up on events 
        whoWinsTextShadow = GameObject.Find("WhoWinsText");
        Player1Icon = GameObject.Find("Player1Icon");
        player1MoveText = GameObject.Find("Player1MoveText");
        Player2Icon = GameObject.Find("Player2Icon");
        player2MoveText = GameObject.Find("Player2MoveText");
        Player3Icon = GameObject.Find("Player3Icon");
        player3MoveText = GameObject.Find("Player3MoveText");
        Player4Icon = GameObject.Find("Player4Icon");
        player4MoveText = GameObject.Find("Player4MoveText");
        Player5Icon = GameObject.Find("Player5Icon");
        player5MoveText = GameObject.Find("Player5MoveText");
        Player6Icon = GameObject.Find("Player6Icon");
        player6MoveText = GameObject.Find("Player6MoveText");


        clicktocontinueText = GameObject.Find("ClickBoxToContinue");
        P1TakeShortcutButton = GameObject.Find("P1TakeShortcutButton");
        P1DontTakeShortcutButton = GameObject.Find("P1DontTakeShortcutButton");
        P2TakeShortcutButton = GameObject.Find("P2TakeShortcutButton");
        P2DontTakeShortcutButton = GameObject.Find("P2DontTakeShortcutButton");
        P3TakeShortcutButton = GameObject.Find("P3TakeShortcutButton");
        P3DontTakeShortcutButton = GameObject.Find("P3DontTakeShortcutButton");
        P4TakeShortcutButton = GameObject.Find("P4TakeShortcutButton");
        P4DontTakeShortcutButton = GameObject.Find("P4DontTakeShortcutButton");
        P5TakeShortcutButton = GameObject.Find("P5TakeShortcutButton");
        P5DontTakeShortcutButton = GameObject.Find("P5DontTakeShortcutButton");
        P6TakeShortcutButton = GameObject.Find("P6TakeShortcutButton");
        P6DontTakeShortcutButton = GameObject.Find("P6DontTakeShortcutButton");


        // DECLARING PLAYERS 
        player1 = GameObject.Find("Player1");
        player2 = GameObject.Find("Player2");
        player3 = GameObject.Find("Player3");
        player4 = GameObject.Find("Player4");
        player5 = GameObject.Find("Player5");
        player6 = GameObject.Find("Player6");

        player1.GetComponent<FollowThePath>().moveAllowed = false;
        player1.GetComponent<FollowThePath>().shortcutmoveAllowed = false;
        player1.GetComponent<FollowThePath>().onShortcut = false;
        player1.GetComponent<FollowThePath>().passed1stShortcut = false;
        P1TakeShortcutButton.SetActive(false);
        P1DontTakeShortcutButton.SetActive(false);
        player1StartWaypoint = 0;
        player1SCStartWaypoint = 0;

        player2.GetComponent<FollowThePath>().moveAllowed = false;
        player2.GetComponent<FollowThePath>().shortcutmoveAllowed = false;
        player2.GetComponent<FollowThePath>().onShortcut = false;
        player2.GetComponent<FollowThePath>().passed1stShortcut = false;
        P2TakeShortcutButton.SetActive(false);
        P2DontTakeShortcutButton.SetActive(false);
        player2StartWaypoint = 0;
        player2SCStartWaypoint = 0;

        player3.GetComponent<FollowThePath>().moveAllowed = false;
        player3.GetComponent<FollowThePath>().shortcutmoveAllowed = false;
        player3.GetComponent<FollowThePath>().onShortcut = false;
        player3.GetComponent<FollowThePath>().passed1stShortcut = false;
        P3TakeShortcutButton.SetActive(false);
        P3DontTakeShortcutButton.SetActive(false);
        player3StartWaypoint = 0;
        player3SCStartWaypoint = 0;

        player4.GetComponent<FollowThePath>().moveAllowed = false;
        player4.GetComponent<FollowThePath>().shortcutmoveAllowed = false;
        player4.GetComponent<FollowThePath>().onShortcut = false;
        player4.GetComponent<FollowThePath>().passed1stShortcut = false;
        P4TakeShortcutButton.SetActive(false);
        P4DontTakeShortcutButton.SetActive(false);
        player4StartWaypoint = 0;
        player4SCStartWaypoint = 0;

        player5.GetComponent<FollowThePath>().moveAllowed = false;
        player5.GetComponent<FollowThePath>().shortcutmoveAllowed = false;
        player5.GetComponent<FollowThePath>().onShortcut = false;
        player5.GetComponent<FollowThePath>().passed1stShortcut = false;
        P5TakeShortcutButton.SetActive(false);
        P5DontTakeShortcutButton.SetActive(false);
        player5StartWaypoint = 0;
        player5SCStartWaypoint = 0;

        player6.GetComponent<FollowThePath>().moveAllowed = false;
        player6.GetComponent<FollowThePath>().shortcutmoveAllowed = false;
        player6.GetComponent<FollowThePath>().onShortcut = false;
        player6.GetComponent<FollowThePath>().passed1stShortcut = false;
        P6TakeShortcutButton.SetActive(false);
        P6DontTakeShortcutButton.SetActive(false);
        player6StartWaypoint = 0;
        player6SCStartWaypoint = 0;

        // Initial start of game event text showing
        whoWinsTextShadow.gameObject.SetActive(false);
        player1MoveText.gameObject.SetActive(true);
        player2MoveText.gameObject.SetActive(false);
        player3MoveText.gameObject.SetActive(false);
        player4MoveText.gameObject.SetActive(false);
        player5MoveText.gameObject.SetActive(false);
        player6MoveText.gameObject.SetActive(false);
        clicktocontinueText.gameObject.SetActive(false);



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


        switch (numofPlayers)
        {
            case 1:
                Player1Icon.gameObject.SetActive(true);
                player1.gameObject.SetActive(true);
                Player2Icon.gameObject.SetActive(false);
                player2.gameObject.SetActive(false);
                Player3Icon.gameObject.SetActive(false);
                player3.gameObject.SetActive(false);
                Player4Icon.gameObject.SetActive(false);
                player4.gameObject.SetActive(false);
                Player5Icon.gameObject.SetActive(false);
                player5.gameObject.SetActive(false);
                Player6Icon.gameObject.SetActive(false);
                player6.gameObject.SetActive(false);
                break;
            case 2:
                Player1Icon.gameObject.SetActive(true);
                player1.gameObject.SetActive(true);
                Player2Icon.gameObject.SetActive(true);
                player2.gameObject.SetActive(true);
                Player3Icon.gameObject.SetActive(false);
                player3.gameObject.SetActive(false);
                Player4Icon.gameObject.SetActive(false);
                player4.gameObject.SetActive(false);
                Player5Icon.gameObject.SetActive(false);
                player5.gameObject.SetActive(false);
                Player6Icon.gameObject.SetActive(false);
                player6.gameObject.SetActive(false);
                break;
            case 3:
                Player1Icon.gameObject.SetActive(true);
                player1.gameObject.SetActive(true);
                Player2Icon.gameObject.SetActive(true);
                player2.gameObject.SetActive(true);
                Player3Icon.gameObject.SetActive(true);
                player3.gameObject.SetActive(true);
                Player4Icon.gameObject.SetActive(false);
                player4.gameObject.SetActive(false);
                Player5Icon.gameObject.SetActive(false);
                player5.gameObject.SetActive(false);
                Player6Icon.gameObject.SetActive(false);
                player6.gameObject.SetActive(false);
                break;
            case 4:
                Player1Icon.gameObject.SetActive(true);
                player1.gameObject.SetActive(true);
                Player2Icon.gameObject.SetActive(true);
                player2.gameObject.SetActive(true);
                Player3Icon.gameObject.SetActive(true);
                player3.gameObject.SetActive(true);
                Player4Icon.gameObject.SetActive(true);
                player4.gameObject.SetActive(true);
                Player5Icon.gameObject.SetActive(false);
                player5.gameObject.SetActive(false);
                Player6Icon.gameObject.SetActive(false);
                player6.gameObject.SetActive(false);
                break;
            case 5:
                Player1Icon.gameObject.SetActive(true);
                player1.gameObject.SetActive(true);
                Player2Icon.gameObject.SetActive(true);
                player2.gameObject.SetActive(true);
                Player3Icon.gameObject.SetActive(true);
                player3.gameObject.SetActive(true);
                Player4Icon.gameObject.SetActive(true);
                player4.gameObject.SetActive(true);
                Player5Icon.gameObject.SetActive(true);
                player5.gameObject.SetActive(true);
                Player6Icon.gameObject.SetActive(false);
                player6.gameObject.SetActive(false);
                break;
            case 6:
                Player1Icon.gameObject.SetActive(true);
                player1.gameObject.SetActive(true);
                Player2Icon.gameObject.SetActive(true);
                player2.gameObject.SetActive(true);
                Player3Icon.gameObject.SetActive(true);
                player3.gameObject.SetActive(true);
                Player4Icon.gameObject.SetActive(true);
                player4.gameObject.SetActive(true);
                Player5Icon.gameObject.SetActive(true);
                player5.gameObject.SetActive(true);
                Player6Icon.gameObject.SetActive(true);
                player6.gameObject.SetActive(true);
                break;

        }
    }

    // Update is called once per frame
    void Update()
    {

        // MOVE PLAYER 1
        if (player1.GetComponent<FollowThePath>().onShortcut == false && whosturn == 1) // && player1MoveText == true && whosturn == 1)
        {
            if (player1.GetComponent<FollowThePath>().StartwaypointIndex >
            player1StartWaypoint + diceSideThrown)
            {
                // If you land on red flip a coin tile
                if (player1StartWaypoint + diceSideThrown == 1)
                {
                    redFlipacointile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[1].transform.position;
                    player1.GetComponent<FollowThePath>().StartwaypointIndex = 1;
                    player1.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(1);

                    // Debug.Log("START WAYPOINT " + player1StartWaypoint);
                    // Debug.Log("DICE " + diceSideThrown);
                    // Debug.Log("SHORTCUTWAYPOINT INDEX " + player1.GetComponent<FollowThePath>().StartwaypointIndex);
                }

                // If you land on blue make a rule tile 
                if (player1StartWaypoint + diceSideThrown == 2)
                {
                    blueMakearuletile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[2].transform.position;
                    player1.GetComponent<FollowThePath>().StartwaypointIndex = 2;
                    player1.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(1);

                    // Debug.Log("START WAYPOINT " + player1StartWaypoint);
                    // Debug.Log("DICE " + diceSideThrown);
                    // Debug.Log("SHORTCUTWAYPOINT INDEX " + player1.GetComponent<FollowThePath>().StartwaypointIndex);
                }

                // If you land on orange categories tile 
                if (player1StartWaypoint + diceSideThrown == 3)
                {
                    orangeCategoriestile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[3].transform.position;
                    player1.GetComponent<FollowThePath>().StartwaypointIndex = 3;
                    player1.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(1);

                    // Debug.Log("START WAYPOINT " + player1StartWaypoint);
                    // Debug.Log("DICE " + diceSideThrown);
                    // Debug.Log("SHORTCUTWAYPOINT INDEX " + player1.GetComponent<FollowThePath>().StartwaypointIndex);
                }

                // If you land on yellow shot for shortcut for the first time 
                if (player1.GetComponent<FollowThePath>().passed1stShortcut == false && player1.GetComponent<FollowThePath>().onShortcut == false)
                {
                    if (player1StartWaypoint + diceSideThrown >= 4)
                    {
                        shotforshortcutTile.gameObject.SetActive(true);

                        player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[4].transform.position;

                        player1.GetComponent<FollowThePath>().shortcutwaypointIndex = player1StartWaypoint + diceSideThrown - 4;
                        player1.GetComponent<FollowThePath>().StartwaypointIndex = player1StartWaypoint + diceSideThrown + 1;

                        player1.GetComponent<FollowThePath>().onShortcut = true;
                        player1.GetComponent<FollowThePath>().passed1stShortcut = true;

                        ChooseRoute(1);
                        

                        // Debugs
                        Debug.Log("START WAYPOINT " + player1StartWaypoint);
                        Debug.Log("DICE " + diceSideThrown);
                        Debug.Log("STARTWAYPOINT INDEX " + player1.GetComponent<FollowThePath>().StartwaypointIndex);


                        // player1.GetComponent<FollowThePath>().shortcutwaypointIndex = player1StartWaypoint + diceSideThrown - 4; // 4 - player1StartWaypoint - diceSideThrown * -1;



                    }
                }

                // If you end up going back to the first shot for shortcut again 
                /*
                if (player1.GetComponent<FollowThePath>().passed1stShortcut == true && player1.GetComponent<FollowThePath>().onShortcut == false)
                {
                    if (player1StartWaypoint == 4 && player1.GetComponent<FollowThePath>().StartwaypointIndex == 4) // + dicesideThrown
                    {
                        shotforshortcutTile.gameObject.SetActive(true);

                        player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[4].transform.position;

                        player1.GetComponent<FollowThePath>().shortcutwaypointIndex = player1StartWaypoint + diceSideThrown - 4;
                        player1.GetComponent<FollowThePath>().StartwaypointIndex = player1StartWaypoint + diceSideThrown;

                        ChooseRoute(1);
                        player1.GetComponent<FollowThePath>().onShortcut = true;
                        // player1.GetComponent<FollowThePath>().StartwaypointIndex = 4;
                        // player1.GetComponent<FollowThePath>().StartwaypointIndex += 1;

                        Debug.Log("start waypoing on  == 4 popping up");
                    }
                }
                
                if (player1StartWaypoint + diceSideThrown == 5)
                {
                    player1.GetComponent<FollowThePath>().StartwaypointIndex = 5;
                    player1.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                }
                */

                // If you land on red guys drink tile 
                if (player1StartWaypoint + diceSideThrown == 6 && player1.GetComponent<FollowThePath>().passed1stShortcut == true)
                {
                    redGuysdrinktile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[6].transform.position;
                    player1.GetComponent<FollowThePath>().StartwaypointIndex = 6;
                    player1.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(1);
                }


                // If you land on blue pick a mate tile
                if (player1StartWaypoint + diceSideThrown == 7)
                {
                    bluePickamatetile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[7].transform.position;
                    player1.GetComponent<FollowThePath>().StartwaypointIndex = 7;
                    player1.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(1);
                }

                // If you land on green never have i ever tile
                if (player1StartWaypoint + diceSideThrown == 8)
                {
                    greenNeverhaveievertile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[8].transform.position;
                    player1.GetComponent<FollowThePath>().StartwaypointIndex = 8;
                    player1.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(1);
                }


                // If you land on orange prop hunt tile 
                if (player1StartWaypoint + diceSideThrown == 9)
                {
                    orangeProphunttile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[9].transform.position;
                    player1.GetComponent<FollowThePath>().StartwaypointIndex = 9;
                    player1.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(1);
                }


                // If you land on red hold breath tile 
                if (player1StartWaypoint + diceSideThrown == 10)
                {
                    redHoldbreathtile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[10].transform.position;
                    player1.GetComponent<FollowThePath>().StartwaypointIndex = 10;
                    player1.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(1);
                }


                // If you land on blue girls drink
                if (player1StartWaypoint + diceSideThrown == 11)
                {
                    blueGirlsdrinktile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);

                    player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[11].transform.position;
                    player1.GetComponent<FollowThePath>().StartwaypointIndex = 11;
                    player1.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(1);

                    Debug.Log("tile 11 STARTWAYPOINT " + player1StartWaypoint);
                    Debug.Log("tile 11 STARTWAYPOINT INDEX " + player1.GetComponent<FollowThePath>().StartwaypointIndex);
                    Debug.Log("tile 11 SCSTARTWP INDEX " + player1.GetComponent<FollowThePath>().shortcutwaypointIndex);
                }


                // If you land on yellow shot for shortcut for the first time 
                if (player1.GetComponent<FollowThePath>().passed2ndShortcut == false)
                {
                    if (player1StartWaypoint + diceSideThrown >= 12)
                    {
                        shotforshortcutTile.gameObject.SetActive(true);
                        player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[12].transform.position;

                        player1.GetComponent<FollowThePath>().shortcutwaypointIndex = player1StartWaypoint + diceSideThrown - 8;
                        player1.GetComponent<FollowThePath>().StartwaypointIndex = player1StartWaypoint + diceSideThrown + 1;

                        ChooseRoute(1);

                        player1.GetComponent<FollowThePath>().passed2ndShortcut = true;
                    }
                }



                // If you land on green guess a number tile
                if (player1StartWaypoint + diceSideThrown == 14)
                {
                    greenGuessanumbertile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[14].transform.position;
                    player1.GetComponent<FollowThePath>().StartwaypointIndex = 14;
                    player1.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(1);
                }


                // If you land on orange drive tile
                if (player1StartWaypoint + diceSideThrown == 15)
                {
                    orangeDrivetile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[15].transform.position;
                    player1.GetComponent<FollowThePath>().StartwaypointIndex = 15;
                    player1.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(1);
                }


                // If you land on red drink what you roll tile
                if (player1StartWaypoint + diceSideThrown == 16)
                {
                    redDrinkwhatyourolltile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[16].transform.position;
                    player1.GetComponent<FollowThePath>().StartwaypointIndex = 16;
                    player1.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(1);
                }


                // If you land on blue cascade tile
                if (player1StartWaypoint + diceSideThrown == 17)
                {
                    blueCascadetile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[17].transform.position;
                    player1.GetComponent<FollowThePath>().StartwaypointIndex = 17;
                    player1.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(1);
                }


                // If you land on green price is right tile 
                if (player1StartWaypoint + diceSideThrown == 18)
                {
                    greenPriceisrighttile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[18].transform.position;
                    player1.GetComponent<FollowThePath>().StartwaypointIndex = 18;
                    player1.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(1);
                }


                // If you land on yellow shot for shortcut for the first time 
                if (player1.GetComponent<FollowThePath>().passed3rdShortcut == false)
                {
                    if (player1StartWaypoint + diceSideThrown >= 19)
                    {
                        shotforshortcutTile.gameObject.SetActive(true);
                        player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[19].transform.position;


                        player1.GetComponent<FollowThePath>().shortcutwaypointIndex = player1StartWaypoint + diceSideThrown - 11;
                        player1.GetComponent<FollowThePath>().StartwaypointIndex = player1StartWaypoint + diceSideThrown + 1;

                        ChooseRoute(1);


                        player1.GetComponent<FollowThePath>().passed3rdShortcut = true;


                    }
                }


                // If you land on green everyone take a shot tile 
                if (player1StartWaypoint + diceSideThrown == 21)
                {
                    greenEveryonetakeashottile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[21].transform.position;
                    player1.GetComponent<FollowThePath>().StartwaypointIndex = 21;
                    player1.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(1);
                }


                // If you land on orange pick an age tile
                if (player1StartWaypoint + diceSideThrown == 22)
                {
                    orangePickanagetile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[22].transform.position;
                    player1.GetComponent<FollowThePath>().StartwaypointIndex = 22;
                    player1.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(1);
                }


                // If you land on red pick a game tile 
                if (player1StartWaypoint + diceSideThrown == 23)
                {
                    redPickagametile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[23].transform.position;
                    player1.GetComponent<FollowThePath>().StartwaypointIndex = 23;
                    player1.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(1);
                }


                // If you land on blue you and 2 tile 
                if (player1StartWaypoint + diceSideThrown == 24)
                {
                    blueYouand2tile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[24].transform.position;
                    player1.GetComponent<FollowThePath>().StartwaypointIndex = 24;
                    player1.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(1);
                }




                player1.GetComponent<FollowThePath>().moveAllowed = false;

                NextPlayerMoveTexts(1);

                // player1MoveText.gameObject.SetActive(false);
                // player2MoveText.gameObject.SetActive(true);

                player1StartWaypoint = player1.GetComponent<FollowThePath>().StartwaypointIndex - 1;

                Debug.Log("showing player 1 movement ");
                // Debug.Log("end of move START WAYPOINT " + player1StartWaypoint);
                // Debug.Log("end of move START WAYPOINT INDEX " + player1.GetComponent<FollowThePath>().StartwaypointIndex);
                // Debug.Log("repeating still...");
                // Debug.Log("MOVE P1SWP " + player1StartWaypoint);
                // Debug.Log("PASSED SHORTCUT? " + player1.GetComponent<FollowThePath>().passed1stShortcut);
                // Debug.Log("IF ONSHORTCUT " + player1.GetComponent<FollowThePath>().onShortcut);
            }
        }




        // IF PLAYER 1 IS ON THE SHORTCUT 
        if (player1.GetComponent<FollowThePath>().onShortcut == true && whosturn == 1) // && player1MoveText == true && whosturn == 1)
        {
            // Debug.Log("POSITION " + player1.GetComponent<FollowThePath>().transform.position);
            // Debug.Log("P1SC + DICEROLL :" + player1SCStartWaypoint + diceSideThrown);

            if (player1.GetComponent<FollowThePath>().shortcutwaypointIndex >
            player1SCStartWaypoint + diceSideThrown) // || player1.GetComponent<FollowThePath>().shortcutwaypointIndex == 0)
            {
                // First spot when choosing the shortcut 
                if (player1SCStartWaypoint + diceSideThrown == 0)
                {
                    player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().shortcutwaypoints[0].transform.position;
                    player1.GetComponent<FollowThePath>().shortcutwaypointIndex = 0;
                    player1.GetComponent<FollowThePath>().shortcutwaypointIndex += 1;
                    ShortcutMovePlayer(1);

                }

                // If you land on go back pink go back one
                if (player1SCStartWaypoint + diceSideThrown == 1)
                {
                    pinkGobackonetile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[4].transform.position;
                    player1.GetComponent<FollowThePath>().StartwaypointIndex = 4;
                    // player1.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    // player1.GetComponent<FollowThePath>().shortcutwaypointIndex += 1;
                    diceSideThrown = 0;
                    player1SCStartWaypoint = 0;
                    player1StartWaypoint = 4;
                    player1.GetComponent<FollowThePath>().passed1stShortcut = false;
                    player1.GetComponent<FollowThePath>().onShortcut = false;
                }


                // If you land on pink waterfall 
                if (player1SCStartWaypoint + diceSideThrown == 2)

                {
                    pinkWaterfalltile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().shortcutwaypoints[2].transform.position;
                    player1.GetComponent<FollowThePath>().shortcutwaypointIndex = 2;
                    player1.GetComponent<FollowThePath>().shortcutwaypointIndex += 1;
                    ShortcutMovePlayer(1);

                }

                // If you land on pink take a half shot 
                if (player1SCStartWaypoint + diceSideThrown == 3)
                {
                    pinkTakehalfshottile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().shortcutwaypoints[3].transform.position;
                    player1.GetComponent<FollowThePath>().shortcutwaypointIndex = 3;
                    player1.GetComponent<FollowThePath>().shortcutwaypointIndex += 1;
                    ShortcutMovePlayer(1);

                }



                // If you land on pink return to start
                if (player1SCStartWaypoint + diceSideThrown == 5)
                {
                    pinkReturntostarttile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[0].transform.position;


                    player1.GetComponent<FollowThePath>().StartwaypointIndex = 0;

                    player1.GetComponent<FollowThePath>().passed1stShortcut = false;
                    player1.GetComponent<FollowThePath>().passed2ndShortcut = false;
                    player1.GetComponent<FollowThePath>().passed3rdShortcut = false;

                    diceSideThrown = 0;
                    player1StartWaypoint = 0;

                    MovePlayer(1);

                    player1.GetComponent<FollowThePath>().onShortcut = false;

                    // Debug.Log("swpindex " + player1StartWaypoint);
                    // Debug.Log("scwpindex " + player1SCStartWaypoint);
                    // Debug.Log("dice " + diceSideThrown);
                }


                // If you land on pink make a rule tile 
                if (player1SCStartWaypoint + diceSideThrown == 6)
                {
                    pinkMakearuletile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().shortcutwaypoints[6].transform.position;
                    player1.GetComponent<FollowThePath>().shortcutwaypointIndex = 6;
                    player1.GetComponent<FollowThePath>().shortcutwaypointIndex += 1;
                    ShortcutMovePlayer(1);

                }


                // If you land on pink take and give 3 tile 
                if (player1SCStartWaypoint + diceSideThrown == 7)
                {
                    pinkTakeandgive3tile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().shortcutwaypoints[7].transform.position;
                    player1.GetComponent<FollowThePath>().shortcutwaypointIndex = 7;
                    player1.GetComponent<FollowThePath>().shortcutwaypointIndex += 1;
                    ShortcutMovePlayer(1);

                }


                // If you land on pink take another shot tile 
                if (player1SCStartWaypoint + diceSideThrown == 9)
                {
                    pinkTakeanothershottile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().shortcutwaypoints[9].transform.position;
                    player1.GetComponent<FollowThePath>().shortcutwaypointIndex = 9;
                    player1.GetComponent<FollowThePath>().shortcutwaypointIndex += 1;
                    ShortcutMovePlayer(1);

                }


                // If you land on pink go back and give a shot tile 
                if (player1SCStartWaypoint + diceSideThrown == 10)
                {
                    pinkGobackandgiveashottile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().shortcutwaypoints[9].transform.position;
                    player1.GetComponent<FollowThePath>().shortcutwaypointIndex = 9;
                    player1.GetComponent<FollowThePath>().shortcutwaypointIndex += 1;
                    ShortcutMovePlayer(1);

                    // Debugs 
                    Debug.Log("scwpindex " + player1.GetComponent<FollowThePath>().shortcutwaypointIndex);
                    Debug.Log("scstartwaypoint " + player1SCStartWaypoint);


                }



                // If you land on pink finish drink tile 
                if (player1SCStartWaypoint + diceSideThrown == 11)
                {
                    pinkFinishdrinktile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().shortcutwaypoints[11].transform.position;
                    player1.GetComponent<FollowThePath>().shortcutwaypointIndex = 11;
                    player1.GetComponent<FollowThePath>().shortcutwaypointIndex += 1;
                    ShortcutMovePlayer(1);

                }





                player1.GetComponent<FollowThePath>().moveAllowed = false;
                player1.GetComponent<FollowThePath>().shortcutmoveAllowed = false;

                

                player1.GetComponent<FollowThePath>().shortcutwaypointIndex -= 1;
                player1SCStartWaypoint = player1.GetComponent<FollowThePath>().shortcutwaypointIndex;

                NextPlayerMoveTexts(1);

                // Debugs
                // Debug.Log("repeating still...");
                // Debug.Log(player1SCStartWaypoint);
                // Debug.Log("on shortcut SHORTCUTWAYPOINT INDEX " + player1.GetComponent<FollowThePath>().shortcutwaypointIndex);
                // Debug.Log("on shortcut P1SC + DICEROLL " + player1SCStartWaypoint + diceSideThrown);
                // Debug.Log("STARTWAYPOINTINDEX " + player1.GetComponent<FollowThePath>().StartwaypointIndex);
            }
        }








        /////////////////////////////////////////////////////// MOVE PLAYER 2 /////////////////////////////////////////////////////////////

        if (player2.GetComponent<FollowThePath>().onShortcut == false && whosturn == 2) // && player2MoveText == true && whosturn == 2) 
        {
            if (player2.GetComponent<FollowThePath>().StartwaypointIndex >
            player2StartWaypoint + diceSideThrown)
            {
                // If you land on red flip a coin tile
                if (player2StartWaypoint + diceSideThrown == 1)
                {
                    redFlipacointile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[1].transform.position;
                    player2.GetComponent<FollowThePath>().StartwaypointIndex = 1;
                    player2.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(2);

                    // Debug.Log("START WAYPOINT " + player2StartWaypoint);
                    // Debug.Log("DICE " + diceSideThrown);
                    // Debug.Log("SHORTCUTWAYPOINT INDEX " + player2.GetComponent<FollowThePath>().StartwaypointIndex);
                }

                // If you land on blue make a rule tile 
                if (player2StartWaypoint + diceSideThrown == 2)
                {
                    blueMakearuletile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[2].transform.position;
                    player2.GetComponent<FollowThePath>().StartwaypointIndex = 2;
                    player2.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(2);

                    // Debug.Log("START WAYPOINT " + player1StartWaypoint);
                    // Debug.Log("DICE " + diceSideThrown);
                    // Debug.Log("SHORTCUTWAYPOINT INDEX " + player1.GetComponent<FollowThePath>().StartwaypointIndex);
                }

                // If you land on orange categories tile 
                if (player2StartWaypoint + diceSideThrown == 3)
                {
                    orangeCategoriestile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[3].transform.position;
                    player2.GetComponent<FollowThePath>().StartwaypointIndex = 3;
                    player2.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(2);

                    // Debug.Log("START WAYPOINT " + player1StartWaypoint);
                    // Debug.Log("DICE " + diceSideThrown);
                    // Debug.Log("SHORTCUTWAYPOINT INDEX " + player1.GetComponent<FollowThePath>().StartwaypointIndex);
                }

                // If you land on yellow shot for shortcut for the first time 
                
                if (player2.GetComponent<FollowThePath>().passed1stShortcut == false && player2.GetComponent<FollowThePath>().onShortcut == false)
                {
                    if (player2StartWaypoint + diceSideThrown >= 4)
                    {
                        shotforshortcutTile.gameObject.SetActive(true);

                        player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[4].transform.position;

                        player2.GetComponent<FollowThePath>().shortcutwaypointIndex = player2StartWaypoint + diceSideThrown - 4;
                        player2.GetComponent<FollowThePath>().StartwaypointIndex = player2StartWaypoint + diceSideThrown + 1;


                        ChooseRoute(2);
                        player2.GetComponent<FollowThePath>().onShortcut = true;
                        player2.GetComponent<FollowThePath>().passed1stShortcut = true;

                        // Debugs
                        // Debug.Log("START WAYPOINT " + player1StartWaypoint);
                        // Debug.Log("DICE " + diceSideThrown);
                        // Debug.Log("STARTWAYPOINT INDEX " + player1.GetComponent<FollowThePath>().StartwaypointIndex);


                        // player1.GetComponent<FollowThePath>().shortcutwaypointIndex = player1StartWaypoint + diceSideThrown - 4; // 4 - player1StartWaypoint - diceSideThrown * -1;



                    }
                }

                // If you end up going back to the first shot for shortcut again 
                /*
                if (player2.GetComponent<FollowThePath>().passed1stShortcut == true && player2.GetComponent<FollowThePath>().onShortcut == false)
                {
                    if (player2StartWaypoint == 4 && player2.GetComponent<FollowThePath>().StartwaypointIndex == 4) // + diceSideThrown
                    {
                        shotforshortcutTile.gameObject.SetActive(true);

                        player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[4].transform.position;

                        player2.GetComponent<FollowThePath>().shortcutwaypointIndex = player2StartWaypoint + diceSideThrown - 4;
                        player2.GetComponent<FollowThePath>().StartwaypointIndex = player2StartWaypoint + diceSideThrown;
                        
                        ChooseRoute(2);
                        player2.GetComponent<FollowThePath>().onShortcut = true;
                        

                        // Debug.Log("start waypoing on  == 4 popping up");
                    }
                }
                */

                // If you land on red guys drink tile 
                if (player2StartWaypoint + diceSideThrown == 6 && player2.GetComponent<FollowThePath>().passed1stShortcut == true)
                {
                    redGuysdrinktile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[6].transform.position;
                    player2.GetComponent<FollowThePath>().StartwaypointIndex = 6;
                    player2.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(2);
                }


                // If you land on blue pick a mate tile
                if (player2StartWaypoint + diceSideThrown == 7)
                {
                    bluePickamatetile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[7].transform.position;
                    player2.GetComponent<FollowThePath>().StartwaypointIndex = 7;
                    player2.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(2);
                }

                // If you land on green never have i ever tile
                if (player2StartWaypoint + diceSideThrown == 8)
                {
                    greenNeverhaveievertile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[8].transform.position;
                    player2.GetComponent<FollowThePath>().StartwaypointIndex = 8;
                    player2.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(2);
                }


                // If you land on orange prop hunt tile 
                if (player2StartWaypoint + diceSideThrown == 9)
                {
                    orangeProphunttile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[9].transform.position;
                    player2.GetComponent<FollowThePath>().StartwaypointIndex = 9;
                    player2.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(2);
                }


                // If you land on red hold breath tile 
                if (player2StartWaypoint + diceSideThrown == 10)
                {
                    redHoldbreathtile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[10].transform.position;
                    player2.GetComponent<FollowThePath>().StartwaypointIndex = 10;
                    player2.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(2);
                }


                // If you land on blue girls drink
                if (player2StartWaypoint + diceSideThrown == 11)
                {
                    blueGirlsdrinktile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);

                    player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[11].transform.position;
                    player2.GetComponent<FollowThePath>().StartwaypointIndex = 11;
                    player2.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(2);
                }


                // If you land on yellow shot for shortcut for the first time 
                if (player2.GetComponent<FollowThePath>().passed2ndShortcut == false)
                {
                    if (player2StartWaypoint + diceSideThrown >= 12)
                    {
                        shotforshortcutTile.gameObject.SetActive(true);
                        player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[12].transform.position;

                        player2.GetComponent<FollowThePath>().shortcutwaypointIndex = player2StartWaypoint + diceSideThrown - 8;
                        player2.GetComponent<FollowThePath>().StartwaypointIndex = player2StartWaypoint + diceSideThrown + 1;

                        ChooseRoute(2);

                        player2.GetComponent<FollowThePath>().passed2ndShortcut = true;
                    }
                }



                // If you land on green guess a number tile
                if (player2StartWaypoint + diceSideThrown == 14)
                {
                    greenGuessanumbertile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[14].transform.position;
                    player2.GetComponent<FollowThePath>().StartwaypointIndex = 14;
                    player2.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(2);
                }


                // If you land on orange drive tile
                if (player2StartWaypoint + diceSideThrown == 15)
                {
                    orangeDrivetile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[15].transform.position;
                    player2.GetComponent<FollowThePath>().StartwaypointIndex = 15;
                    player2.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(2);
                }


                // If you land on red drink what you roll tile
                if (player2StartWaypoint + diceSideThrown == 16)
                {
                    redDrinkwhatyourolltile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[16].transform.position;
                    player2.GetComponent<FollowThePath>().StartwaypointIndex = 16;
                    player2.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(2);
                }


                // If you land on blue cascade tile
                if (player2StartWaypoint + diceSideThrown == 17)
                {
                    blueCascadetile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[17].transform.position;
                    player2.GetComponent<FollowThePath>().StartwaypointIndex = 17;
                    player2.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(2);
                }


                // If you land on green price is right tile 
                if (player2StartWaypoint + diceSideThrown == 18)
                {
                    greenPriceisrighttile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[18].transform.position;
                    player2.GetComponent<FollowThePath>().StartwaypointIndex = 18;
                    player2.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(2);
                }


                // If you land on yellow shot for shortcut for the first time 
                if (player2.GetComponent<FollowThePath>().passed3rdShortcut == false)
                {
                    if (player2StartWaypoint + diceSideThrown >= 19)
                    {
                        shotforshortcutTile.gameObject.SetActive(true);
                        player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[19].transform.position;


                        player2.GetComponent<FollowThePath>().shortcutwaypointIndex = player2StartWaypoint + diceSideThrown - 11;
                        player2.GetComponent<FollowThePath>().StartwaypointIndex = player2StartWaypoint + diceSideThrown + 1;

                        ChooseRoute(2);


                        player2.GetComponent<FollowThePath>().passed3rdShortcut = true;


                    }
                }


                // If you land on green everyone take a shot tile 
                if (player2StartWaypoint + diceSideThrown == 21)
                {
                    greenEveryonetakeashottile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[21].transform.position;
                    player2.GetComponent<FollowThePath>().StartwaypointIndex = 21;
                    player2.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(2);
                }


                // If you land on orange pick an age tile
                if (player2StartWaypoint + diceSideThrown == 22)
                {
                    orangePickanagetile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[22].transform.position;
                    player2.GetComponent<FollowThePath>().StartwaypointIndex = 22;
                    player2.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(2);
                }


                // If you land on red pick a game tile 
                if (player2StartWaypoint + diceSideThrown == 23)
                {
                    redPickagametile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[23].transform.position;
                    player2.GetComponent<FollowThePath>().StartwaypointIndex = 23;
                    player2.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(2);
                }


                // If you land on blue you and 2 tile 
                if (player2StartWaypoint + diceSideThrown == 24)
                {
                    blueYouand2tile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[24].transform.position;
                    player2.GetComponent<FollowThePath>().StartwaypointIndex = 24;
                    player2.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(2);
                }




                player2.GetComponent<FollowThePath>().moveAllowed = false;

                NextPlayerMoveTexts(2);

                Debug.Log("player 2 move showing ");

                player2StartWaypoint = player2.GetComponent<FollowThePath>().StartwaypointIndex - 1;

                
            }
        }




        // IF PLAYER 2 IS ON THE SHORTCUT 
        if (player2.GetComponent<FollowThePath>().onShortcut == true && whosturn == 2) // && player2MoveText == true && whosturn == 2)
        {
            // Debug.Log("POSITION " + player1.GetComponent<FollowThePath>().transform.position);
            // Debug.Log("P1SC + DICEROLL :" + player1SCStartWaypoint + diceSideThrown);

            if (player2.GetComponent<FollowThePath>().shortcutwaypointIndex >
            player2SCStartWaypoint + diceSideThrown) // || player1.GetComponent<FollowThePath>().shortcutwaypointIndex == 0)
            {
                // First spot when choosing the shortcut 
                if (player2SCStartWaypoint + diceSideThrown == 0)
                {
                    player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().shortcutwaypoints[0].transform.position;
                    player2.GetComponent<FollowThePath>().shortcutwaypointIndex = 0;
                    player2.GetComponent<FollowThePath>().shortcutwaypointIndex += 1;
                    ShortcutMovePlayer(2);

                }

                // If you land on go back pink go back one
                if (player2SCStartWaypoint + diceSideThrown == 1)
                {
                    pinkGobackonetile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[4].transform.position;
                    player2.GetComponent<FollowThePath>().StartwaypointIndex = 4;

                    diceSideThrown = 0;
                    player2SCStartWaypoint = 0;
                    player2StartWaypoint = 4;
                    player2.GetComponent<FollowThePath>().passed1stShortcut = false;
                    player2.GetComponent<FollowThePath>().onShortcut = false;
                }


                // If you land on pink waterfall 
                if (player2SCStartWaypoint + diceSideThrown == 2)

                {
                    pinkWaterfalltile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().shortcutwaypoints[2].transform.position;
                    player2.GetComponent<FollowThePath>().shortcutwaypointIndex = 2;
                    player2.GetComponent<FollowThePath>().shortcutwaypointIndex += 1;
                    ShortcutMovePlayer(2);

                }

                // If you land on pink take a half shot 
                if (player2SCStartWaypoint + diceSideThrown == 3)
                {
                    pinkTakehalfshottile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().shortcutwaypoints[3].transform.position;
                    player2.GetComponent<FollowThePath>().shortcutwaypointIndex = 3;
                    player2.GetComponent<FollowThePath>().shortcutwaypointIndex += 1;
                    ShortcutMovePlayer(2);

                }



                // If you land on pink return to start
                if (player2SCStartWaypoint + diceSideThrown == 5)
                {
                    pinkReturntostarttile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[0].transform.position;


                    player2.GetComponent<FollowThePath>().StartwaypointIndex = 0;

                    player2.GetComponent<FollowThePath>().passed1stShortcut = false;
                    player2.GetComponent<FollowThePath>().passed2ndShortcut = false;
                    player2.GetComponent<FollowThePath>().passed3rdShortcut = false;

                    diceSideThrown = 0;
                    player2StartWaypoint = 0;

                    MovePlayer(2);

                    player2.GetComponent<FollowThePath>().onShortcut = false;

                }


                // If you land on pink make a rule tile 
                if (player2SCStartWaypoint + diceSideThrown == 6)
                {
                    pinkMakearuletile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().shortcutwaypoints[6].transform.position;
                    player2.GetComponent<FollowThePath>().shortcutwaypointIndex = 6;
                    player2.GetComponent<FollowThePath>().shortcutwaypointIndex += 1;
                    ShortcutMovePlayer(2);

                }


                // If you land on pink take and give 3 tile 
                if (player2SCStartWaypoint + diceSideThrown == 7)
                {
                    pinkTakeandgive3tile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().shortcutwaypoints[7].transform.position;
                    player2.GetComponent<FollowThePath>().shortcutwaypointIndex = 7;
                    player2.GetComponent<FollowThePath>().shortcutwaypointIndex += 1;
                    ShortcutMovePlayer(2);

                }


                // If you land on pink take another shot tile 
                if (player2SCStartWaypoint + diceSideThrown == 9)
                {
                    pinkTakeanothershottile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().shortcutwaypoints[9].transform.position;
                    player2.GetComponent<FollowThePath>().shortcutwaypointIndex = 9;
                    player2.GetComponent<FollowThePath>().shortcutwaypointIndex += 1;
                    ShortcutMovePlayer(2);

                }


                // If you land on pink go back and give a shot tile 
                if (player2SCStartWaypoint + diceSideThrown == 10)
                {
                    pinkGobackandgiveashottile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().shortcutwaypoints[9].transform.position;
                    player2.GetComponent<FollowThePath>().shortcutwaypointIndex = 9;
                    player2.GetComponent<FollowThePath>().shortcutwaypointIndex += 1;
                    ShortcutMovePlayer(2);


                }



                // If you land on pink finish drink tile 
                if (player2SCStartWaypoint + diceSideThrown == 11)
                {
                    pinkFinishdrinktile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().shortcutwaypoints[11].transform.position;
                    player2.GetComponent<FollowThePath>().shortcutwaypointIndex = 11;
                    player2.GetComponent<FollowThePath>().shortcutwaypointIndex += 1;
                    ShortcutMovePlayer(2);

                }





                player2.GetComponent<FollowThePath>().moveAllowed = false;
                player2.GetComponent<FollowThePath>().shortcutmoveAllowed = false;

                NextPlayerMoveTexts(2);

                player2.GetComponent<FollowThePath>().shortcutwaypointIndex -= 1;
                player2SCStartWaypoint = player2.GetComponent<FollowThePath>().shortcutwaypointIndex;

               
            }
        }










        /////////////////////////////////////////////////////// MOVE PLAYER 3 /////////////////////////////////////////////////////////////

        if (player3.GetComponent<FollowThePath>().onShortcut == false && whosturn == 3) // && player3MoveText == true && whosturn == 3) 
        {
            if (player3.GetComponent<FollowThePath>().StartwaypointIndex >
            player3StartWaypoint + diceSideThrown)
            {
                // If you land on red flip a coin tile
                if (player3StartWaypoint + diceSideThrown == 1)
                {
                    redFlipacointile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player3.GetComponent<FollowThePath>().transform.position = player3.GetComponent<FollowThePath>().waypoints[1].transform.position;
                    player3.GetComponent<FollowThePath>().StartwaypointIndex = 1;
                    player3.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(3);

                    // Debug.Log("START WAYPOINT " + player3StartWaypoint);
                    // Debug.Log("DICE " + diceSideThrown);
                    // Debug.Log("SHORTCUTWAYPOINT INDEX " + player3.GetComponent<FollowThePath>().StartwaypointIndex);
                }

                // If you land on blue make a rule tile 
                if (player3StartWaypoint + diceSideThrown == 2)
                {
                    blueMakearuletile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player3.GetComponent<FollowThePath>().transform.position = player3.GetComponent<FollowThePath>().waypoints[2].transform.position;
                    player3.GetComponent<FollowThePath>().StartwaypointIndex = 2;
                    player3.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(3);

                    // Debug.Log("START WAYPOINT " + player1StartWaypoint);
                    // Debug.Log("DICE " + diceSideThrown);
                    // Debug.Log("SHORTCUTWAYPOINT INDEX " + player1.GetComponent<FollowThePath>().StartwaypointIndex);
                }

                // If you land on orange categories tile 
                if (player3StartWaypoint + diceSideThrown == 3)
                {
                    orangeCategoriestile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player3.GetComponent<FollowThePath>().transform.position = player3.GetComponent<FollowThePath>().waypoints[3].transform.position;
                    player3.GetComponent<FollowThePath>().StartwaypointIndex = 3;
                    player3.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(3);

                    // Debug.Log("START WAYPOINT " + player1StartWaypoint);
                    // Debug.Log("DICE " + diceSideThrown);
                    // Debug.Log("SHORTCUTWAYPOINT INDEX " + player1.GetComponent<FollowThePath>().StartwaypointIndex);
                }

                // If you land on yellow shot for shortcut for the first time 

                if (player3.GetComponent<FollowThePath>().passed1stShortcut == false && player3.GetComponent<FollowThePath>().onShortcut == false)
                {
                    if (player3StartWaypoint + diceSideThrown >= 4)
                    {
                        shotforshortcutTile.gameObject.SetActive(true);

                        player3.GetComponent<FollowThePath>().transform.position = player3.GetComponent<FollowThePath>().waypoints[4].transform.position;

                        player3.GetComponent<FollowThePath>().shortcutwaypointIndex = player3StartWaypoint + diceSideThrown - 4;
                        player3.GetComponent<FollowThePath>().StartwaypointIndex = player3StartWaypoint + diceSideThrown + 1;


                        ChooseRoute(3);
                        player3.GetComponent<FollowThePath>().onShortcut = true;
                        player3.GetComponent<FollowThePath>().passed1stShortcut = true;

                        // Debugs
                        // Debug.Log("START WAYPOINT " + player1StartWaypoint);
                        // Debug.Log("DICE " + diceSideThrown);
                        // Debug.Log("STARTWAYPOINT INDEX " + player1.GetComponent<FollowThePath>().StartwaypointIndex);


                        // player1.GetComponent<FollowThePath>().shortcutwaypointIndex = player1StartWaypoint + diceSideThrown - 4; // 4 - player1StartWaypoint - diceSideThrown * -1;



                    }
                }

                // If you end up going back to the first shot for shortcut again 
                /*
                if (player3.GetComponent<FollowThePath>().passed1stShortcut == true && player3.GetComponent<FollowThePath>().onShortcut == false)
                {
                    if (player3StartWaypoint + diceSideThrown == 4)
                    {
                        shotforshortcutTile.gameObject.SetActive(true);

                        player3.GetComponent<FollowThePath>().transform.position = player3.GetComponent<FollowThePath>().waypoints[4].transform.position;

                        player3.GetComponent<FollowThePath>().shortcutwaypointIndex = player3StartWaypoint + diceSideThrown - 4;
                        player3.GetComponent<FollowThePath>().StartwaypointIndex = player3StartWaypoint + diceSideThrown;

                        ChooseRoute(3);
                        player3.GetComponent<FollowThePath>().onShortcut = true;


                        // Debug.Log("start waypoing on  == 4 popping up");
                    }
                }
                */

                // If you land on red guys drink tile 
                if (player3StartWaypoint + diceSideThrown == 6 && player3.GetComponent<FollowThePath>().passed1stShortcut == true)
                {
                    redGuysdrinktile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player3.GetComponent<FollowThePath>().transform.position = player3.GetComponent<FollowThePath>().waypoints[6].transform.position;
                    player3.GetComponent<FollowThePath>().StartwaypointIndex = 6;
                    player3.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(3);
                }


                // If you land on blue pick a mate tile
                if (player3StartWaypoint + diceSideThrown == 7)
                {
                    bluePickamatetile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player3.GetComponent<FollowThePath>().transform.position = player3.GetComponent<FollowThePath>().waypoints[7].transform.position;
                    player3.GetComponent<FollowThePath>().StartwaypointIndex = 7;
                    player3.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(3);
                }

                // If you land on green never have i ever tile
                if (player3StartWaypoint + diceSideThrown == 8)
                {
                    greenNeverhaveievertile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player3.GetComponent<FollowThePath>().transform.position = player3.GetComponent<FollowThePath>().waypoints[8].transform.position;
                    player3.GetComponent<FollowThePath>().StartwaypointIndex = 8;
                    player3.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(3);
                }


                // If you land on orange prop hunt tile 
                if (player3StartWaypoint + diceSideThrown == 9)
                {
                    orangeProphunttile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player3.GetComponent<FollowThePath>().transform.position = player3.GetComponent<FollowThePath>().waypoints[9].transform.position;
                    player3.GetComponent<FollowThePath>().StartwaypointIndex = 9;
                    player3.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(3);
                }


                // If you land on red hold breath tile 
                if (player3StartWaypoint + diceSideThrown == 10)
                {
                    redHoldbreathtile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player3.GetComponent<FollowThePath>().transform.position = player3.GetComponent<FollowThePath>().waypoints[10].transform.position;
                    player3.GetComponent<FollowThePath>().StartwaypointIndex = 10;
                    player3.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(3);
                }


                // If you land on blue girls drink
                if (player3StartWaypoint + diceSideThrown == 11)
                {
                    blueGirlsdrinktile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);

                    player3.GetComponent<FollowThePath>().transform.position = player3.GetComponent<FollowThePath>().waypoints[11].transform.position;
                    player3.GetComponent<FollowThePath>().StartwaypointIndex = 11;
                    player3.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(3);
                }


                // If you land on yellow shot for shortcut for the first time 
                if (player3.GetComponent<FollowThePath>().passed2ndShortcut == false)
                {
                    if (player3StartWaypoint + diceSideThrown >= 12)
                    {
                        shotforshortcutTile.gameObject.SetActive(true);
                        player3.GetComponent<FollowThePath>().transform.position = player3.GetComponent<FollowThePath>().waypoints[12].transform.position;

                        player3.GetComponent<FollowThePath>().shortcutwaypointIndex = player3StartWaypoint + diceSideThrown - 8;
                        player3.GetComponent<FollowThePath>().StartwaypointIndex = player3StartWaypoint + diceSideThrown + 1;

                        ChooseRoute(3);

                        player3.GetComponent<FollowThePath>().passed2ndShortcut = true;
                    }
                }



                // If you land on green guess a number tile
                if (player3StartWaypoint + diceSideThrown == 14)
                {
                    greenGuessanumbertile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player3.GetComponent<FollowThePath>().transform.position = player3.GetComponent<FollowThePath>().waypoints[14].transform.position;
                    player3.GetComponent<FollowThePath>().StartwaypointIndex = 14;
                    player3.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(3);
                }


                // If you land on orange drive tile
                if (player3StartWaypoint + diceSideThrown == 15)
                {
                    orangeDrivetile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player3.GetComponent<FollowThePath>().transform.position = player3.GetComponent<FollowThePath>().waypoints[15].transform.position;
                    player3.GetComponent<FollowThePath>().StartwaypointIndex = 15;
                    player3.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(3);
                }


                // If you land on red drink what you roll tile
                if (player3StartWaypoint + diceSideThrown == 16)
                {
                    redDrinkwhatyourolltile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player3.GetComponent<FollowThePath>().transform.position = player3.GetComponent<FollowThePath>().waypoints[16].transform.position;
                    player3.GetComponent<FollowThePath>().StartwaypointIndex = 16;
                    player3.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(3);
                }


                // If you land on blue cascade tile
                if (player3StartWaypoint + diceSideThrown == 17)
                {
                    blueCascadetile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player3.GetComponent<FollowThePath>().transform.position = player3.GetComponent<FollowThePath>().waypoints[17].transform.position;
                    player3.GetComponent<FollowThePath>().StartwaypointIndex = 17;
                    player3.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(3);
                }


                // If you land on green price is right tile 
                if (player3StartWaypoint + diceSideThrown == 18)
                {
                    greenPriceisrighttile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player3.GetComponent<FollowThePath>().transform.position = player3.GetComponent<FollowThePath>().waypoints[18].transform.position;
                    player3.GetComponent<FollowThePath>().StartwaypointIndex = 18;
                    player3.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(3);
                }


                // If you land on yellow shot for shortcut for the first time 
                if (player3.GetComponent<FollowThePath>().passed3rdShortcut == false)
                {
                    if (player3StartWaypoint + diceSideThrown >= 19)
                    {
                        shotforshortcutTile.gameObject.SetActive(true);
                        player3.GetComponent<FollowThePath>().transform.position = player3.GetComponent<FollowThePath>().waypoints[19].transform.position;


                        player3.GetComponent<FollowThePath>().shortcutwaypointIndex = player3StartWaypoint + diceSideThrown - 11;
                        player3.GetComponent<FollowThePath>().StartwaypointIndex = player3StartWaypoint + diceSideThrown + 1;

                        ChooseRoute(3);


                        player3.GetComponent<FollowThePath>().passed3rdShortcut = true;


                    }
                }


                // If you land on green everyone take a shot tile 
                if (player3StartWaypoint + diceSideThrown == 21)
                {
                    greenEveryonetakeashottile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player3.GetComponent<FollowThePath>().transform.position = player3.GetComponent<FollowThePath>().waypoints[21].transform.position;
                    player3.GetComponent<FollowThePath>().StartwaypointIndex = 21;
                    player3.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(3);
                }


                // If you land on orange pick an age tile
                if (player3StartWaypoint + diceSideThrown == 22)
                {
                    orangePickanagetile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player3.GetComponent<FollowThePath>().transform.position = player3.GetComponent<FollowThePath>().waypoints[22].transform.position;
                    player3.GetComponent<FollowThePath>().StartwaypointIndex = 22;
                    player3.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(3);
                }


                // If you land on red pick a game tile 
                if (player3StartWaypoint + diceSideThrown == 23)
                {
                    redPickagametile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player3.GetComponent<FollowThePath>().transform.position = player3.GetComponent<FollowThePath>().waypoints[23].transform.position;
                    player3.GetComponent<FollowThePath>().StartwaypointIndex = 23;
                    player3.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(3);
                }


                // If you land on blue you and 2 tile 
                if (player3StartWaypoint + diceSideThrown == 24)
                {
                    blueYouand2tile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player3.GetComponent<FollowThePath>().transform.position = player3.GetComponent<FollowThePath>().waypoints[24].transform.position;
                    player3.GetComponent<FollowThePath>().StartwaypointIndex = 24;
                    player3.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(3);
                }




                player3.GetComponent<FollowThePath>().moveAllowed = false;

                NextPlayerMoveTexts(3);

                Debug.Log("player 3 move showing ");

                player3StartWaypoint = player3.GetComponent<FollowThePath>().StartwaypointIndex - 1;


            }
        }




        // IF PLAYER 3 IS ON THE SHORTCUT 
        if (player3.GetComponent<FollowThePath>().onShortcut == true && whosturn == 3) // && player3MoveText == true && whosturn == 3)
        {
            

            if (player3.GetComponent<FollowThePath>().shortcutwaypointIndex >
            player3SCStartWaypoint + diceSideThrown) 
            {
                // First spot when choosing the shortcut 
                if (player3SCStartWaypoint + diceSideThrown == 0)
                {
                    player3.GetComponent<FollowThePath>().transform.position = player3.GetComponent<FollowThePath>().shortcutwaypoints[0].transform.position;
                    player3.GetComponent<FollowThePath>().shortcutwaypointIndex = 0;
                    player3.GetComponent<FollowThePath>().shortcutwaypointIndex += 1;
                    ShortcutMovePlayer(3);

                }

                // If you land on go back pink go back one
                if (player3SCStartWaypoint + diceSideThrown == 1)
                {
                    pinkGobackonetile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player3.GetComponent<FollowThePath>().transform.position = player3.GetComponent<FollowThePath>().waypoints[4].transform.position;
                    player3.GetComponent<FollowThePath>().StartwaypointIndex = 4;

                    diceSideThrown = 0;
                    player3SCStartWaypoint = 0;
                    player3StartWaypoint = 4;
                    player3.GetComponent<FollowThePath>().passed1stShortcut = false;
                    player3.GetComponent<FollowThePath>().onShortcut = false;
                }


                // If you land on pink waterfall 
                if (player3SCStartWaypoint + diceSideThrown == 2)

                {
                    pinkWaterfalltile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player3.GetComponent<FollowThePath>().transform.position = player3.GetComponent<FollowThePath>().shortcutwaypoints[2].transform.position;
                    player3.GetComponent<FollowThePath>().shortcutwaypointIndex = 2;
                    player3.GetComponent<FollowThePath>().shortcutwaypointIndex += 1;
                    ShortcutMovePlayer(3);

                }

                // If you land on pink take a half shot 
                if (player3SCStartWaypoint + diceSideThrown == 3)
                {
                    pinkTakehalfshottile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player3.GetComponent<FollowThePath>().transform.position = player3.GetComponent<FollowThePath>().shortcutwaypoints[3].transform.position;
                    player3.GetComponent<FollowThePath>().shortcutwaypointIndex = 3;
                    player3.GetComponent<FollowThePath>().shortcutwaypointIndex += 1;
                    ShortcutMovePlayer(3);

                }



                // If you land on pink return to start
                if (player3SCStartWaypoint + diceSideThrown == 5)
                {
                    pinkReturntostarttile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player3.GetComponent<FollowThePath>().transform.position = player3.GetComponent<FollowThePath>().waypoints[0].transform.position;


                    player3.GetComponent<FollowThePath>().StartwaypointIndex = 0;

                    player3.GetComponent<FollowThePath>().passed1stShortcut = false;
                    player3.GetComponent<FollowThePath>().passed2ndShortcut = false;
                    player3.GetComponent<FollowThePath>().passed3rdShortcut = false;

                    diceSideThrown = 0;
                    player3StartWaypoint = 0;

                    MovePlayer(3);

                    player3.GetComponent<FollowThePath>().onShortcut = false;

                }


                // If you land on pink make a rule tile 
                if (player3SCStartWaypoint + diceSideThrown == 6)
                {
                    pinkMakearuletile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player3.GetComponent<FollowThePath>().transform.position = player3.GetComponent<FollowThePath>().shortcutwaypoints[6].transform.position;
                    player3.GetComponent<FollowThePath>().shortcutwaypointIndex = 6;
                    player3.GetComponent<FollowThePath>().shortcutwaypointIndex += 1;
                    ShortcutMovePlayer(3);

                }


                // If you land on pink take and give 3 tile 
                if (player3SCStartWaypoint + diceSideThrown == 7)
                {
                    pinkTakeandgive3tile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player3.GetComponent<FollowThePath>().transform.position = player3.GetComponent<FollowThePath>().shortcutwaypoints[7].transform.position;
                    player3.GetComponent<FollowThePath>().shortcutwaypointIndex = 7;
                    player3.GetComponent<FollowThePath>().shortcutwaypointIndex += 1;
                    ShortcutMovePlayer(3);

                }


                // If you land on pink take another shot tile 
                if (player3SCStartWaypoint + diceSideThrown == 9)
                {
                    pinkTakeanothershottile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player3.GetComponent<FollowThePath>().transform.position = player3.GetComponent<FollowThePath>().shortcutwaypoints[9].transform.position;
                    player3.GetComponent<FollowThePath>().shortcutwaypointIndex = 9;
                    player3.GetComponent<FollowThePath>().shortcutwaypointIndex += 1;
                    ShortcutMovePlayer(3);

                }


                // If you land on pink go back and give a shot tile 
                if (player3SCStartWaypoint + diceSideThrown == 10)
                {
                    pinkGobackandgiveashottile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player3.GetComponent<FollowThePath>().transform.position = player3.GetComponent<FollowThePath>().shortcutwaypoints[9].transform.position;
                    player3.GetComponent<FollowThePath>().shortcutwaypointIndex = 9;
                    player3.GetComponent<FollowThePath>().shortcutwaypointIndex += 1;
                    ShortcutMovePlayer(3);


                }



                // If you land on pink finish drink tile 
                if (player3SCStartWaypoint + diceSideThrown == 11)
                {
                    pinkFinishdrinktile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player3.GetComponent<FollowThePath>().transform.position = player3.GetComponent<FollowThePath>().shortcutwaypoints[11].transform.position;
                    player3.GetComponent<FollowThePath>().shortcutwaypointIndex = 11;
                    player3.GetComponent<FollowThePath>().shortcutwaypointIndex += 1;
                    ShortcutMovePlayer(3);

                }





                player3.GetComponent<FollowThePath>().moveAllowed = false;
                player3.GetComponent<FollowThePath>().shortcutmoveAllowed = false;

                NextPlayerMoveTexts(3);

                player3.GetComponent<FollowThePath>().shortcutwaypointIndex -= 1;
                player3SCStartWaypoint = player3.GetComponent<FollowThePath>().shortcutwaypointIndex;

               
            }
        }









        /////////////////////////////////////////////////////// MOVE PLAYER 4 /////////////////////////////////////////////////////////////

        if (player4.GetComponent<FollowThePath>().onShortcut == false && whosturn == 4) // && player4MoveText == true && whosturn == 4) 
        {
            if (player4.GetComponent<FollowThePath>().StartwaypointIndex >
            player4StartWaypoint + diceSideThrown)
            {
                // If you land on red flip a coin tile
                if (player4StartWaypoint + diceSideThrown == 1)
                {
                    redFlipacointile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player4.GetComponent<FollowThePath>().transform.position = player4.GetComponent<FollowThePath>().waypoints[1].transform.position;
                    player4.GetComponent<FollowThePath>().StartwaypointIndex = 1;
                    player4.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(4);

                    
                }

                // If you land on blue make a rule tile 
                if (player4StartWaypoint + diceSideThrown == 2)
                {
                    blueMakearuletile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player4.GetComponent<FollowThePath>().transform.position = player4.GetComponent<FollowThePath>().waypoints[2].transform.position;
                    player4.GetComponent<FollowThePath>().StartwaypointIndex = 2;
                    player4.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(4);

                    
                }

                // If you land on orange categories tile 
                if (player4StartWaypoint + diceSideThrown == 3)
                {
                    orangeCategoriestile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player4.GetComponent<FollowThePath>().transform.position = player4.GetComponent<FollowThePath>().waypoints[3].transform.position;
                    player4.GetComponent<FollowThePath>().StartwaypointIndex = 3;
                    player4.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(4);

                    
                }

                // If you land on yellow shot for shortcut for the first time 

                if (player4.GetComponent<FollowThePath>().passed1stShortcut == false && player4.GetComponent<FollowThePath>().onShortcut == false)
                {
                    if (player4StartWaypoint + diceSideThrown >= 4)
                    {
                        shotforshortcutTile.gameObject.SetActive(true);

                        player4.GetComponent<FollowThePath>().transform.position = player4.GetComponent<FollowThePath>().waypoints[4].transform.position;

                        player4.GetComponent<FollowThePath>().shortcutwaypointIndex = player4StartWaypoint + diceSideThrown - 4;
                        player4.GetComponent<FollowThePath>().StartwaypointIndex = player4StartWaypoint + diceSideThrown + 1;


                        ChooseRoute(4);
                        player4.GetComponent<FollowThePath>().onShortcut = true;
                        player4.GetComponent<FollowThePath>().passed1stShortcut = true;

                     
                    }
                }

                // If you land on red guys drink tile 
                if (player4StartWaypoint + diceSideThrown == 6 && player4.GetComponent<FollowThePath>().passed1stShortcut == true)
                {
                    redGuysdrinktile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player4.GetComponent<FollowThePath>().transform.position = player4.GetComponent<FollowThePath>().waypoints[6].transform.position;
                    player4.GetComponent<FollowThePath>().StartwaypointIndex = 6;
                    player4.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(4);
                }


                // If you land on blue pick a mate tile
                if (player4StartWaypoint + diceSideThrown == 7)
                {
                    bluePickamatetile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player4.GetComponent<FollowThePath>().transform.position = player4.GetComponent<FollowThePath>().waypoints[7].transform.position;
                    player4.GetComponent<FollowThePath>().StartwaypointIndex = 7;
                    player4.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(4);
                }

                // If you land on green never have i ever tile
                if (player4StartWaypoint + diceSideThrown == 8)
                {
                    greenNeverhaveievertile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player4.GetComponent<FollowThePath>().transform.position = player4.GetComponent<FollowThePath>().waypoints[8].transform.position;
                    player4.GetComponent<FollowThePath>().StartwaypointIndex = 8;
                    player4.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(4);
                }


                // If you land on orange prop hunt tile 
                if (player4StartWaypoint + diceSideThrown == 9)
                {
                    orangeProphunttile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player4.GetComponent<FollowThePath>().transform.position = player4.GetComponent<FollowThePath>().waypoints[9].transform.position;
                    player4.GetComponent<FollowThePath>().StartwaypointIndex = 9;
                    player4.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(4);
                }


                // If you land on red hold breath tile 
                if (player4StartWaypoint + diceSideThrown == 10)
                {
                    redHoldbreathtile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player4.GetComponent<FollowThePath>().transform.position = player4.GetComponent<FollowThePath>().waypoints[10].transform.position;
                    player4.GetComponent<FollowThePath>().StartwaypointIndex = 10;
                    player4.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(4);
                }


                // If you land on blue girls drink
                if (player4StartWaypoint + diceSideThrown == 11)
                {
                    blueGirlsdrinktile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);

                    player4.GetComponent<FollowThePath>().transform.position = player4.GetComponent<FollowThePath>().waypoints[11].transform.position;
                    player4.GetComponent<FollowThePath>().StartwaypointIndex = 11;
                    player4.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(4);
                }


                // If you land on yellow shot for shortcut for the first time 
                if (player4.GetComponent<FollowThePath>().passed2ndShortcut == false)
                {
                    if (player4StartWaypoint + diceSideThrown >= 12)
                    {
                        shotforshortcutTile.gameObject.SetActive(true);
                        player4.GetComponent<FollowThePath>().transform.position = player4.GetComponent<FollowThePath>().waypoints[12].transform.position;

                        player4.GetComponent<FollowThePath>().shortcutwaypointIndex = player4StartWaypoint + diceSideThrown - 8;
                        player4.GetComponent<FollowThePath>().StartwaypointIndex = player4StartWaypoint + diceSideThrown + 1;

                        ChooseRoute(4);

                        player4.GetComponent<FollowThePath>().passed2ndShortcut = true;
                    }
                }



                // If you land on green guess a number tile
                if (player4StartWaypoint + diceSideThrown == 14)
                {
                    greenGuessanumbertile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player4.GetComponent<FollowThePath>().transform.position = player4.GetComponent<FollowThePath>().waypoints[14].transform.position;
                    player4.GetComponent<FollowThePath>().StartwaypointIndex = 14;
                    player4.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(4);
                }


                // If you land on orange drive tile
                if (player4StartWaypoint + diceSideThrown == 15)
                {
                    orangeDrivetile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player4.GetComponent<FollowThePath>().transform.position = player4.GetComponent<FollowThePath>().waypoints[15].transform.position;
                    player4.GetComponent<FollowThePath>().StartwaypointIndex = 15;
                    player4.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(4);
                }


                // If you land on red drink what you roll tile
                if (player4StartWaypoint + diceSideThrown == 16)
                {
                    redDrinkwhatyourolltile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player4.GetComponent<FollowThePath>().transform.position = player4.GetComponent<FollowThePath>().waypoints[16].transform.position;
                    player4.GetComponent<FollowThePath>().StartwaypointIndex = 16;
                    player4.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(4);
                }


                // If you land on blue cascade tile
                if (player4StartWaypoint + diceSideThrown == 17)
                {
                    blueCascadetile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player4.GetComponent<FollowThePath>().transform.position = player4.GetComponent<FollowThePath>().waypoints[17].transform.position;
                    player4.GetComponent<FollowThePath>().StartwaypointIndex = 17;
                    player4.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(4);
                }


                // If you land on green price is right tile 
                if (player4StartWaypoint + diceSideThrown == 18)
                {
                    greenPriceisrighttile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player4.GetComponent<FollowThePath>().transform.position = player4.GetComponent<FollowThePath>().waypoints[18].transform.position;
                    player4.GetComponent<FollowThePath>().StartwaypointIndex = 18;
                    player4.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(4);
                }


                // If you land on yellow shot for shortcut for the first time 
                if (player4.GetComponent<FollowThePath>().passed3rdShortcut == false)
                {
                    if (player4StartWaypoint + diceSideThrown >= 19)
                    {
                        shotforshortcutTile.gameObject.SetActive(true);
                        player4.GetComponent<FollowThePath>().transform.position = player4.GetComponent<FollowThePath>().waypoints[19].transform.position;


                        player4.GetComponent<FollowThePath>().shortcutwaypointIndex = player4StartWaypoint + diceSideThrown - 11;
                        player4.GetComponent<FollowThePath>().StartwaypointIndex = player4StartWaypoint + diceSideThrown + 1;

                        ChooseRoute(4);


                        player4.GetComponent<FollowThePath>().passed3rdShortcut = true;


                    }
                }


                // If you land on green everyone take a shot tile 
                if (player4StartWaypoint + diceSideThrown == 21)
                {
                    greenEveryonetakeashottile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player4.GetComponent<FollowThePath>().transform.position = player4.GetComponent<FollowThePath>().waypoints[21].transform.position;
                    player4.GetComponent<FollowThePath>().StartwaypointIndex = 21;
                    player4.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(4);
                }


                // If you land on orange pick an age tile
                if (player4StartWaypoint + diceSideThrown == 22)
                {
                    orangePickanagetile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player4.GetComponent<FollowThePath>().transform.position = player4.GetComponent<FollowThePath>().waypoints[22].transform.position;
                    player4.GetComponent<FollowThePath>().StartwaypointIndex = 22;
                    player4.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(4);
                }


                // If you land on red pick a game tile 
                if (player4StartWaypoint + diceSideThrown == 23)
                {
                    redPickagametile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player4.GetComponent<FollowThePath>().transform.position = player4.GetComponent<FollowThePath>().waypoints[23].transform.position;
                    player4.GetComponent<FollowThePath>().StartwaypointIndex = 23;
                    player4.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(4);
                }


                // If you land on blue you and 2 tile 
                if (player4StartWaypoint + diceSideThrown == 24)
                {
                    blueYouand2tile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player4.GetComponent<FollowThePath>().transform.position = player4.GetComponent<FollowThePath>().waypoints[24].transform.position;
                    player4.GetComponent<FollowThePath>().StartwaypointIndex = 24;
                    player4.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(4);
                }




                player4.GetComponent<FollowThePath>().moveAllowed = false;

                NextPlayerMoveTexts(4);


                player4StartWaypoint = player4.GetComponent<FollowThePath>().StartwaypointIndex - 1;


            }
        }




        // IF PLAYER 4 IS ON THE SHORTCUT 
        if (player4.GetComponent<FollowThePath>().onShortcut == true && whosturn == 4) // && player4MoveText == true && whosturn == 4)
        {
            

            if (player4.GetComponent<FollowThePath>().shortcutwaypointIndex >
            player4SCStartWaypoint + diceSideThrown) // || player1.GetComponent<FollowThePath>().shortcutwaypointIndex == 0)
            {
                // First spot when choosing the shortcut 
                if (player4SCStartWaypoint + diceSideThrown == 0)
                {
                    player4.GetComponent<FollowThePath>().transform.position = player4.GetComponent<FollowThePath>().shortcutwaypoints[0].transform.position;
                    player4.GetComponent<FollowThePath>().shortcutwaypointIndex = 0;
                    player4.GetComponent<FollowThePath>().shortcutwaypointIndex += 1;
                    ShortcutMovePlayer(4);

                }

                // If you land on go back pink go back one
                if (player4SCStartWaypoint + diceSideThrown == 1)
                {
                    pinkGobackonetile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player4.GetComponent<FollowThePath>().transform.position = player4.GetComponent<FollowThePath>().waypoints[4].transform.position;
                    player4.GetComponent<FollowThePath>().StartwaypointIndex = 4;

                    diceSideThrown = 0;
                    player4SCStartWaypoint = 0;
                    player4StartWaypoint = 4;
                    player4.GetComponent<FollowThePath>().passed1stShortcut = false;
                    player4.GetComponent<FollowThePath>().onShortcut = false;
                }


                // If you land on pink waterfall 
                if (player4SCStartWaypoint + diceSideThrown == 2)

                {
                    pinkWaterfalltile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player4.GetComponent<FollowThePath>().transform.position = player4.GetComponent<FollowThePath>().shortcutwaypoints[2].transform.position;
                    player4.GetComponent<FollowThePath>().shortcutwaypointIndex = 2;
                    player4.GetComponent<FollowThePath>().shortcutwaypointIndex += 1;
                    ShortcutMovePlayer(4);

                }

                // If you land on pink take a half shot 
                if (player4SCStartWaypoint + diceSideThrown == 3)
                {
                    pinkTakehalfshottile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player4.GetComponent<FollowThePath>().transform.position = player4.GetComponent<FollowThePath>().shortcutwaypoints[3].transform.position;
                    player4.GetComponent<FollowThePath>().shortcutwaypointIndex = 3;
                    player4.GetComponent<FollowThePath>().shortcutwaypointIndex += 1;
                    ShortcutMovePlayer(4);

                }



                // If you land on pink return to start
                if (player4SCStartWaypoint + diceSideThrown == 5)
                {
                    pinkReturntostarttile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player4.GetComponent<FollowThePath>().transform.position = player4.GetComponent<FollowThePath>().waypoints[0].transform.position;


                    player4.GetComponent<FollowThePath>().StartwaypointIndex = 0;

                    player4.GetComponent<FollowThePath>().passed1stShortcut = false;
                    player4.GetComponent<FollowThePath>().passed2ndShortcut = false;
                    player4.GetComponent<FollowThePath>().passed3rdShortcut = false;

                    diceSideThrown = 0;
                    player4StartWaypoint = 0;

                    MovePlayer(4);

                    player4.GetComponent<FollowThePath>().onShortcut = false;

                }


                // If you land on pink make a rule tile 
                if (player4SCStartWaypoint + diceSideThrown == 6)
                {
                    pinkMakearuletile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player4.GetComponent<FollowThePath>().transform.position = player4.GetComponent<FollowThePath>().shortcutwaypoints[6].transform.position;
                    player4.GetComponent<FollowThePath>().shortcutwaypointIndex = 6;
                    player4.GetComponent<FollowThePath>().shortcutwaypointIndex += 1;
                    ShortcutMovePlayer(4);

                }


                // If you land on pink take and give 3 tile 
                if (player4SCStartWaypoint + diceSideThrown == 7)
                {
                    pinkTakeandgive3tile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player4.GetComponent<FollowThePath>().transform.position = player4.GetComponent<FollowThePath>().shortcutwaypoints[7].transform.position;
                    player4.GetComponent<FollowThePath>().shortcutwaypointIndex = 7;
                    player4.GetComponent<FollowThePath>().shortcutwaypointIndex += 1;
                    ShortcutMovePlayer(4);

                }


                // If you land on pink take another shot tile 
                if (player4SCStartWaypoint + diceSideThrown == 9)
                {
                    pinkTakeanothershottile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player4.GetComponent<FollowThePath>().transform.position = player4.GetComponent<FollowThePath>().shortcutwaypoints[9].transform.position;
                    player4.GetComponent<FollowThePath>().shortcutwaypointIndex = 9;
                    player4.GetComponent<FollowThePath>().shortcutwaypointIndex += 1;
                    ShortcutMovePlayer(4);

                }


                // If you land on pink go back and give a shot tile 
                if (player4SCStartWaypoint + diceSideThrown == 10)
                {
                    pinkGobackandgiveashottile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player4.GetComponent<FollowThePath>().transform.position = player4.GetComponent<FollowThePath>().shortcutwaypoints[9].transform.position;
                    player4.GetComponent<FollowThePath>().shortcutwaypointIndex = 9;
                    player4.GetComponent<FollowThePath>().shortcutwaypointIndex += 1;
                    ShortcutMovePlayer(4);


                }



                // If you land on pink finish drink tile 
                if (player4SCStartWaypoint + diceSideThrown == 11)
                {
                    pinkFinishdrinktile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player4.GetComponent<FollowThePath>().transform.position = player4.GetComponent<FollowThePath>().shortcutwaypoints[11].transform.position;
                    player4.GetComponent<FollowThePath>().shortcutwaypointIndex = 11;
                    player4.GetComponent<FollowThePath>().shortcutwaypointIndex += 1;
                    ShortcutMovePlayer(4);

                }





                player4.GetComponent<FollowThePath>().moveAllowed = false;
                player4.GetComponent<FollowThePath>().shortcutmoveAllowed = false;

                NextPlayerMoveTexts(4);

                player4.GetComponent<FollowThePath>().shortcutwaypointIndex -= 1;
                player4SCStartWaypoint = player4.GetComponent<FollowThePath>().shortcutwaypointIndex;

            
            }
        }




        /////////////////////////////////////////////////////// MOVE PLAYER 5 /////////////////////////////////////////////////////////////

        if (player5.GetComponent<FollowThePath>().onShortcut == false && whosturn == 5) // && player5MoveText == true && whosturn == 5) 
        {
            if (player5.GetComponent<FollowThePath>().StartwaypointIndex >
            player5StartWaypoint + diceSideThrown)
            {
                // If you land on red flip a coin tile
                if (player5StartWaypoint + diceSideThrown == 1)
                {
                    redFlipacointile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player5.GetComponent<FollowThePath>().transform.position = player5.GetComponent<FollowThePath>().waypoints[1].transform.position;
                    player5.GetComponent<FollowThePath>().StartwaypointIndex = 1;
                    player5.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(5);

                    // Debug.Log("START WAYPOINT " + player5StartWaypoint);
                    // Debug.Log("DICE " + diceSideThrown);
                    // Debug.Log("SHORTCUTWAYPOINT INDEX " + player5.GetComponent<FollowThePath>().StartwaypointIndex);
                }

                // If you land on blue make a rule tile 
                if (player5StartWaypoint + diceSideThrown == 2)
                {
                    blueMakearuletile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player5.GetComponent<FollowThePath>().transform.position = player5.GetComponent<FollowThePath>().waypoints[2].transform.position;
                    player5.GetComponent<FollowThePath>().StartwaypointIndex = 2;
                    player5.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(5);

                    // Debug.Log("START WAYPOINT " + player1StartWaypoint);
                    // Debug.Log("DICE " + diceSideThrown);
                    // Debug.Log("SHORTCUTWAYPOINT INDEX " + player1.GetComponent<FollowThePath>().StartwaypointIndex);
                }

                // If you land on orange categories tile 
                if (player5StartWaypoint + diceSideThrown == 3)
                {
                    orangeCategoriestile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player5.GetComponent<FollowThePath>().transform.position = player5.GetComponent<FollowThePath>().waypoints[3].transform.position;
                    player5.GetComponent<FollowThePath>().StartwaypointIndex = 3;
                    player5.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(5);

                    // Debug.Log("START WAYPOINT " + player1StartWaypoint);
                    // Debug.Log("DICE " + diceSideThrown);
                    // Debug.Log("SHORTCUTWAYPOINT INDEX " + player1.GetComponent<FollowThePath>().StartwaypointIndex);
                }

                // If you land on yellow shot for shortcut for the first time 

                if (player5.GetComponent<FollowThePath>().passed1stShortcut == false && player5.GetComponent<FollowThePath>().onShortcut == false)
                {
                    if (player5StartWaypoint + diceSideThrown >= 4)
                    {
                        shotforshortcutTile.gameObject.SetActive(true);

                        player5.GetComponent<FollowThePath>().transform.position = player5.GetComponent<FollowThePath>().waypoints[4].transform.position;

                        player5.GetComponent<FollowThePath>().shortcutwaypointIndex = player5StartWaypoint + diceSideThrown - 4;
                        player5.GetComponent<FollowThePath>().StartwaypointIndex = player5StartWaypoint + diceSideThrown + 1;


                        ChooseRoute(5);
                        player5.GetComponent<FollowThePath>().onShortcut = true;
                        player5.GetComponent<FollowThePath>().passed1stShortcut = true;

                        // Debugs
                        // Debug.Log("START WAYPOINT " + player1StartWaypoint);
                        // Debug.Log("DICE " + diceSideThrown);
                        // Debug.Log("STARTWAYPOINT INDEX " + player1.GetComponent<FollowThePath>().StartwaypointIndex);


                        // player1.GetComponent<FollowThePath>().shortcutwaypointIndex = player1StartWaypoint + diceSideThrown - 4; // 4 - player1StartWaypoint - diceSideThrown * -1;



                    }
                }

              


                // If you land on red guys drink tile 
                if (player5StartWaypoint + diceSideThrown == 6 && player5.GetComponent<FollowThePath>().passed1stShortcut == true)
                {
                    redGuysdrinktile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player5.GetComponent<FollowThePath>().transform.position = player5.GetComponent<FollowThePath>().waypoints[6].transform.position;
                    player5.GetComponent<FollowThePath>().StartwaypointIndex = 6;
                    player5.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(5);
                }


                // If you land on blue pick a mate tile
                if (player5StartWaypoint + diceSideThrown == 7)
                {
                    bluePickamatetile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player5.GetComponent<FollowThePath>().transform.position = player5.GetComponent<FollowThePath>().waypoints[7].transform.position;
                    player5.GetComponent<FollowThePath>().StartwaypointIndex = 7;
                    player5.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(5);
                }

                // If you land on green never have i ever tile
                if (player5StartWaypoint + diceSideThrown == 8)
                {
                    greenNeverhaveievertile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player5.GetComponent<FollowThePath>().transform.position = player5.GetComponent<FollowThePath>().waypoints[8].transform.position;
                    player5.GetComponent<FollowThePath>().StartwaypointIndex = 8;
                    player5.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(5);
                }


                // If you land on orange prop hunt tile 
                if (player5StartWaypoint + diceSideThrown == 9)
                {
                    orangeProphunttile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player5.GetComponent<FollowThePath>().transform.position = player5.GetComponent<FollowThePath>().waypoints[9].transform.position;
                    player5.GetComponent<FollowThePath>().StartwaypointIndex = 9;
                    player5.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(5);
                }


                // If you land on red hold breath tile 
                if (player5StartWaypoint + diceSideThrown == 10)
                {
                    redHoldbreathtile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player5.GetComponent<FollowThePath>().transform.position = player5.GetComponent<FollowThePath>().waypoints[10].transform.position;
                    player5.GetComponent<FollowThePath>().StartwaypointIndex = 10;
                    player5.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(5);
                }


                // If you land on blue girls drink
                if (player5StartWaypoint + diceSideThrown == 11)
                {
                    blueGirlsdrinktile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);

                    player5.GetComponent<FollowThePath>().transform.position = player5.GetComponent<FollowThePath>().waypoints[11].transform.position;
                    player5.GetComponent<FollowThePath>().StartwaypointIndex = 11;
                    player5.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(5);
                }


                // If you land on yellow shot for shortcut for the first time 
                if (player5.GetComponent<FollowThePath>().passed2ndShortcut == false)
                {
                    if (player5StartWaypoint + diceSideThrown >= 12)
                    {
                        shotforshortcutTile.gameObject.SetActive(true);
                        player5.GetComponent<FollowThePath>().transform.position = player5.GetComponent<FollowThePath>().waypoints[12].transform.position;

                        player5.GetComponent<FollowThePath>().shortcutwaypointIndex = player5StartWaypoint + diceSideThrown - 8;
                        player5.GetComponent<FollowThePath>().StartwaypointIndex = player5StartWaypoint + diceSideThrown + 1;

                        ChooseRoute(5);

                        player5.GetComponent<FollowThePath>().passed2ndShortcut = true;
                    }
                }



                // If you land on green guess a number tile
                if (player5StartWaypoint + diceSideThrown == 14)
                {
                    greenGuessanumbertile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player5.GetComponent<FollowThePath>().transform.position = player5.GetComponent<FollowThePath>().waypoints[14].transform.position;
                    player5.GetComponent<FollowThePath>().StartwaypointIndex = 14;
                    player5.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(5);
                }


                // If you land on orange drive tile
                if (player5StartWaypoint + diceSideThrown == 15)
                {
                    orangeDrivetile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player5.GetComponent<FollowThePath>().transform.position = player5.GetComponent<FollowThePath>().waypoints[15].transform.position;
                    player5.GetComponent<FollowThePath>().StartwaypointIndex = 15;
                    player5.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(5);
                }


                // If you land on red drink what you roll tile
                if (player5StartWaypoint + diceSideThrown == 16)
                {
                    redDrinkwhatyourolltile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player5.GetComponent<FollowThePath>().transform.position = player5.GetComponent<FollowThePath>().waypoints[16].transform.position;
                    player5.GetComponent<FollowThePath>().StartwaypointIndex = 16;
                    player5.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(5);
                }


                // If you land on blue cascade tile
                if (player5StartWaypoint + diceSideThrown == 17)
                {
                    blueCascadetile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player5.GetComponent<FollowThePath>().transform.position = player5.GetComponent<FollowThePath>().waypoints[17].transform.position;
                    player5.GetComponent<FollowThePath>().StartwaypointIndex = 17;
                    player5.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(5);
                }


                // If you land on green price is right tile 
                if (player5StartWaypoint + diceSideThrown == 18)
                {
                    greenPriceisrighttile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player5.GetComponent<FollowThePath>().transform.position = player5.GetComponent<FollowThePath>().waypoints[18].transform.position;
                    player5.GetComponent<FollowThePath>().StartwaypointIndex = 18;
                    player5.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(5);
                }


                // If you land on yellow shot for shortcut for the first time 
                if (player5.GetComponent<FollowThePath>().passed3rdShortcut == false)
                {
                    if (player5StartWaypoint + diceSideThrown >= 19)
                    {
                        shotforshortcutTile.gameObject.SetActive(true);
                        player5.GetComponent<FollowThePath>().transform.position = player5.GetComponent<FollowThePath>().waypoints[19].transform.position;


                        player5.GetComponent<FollowThePath>().shortcutwaypointIndex = player5StartWaypoint + diceSideThrown - 11;
                        player5.GetComponent<FollowThePath>().StartwaypointIndex = player5StartWaypoint + diceSideThrown + 1;

                        ChooseRoute(5);


                        player5.GetComponent<FollowThePath>().passed3rdShortcut = true;


                    }
                }


                // If you land on green everyone take a shot tile 
                if (player5StartWaypoint + diceSideThrown == 21)
                {
                    greenEveryonetakeashottile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player5.GetComponent<FollowThePath>().transform.position = player5.GetComponent<FollowThePath>().waypoints[21].transform.position;
                    player5.GetComponent<FollowThePath>().StartwaypointIndex = 21;
                    player5.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(5);
                }


                // If you land on orange pick an age tile
                if (player5StartWaypoint + diceSideThrown == 22)
                {
                    orangePickanagetile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player5.GetComponent<FollowThePath>().transform.position = player5.GetComponent<FollowThePath>().waypoints[22].transform.position;
                    player5.GetComponent<FollowThePath>().StartwaypointIndex = 22;
                    player5.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(5);
                }


                // If you land on red pick a game tile 
                if (player5StartWaypoint + diceSideThrown == 23)
                {
                    redPickagametile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player5.GetComponent<FollowThePath>().transform.position = player5.GetComponent<FollowThePath>().waypoints[23].transform.position;
                    player5.GetComponent<FollowThePath>().StartwaypointIndex = 23;
                    player5.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(5);
                }


                // If you land on blue you and 2 tile 
                if (player5StartWaypoint + diceSideThrown == 24)
                {
                    blueYouand2tile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player5.GetComponent<FollowThePath>().transform.position = player5.GetComponent<FollowThePath>().waypoints[24].transform.position;
                    player5.GetComponent<FollowThePath>().StartwaypointIndex = 24;
                    player5.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(5);
                }




                player5.GetComponent<FollowThePath>().moveAllowed = false;

                NextPlayerMoveTexts(5);

                Debug.Log("player 3 move showing ");

                player5StartWaypoint = player5.GetComponent<FollowThePath>().StartwaypointIndex - 1;


            }
        }




        // IF PLAYER 4 IS ON THE SHORTCUT 
        if (player5.GetComponent<FollowThePath>().onShortcut == true && whosturn == 5) // && player5MoveText == true && whosturn == 5)
        {
            // Debug.Log("POSITION " + player1.GetComponent<FollowThePath>().transform.position);
            // Debug.Log("P1SC + DICEROLL :" + player1SCStartWaypoint + diceSideThrown);

            if (player5.GetComponent<FollowThePath>().shortcutwaypointIndex >
            player5SCStartWaypoint + diceSideThrown) // || player1.GetComponent<FollowThePath>().shortcutwaypointIndex == 0)
            {
                // First spot when choosing the shortcut 
                if (player5SCStartWaypoint + diceSideThrown == 0)
                {
                    player5.GetComponent<FollowThePath>().transform.position = player5.GetComponent<FollowThePath>().shortcutwaypoints[0].transform.position;
                    player5.GetComponent<FollowThePath>().shortcutwaypointIndex = 0;
                    player5.GetComponent<FollowThePath>().shortcutwaypointIndex += 1;
                    ShortcutMovePlayer(5);

                }

                // If you land on go back pink go back one
                if (player5SCStartWaypoint + diceSideThrown == 1)
                {
                    pinkGobackonetile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player5.GetComponent<FollowThePath>().transform.position = player5.GetComponent<FollowThePath>().waypoints[4].transform.position;
                    player5.GetComponent<FollowThePath>().StartwaypointIndex = 4;

                    diceSideThrown = 0;
                    player5SCStartWaypoint = 0;
                    player5StartWaypoint = 4;
                    player5.GetComponent<FollowThePath>().passed1stShortcut = false;
                    player5.GetComponent<FollowThePath>().onShortcut = false;
                }


                // If you land on pink waterfall 
                if (player5SCStartWaypoint + diceSideThrown == 2)

                {
                    pinkWaterfalltile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player5.GetComponent<FollowThePath>().transform.position = player5.GetComponent<FollowThePath>().shortcutwaypoints[2].transform.position;
                    player5.GetComponent<FollowThePath>().shortcutwaypointIndex = 2;
                    player5.GetComponent<FollowThePath>().shortcutwaypointIndex += 1;
                    ShortcutMovePlayer(5);

                }

                // If you land on pink take a half shot 
                if (player5SCStartWaypoint + diceSideThrown == 3)
                {
                    pinkTakehalfshottile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player5.GetComponent<FollowThePath>().transform.position = player5.GetComponent<FollowThePath>().shortcutwaypoints[3].transform.position;
                    player5.GetComponent<FollowThePath>().shortcutwaypointIndex = 3;
                    player5.GetComponent<FollowThePath>().shortcutwaypointIndex += 1;
                    ShortcutMovePlayer(5);

                }



                // If you land on pink return to start
                if (player5SCStartWaypoint + diceSideThrown == 5)
                {
                    pinkReturntostarttile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player5.GetComponent<FollowThePath>().transform.position = player5.GetComponent<FollowThePath>().waypoints[0].transform.position;


                    player5.GetComponent<FollowThePath>().StartwaypointIndex = 0;

                    player5.GetComponent<FollowThePath>().passed1stShortcut = false;
                    player5.GetComponent<FollowThePath>().passed2ndShortcut = false;
                    player5.GetComponent<FollowThePath>().passed3rdShortcut = false;

                    diceSideThrown = 0;
                    player5StartWaypoint = 0;

                    MovePlayer(5);

                    player5.GetComponent<FollowThePath>().onShortcut = false;

                }


                // If you land on pink make a rule tile 
                if (player5SCStartWaypoint + diceSideThrown == 6)
                {
                    pinkMakearuletile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player5.GetComponent<FollowThePath>().transform.position = player5.GetComponent<FollowThePath>().shortcutwaypoints[6].transform.position;
                    player5.GetComponent<FollowThePath>().shortcutwaypointIndex = 6;
                    player5.GetComponent<FollowThePath>().shortcutwaypointIndex += 1;
                    ShortcutMovePlayer(5);

                }


                // If you land on pink take and give 3 tile 
                if (player5SCStartWaypoint + diceSideThrown == 7)
                {
                    pinkTakeandgive3tile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player5.GetComponent<FollowThePath>().transform.position = player5.GetComponent<FollowThePath>().shortcutwaypoints[7].transform.position;
                    player5.GetComponent<FollowThePath>().shortcutwaypointIndex = 7;
                    player5.GetComponent<FollowThePath>().shortcutwaypointIndex += 1;
                    ShortcutMovePlayer(5);

                }


                // If you land on pink take another shot tile 
                if (player5SCStartWaypoint + diceSideThrown == 9)
                {
                    pinkTakeanothershottile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player5.GetComponent<FollowThePath>().transform.position = player5.GetComponent<FollowThePath>().shortcutwaypoints[9].transform.position;
                    player5.GetComponent<FollowThePath>().shortcutwaypointIndex = 9;
                    player5.GetComponent<FollowThePath>().shortcutwaypointIndex += 1;
                    ShortcutMovePlayer(5);

                }


                // If you land on pink go back and give a shot tile 
                if (player5SCStartWaypoint + diceSideThrown == 10)
                {
                    pinkGobackandgiveashottile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player5.GetComponent<FollowThePath>().transform.position = player5.GetComponent<FollowThePath>().shortcutwaypoints[9].transform.position;
                    player5.GetComponent<FollowThePath>().shortcutwaypointIndex = 9;
                    player5.GetComponent<FollowThePath>().shortcutwaypointIndex += 1;
                    ShortcutMovePlayer(5);


                }



                // If you land on pink finish drink tile 
                if (player5SCStartWaypoint + diceSideThrown == 11)
                {
                    pinkFinishdrinktile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player5.GetComponent<FollowThePath>().transform.position = player5.GetComponent<FollowThePath>().shortcutwaypoints[11].transform.position;
                    player5.GetComponent<FollowThePath>().shortcutwaypointIndex = 11;
                    player5.GetComponent<FollowThePath>().shortcutwaypointIndex += 1;
                    ShortcutMovePlayer(5);

                }





                player5.GetComponent<FollowThePath>().moveAllowed = false;
                player5.GetComponent<FollowThePath>().shortcutmoveAllowed = false;

                NextPlayerMoveTexts(5);

                player5.GetComponent<FollowThePath>().shortcutwaypointIndex -= 1;
                player5SCStartWaypoint = player5.GetComponent<FollowThePath>().shortcutwaypointIndex;

                // player2MoveText.gameObject.SetActive(false);
                // player1MoveText.gameObject.SetActive(true);
            }
        }








        /////////////////////////////////////////////////////// MOVE PLAYER 6 /////////////////////////////////////////////////////////////

        if (player6.GetComponent<FollowThePath>().onShortcut == false && whosturn == 6) // && player6MoveText == true && whosturn == 6) 
        {
            if (player6.GetComponent<FollowThePath>().StartwaypointIndex >
            player6StartWaypoint + diceSideThrown)
            {
                // If you land on red flip a coin tile
                if (player6StartWaypoint + diceSideThrown == 1)
                {
                    redFlipacointile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player6.GetComponent<FollowThePath>().transform.position = player6.GetComponent<FollowThePath>().waypoints[1].transform.position;
                    player6.GetComponent<FollowThePath>().StartwaypointIndex = 1;
                    player6.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(6);

                    // Debug.Log("START WAYPOINT " + player6StartWaypoint);
                    // Debug.Log("DICE " + diceSideThrown);
                    // Debug.Log("SHORTCUTWAYPOINT INDEX " + player6.GetComponent<FollowThePath>().StartwaypointIndex);
                }

                // If you land on blue make a rule tile 
                if (player6StartWaypoint + diceSideThrown == 2)
                {
                    blueMakearuletile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player6.GetComponent<FollowThePath>().transform.position = player6.GetComponent<FollowThePath>().waypoints[2].transform.position;
                    player6.GetComponent<FollowThePath>().StartwaypointIndex = 2;
                    player6.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(6);

                    // Debug.Log("START WAYPOINT " + player1StartWaypoint);
                    // Debug.Log("DICE " + diceSideThrown);
                    // Debug.Log("SHORTCUTWAYPOINT INDEX " + player1.GetComponent<FollowThePath>().StartwaypointIndex);
                }

                // If you land on orange categories tile 
                if (player6StartWaypoint + diceSideThrown == 3)
                {
                    orangeCategoriestile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player6.GetComponent<FollowThePath>().transform.position = player6.GetComponent<FollowThePath>().waypoints[3].transform.position;
                    player6.GetComponent<FollowThePath>().StartwaypointIndex = 3;
                    player6.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(6);

                    // Debug.Log("START WAYPOINT " + player1StartWaypoint);
                    // Debug.Log("DICE " + diceSideThrown);
                    // Debug.Log("SHORTCUTWAYPOINT INDEX " + player1.GetComponent<FollowThePath>().StartwaypointIndex);
                }

                // If you land on yellow shot for shortcut for the first time 

                if (player6.GetComponent<FollowThePath>().passed1stShortcut == false && player6.GetComponent<FollowThePath>().onShortcut == false)
                {
                    if (player6StartWaypoint + diceSideThrown >= 4)
                    {
                        shotforshortcutTile.gameObject.SetActive(true);

                        player6.GetComponent<FollowThePath>().transform.position = player6.GetComponent<FollowThePath>().waypoints[4].transform.position;

                        player6.GetComponent<FollowThePath>().shortcutwaypointIndex = player6StartWaypoint + diceSideThrown - 4;
                        player6.GetComponent<FollowThePath>().StartwaypointIndex = player6StartWaypoint + diceSideThrown + 1;


                        ChooseRoute(6);
                        player6.GetComponent<FollowThePath>().onShortcut = true;
                        player6.GetComponent<FollowThePath>().passed1stShortcut = true;

                        // Debugs
                        // Debug.Log("START WAYPOINT " + player1StartWaypoint);
                        // Debug.Log("DICE " + diceSideThrown);
                        // Debug.Log("STARTWAYPOINT INDEX " + player1.GetComponent<FollowThePath>().StartwaypointIndex);


                        // player1.GetComponent<FollowThePath>().shortcutwaypointIndex = player1StartWaypoint + diceSideThrown - 4; // 4 - player1StartWaypoint - diceSideThrown * -1;



                    }
                }


                // If you land on red guys drink tile 
                if (player6StartWaypoint + diceSideThrown == 6 && player6.GetComponent<FollowThePath>().passed1stShortcut == true)
                {
                    redGuysdrinktile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player6.GetComponent<FollowThePath>().transform.position = player6.GetComponent<FollowThePath>().waypoints[6].transform.position;
                    player6.GetComponent<FollowThePath>().StartwaypointIndex = 6;
                    player6.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(6);
                }


                // If you land on blue pick a mate tile
                if (player6StartWaypoint + diceSideThrown == 7)
                {
                    bluePickamatetile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player6.GetComponent<FollowThePath>().transform.position = player6.GetComponent<FollowThePath>().waypoints[7].transform.position;
                    player6.GetComponent<FollowThePath>().StartwaypointIndex = 7;
                    player6.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(6);
                }

                // If you land on green never have i ever tile
                if (player6StartWaypoint + diceSideThrown == 8)
                {
                    greenNeverhaveievertile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player6.GetComponent<FollowThePath>().transform.position = player6.GetComponent<FollowThePath>().waypoints[8].transform.position;
                    player6.GetComponent<FollowThePath>().StartwaypointIndex = 8;
                    player6.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(6);
                }


                // If you land on orange prop hunt tile 
                if (player6StartWaypoint + diceSideThrown == 9)
                {
                    orangeProphunttile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player6.GetComponent<FollowThePath>().transform.position = player6.GetComponent<FollowThePath>().waypoints[9].transform.position;
                    player6.GetComponent<FollowThePath>().StartwaypointIndex = 9;
                    player6.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(6);
                }


                // If you land on red hold breath tile 
                if (player6StartWaypoint + diceSideThrown == 10)
                {
                    redHoldbreathtile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player6.GetComponent<FollowThePath>().transform.position = player6.GetComponent<FollowThePath>().waypoints[10].transform.position;
                    player6.GetComponent<FollowThePath>().StartwaypointIndex = 10;
                    player6.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(6);
                }


                // If you land on blue girls drink
                if (player6StartWaypoint + diceSideThrown == 11)
                {
                    blueGirlsdrinktile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);

                    player6.GetComponent<FollowThePath>().transform.position = player6.GetComponent<FollowThePath>().waypoints[11].transform.position;
                    player6.GetComponent<FollowThePath>().StartwaypointIndex = 11;
                    player6.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(6);
                }


                // If you land on yellow shot for shortcut for the first time 
                if (player6.GetComponent<FollowThePath>().passed2ndShortcut == false)
                {
                    if (player6StartWaypoint + diceSideThrown >= 12)
                    {
                        shotforshortcutTile.gameObject.SetActive(true);
                        player6.GetComponent<FollowThePath>().transform.position = player6.GetComponent<FollowThePath>().waypoints[12].transform.position;

                        player6.GetComponent<FollowThePath>().shortcutwaypointIndex = player6StartWaypoint + diceSideThrown - 8;
                        player6.GetComponent<FollowThePath>().StartwaypointIndex = player6StartWaypoint + diceSideThrown + 1;

                        ChooseRoute(6);

                        player6.GetComponent<FollowThePath>().passed2ndShortcut = true;
                    }
                }



                // If you land on green guess a number tile
                if (player6StartWaypoint + diceSideThrown == 14)
                {
                    greenGuessanumbertile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player6.GetComponent<FollowThePath>().transform.position = player6.GetComponent<FollowThePath>().waypoints[14].transform.position;
                    player6.GetComponent<FollowThePath>().StartwaypointIndex = 14;
                    player6.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(6);
                }


                // If you land on orange drive tile
                if (player6StartWaypoint + diceSideThrown == 15)
                {
                    orangeDrivetile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player6.GetComponent<FollowThePath>().transform.position = player6.GetComponent<FollowThePath>().waypoints[15].transform.position;
                    player6.GetComponent<FollowThePath>().StartwaypointIndex = 15;
                    player6.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(6);
                }


                // If you land on red drink what you roll tile
                if (player6StartWaypoint + diceSideThrown == 16)
                {
                    redDrinkwhatyourolltile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player6.GetComponent<FollowThePath>().transform.position = player6.GetComponent<FollowThePath>().waypoints[16].transform.position;
                    player6.GetComponent<FollowThePath>().StartwaypointIndex = 16;
                    player6.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(6);
                }


                // If you land on blue cascade tile
                if (player6StartWaypoint + diceSideThrown == 17)
                {
                    blueCascadetile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player6.GetComponent<FollowThePath>().transform.position = player6.GetComponent<FollowThePath>().waypoints[17].transform.position;
                    player6.GetComponent<FollowThePath>().StartwaypointIndex = 17;
                    player6.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(6);
                }


                // If you land on green price is right tile 
                if (player6StartWaypoint + diceSideThrown == 18)
                {
                    greenPriceisrighttile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player6.GetComponent<FollowThePath>().transform.position = player6.GetComponent<FollowThePath>().waypoints[18].transform.position;
                    player6.GetComponent<FollowThePath>().StartwaypointIndex = 18;
                    player6.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(6);
                }


                // If you land on yellow shot for shortcut for the first time 
                if (player6.GetComponent<FollowThePath>().passed3rdShortcut == false)
                {
                    if (player6StartWaypoint + diceSideThrown >= 19)
                    {
                        shotforshortcutTile.gameObject.SetActive(true);
                        player6.GetComponent<FollowThePath>().transform.position = player6.GetComponent<FollowThePath>().waypoints[19].transform.position;


                        player6.GetComponent<FollowThePath>().shortcutwaypointIndex = player6StartWaypoint + diceSideThrown - 11;
                        player6.GetComponent<FollowThePath>().StartwaypointIndex = player6StartWaypoint + diceSideThrown + 1;

                        ChooseRoute(6);


                        player6.GetComponent<FollowThePath>().passed3rdShortcut = true;


                    }
                }


                // If you land on green everyone take a shot tile 
                if (player6StartWaypoint + diceSideThrown == 21)
                {
                    greenEveryonetakeashottile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player6.GetComponent<FollowThePath>().transform.position = player6.GetComponent<FollowThePath>().waypoints[21].transform.position;
                    player6.GetComponent<FollowThePath>().StartwaypointIndex = 21;
                    player6.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(6);
                }


                // If you land on orange pick an age tile
                if (player6StartWaypoint + diceSideThrown == 22)
                {
                    orangePickanagetile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player6.GetComponent<FollowThePath>().transform.position = player6.GetComponent<FollowThePath>().waypoints[22].transform.position;
                    player6.GetComponent<FollowThePath>().StartwaypointIndex = 22;
                    player6.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(6);
                }


                // If you land on red pick a game tile 
                if (player6StartWaypoint + diceSideThrown == 23)
                {
                    redPickagametile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player6.GetComponent<FollowThePath>().transform.position = player6.GetComponent<FollowThePath>().waypoints[23].transform.position;
                    player6.GetComponent<FollowThePath>().StartwaypointIndex = 23;
                    player6.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(6);
                }


                // If you land on blue you and 2 tile 
                if (player6StartWaypoint + diceSideThrown == 24)
                {
                    blueYouand2tile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player6.GetComponent<FollowThePath>().transform.position = player6.GetComponent<FollowThePath>().waypoints[24].transform.position;
                    player6.GetComponent<FollowThePath>().StartwaypointIndex = 24;
                    player6.GetComponent<FollowThePath>().StartwaypointIndex += 1;
                    MovePlayer(6);
                }




                player6.GetComponent<FollowThePath>().moveAllowed = false;

                NextPlayerMoveTexts(6);

                

                player6StartWaypoint = player6.GetComponent<FollowThePath>().StartwaypointIndex - 1;


            }
        }




        // IF PLAYER 6 IS ON THE SHORTCUT 
        if (player6.GetComponent<FollowThePath>().onShortcut == true && whosturn == 6) // && player6MoveText == true && whosturn == 6)
        {
            // Debug.Log("POSITION " + player1.GetComponent<FollowThePath>().transform.position);
            // Debug.Log("P1SC + DICEROLL :" + player1SCStartWaypoint + diceSideThrown);

            if (player6.GetComponent<FollowThePath>().shortcutwaypointIndex >
            player6SCStartWaypoint + diceSideThrown) // || player1.GetComponent<FollowThePath>().shortcutwaypointIndex == 0)
            {
                // First spot when choosing the shortcut 
                if (player6SCStartWaypoint + diceSideThrown == 0)
                {
                    player6.GetComponent<FollowThePath>().transform.position = player6.GetComponent<FollowThePath>().shortcutwaypoints[0].transform.position;
                    player6.GetComponent<FollowThePath>().shortcutwaypointIndex = 0;
                    player6.GetComponent<FollowThePath>().shortcutwaypointIndex += 1;
                    ShortcutMovePlayer(6);

                }

                // If you land on go back pink go back one
                if (player6SCStartWaypoint + diceSideThrown == 1)
                {
                    pinkGobackonetile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player6.GetComponent<FollowThePath>().transform.position = player6.GetComponent<FollowThePath>().waypoints[4].transform.position;
                    player6.GetComponent<FollowThePath>().StartwaypointIndex = 4;

                    diceSideThrown = 0;
                    player6SCStartWaypoint = 0;
                    player6StartWaypoint = 4;
                    player6.GetComponent<FollowThePath>().passed1stShortcut = false;
                    player6.GetComponent<FollowThePath>().onShortcut = false;
                }


                // If you land on pink waterfall 
                if (player6SCStartWaypoint + diceSideThrown == 2)

                {
                    pinkWaterfalltile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player6.GetComponent<FollowThePath>().transform.position = player6.GetComponent<FollowThePath>().shortcutwaypoints[2].transform.position;
                    player6.GetComponent<FollowThePath>().shortcutwaypointIndex = 2;
                    player6.GetComponent<FollowThePath>().shortcutwaypointIndex += 1;
                    ShortcutMovePlayer(6);

                }

                // If you land on pink take a half shot 
                if (player6SCStartWaypoint + diceSideThrown == 3)
                {
                    pinkTakehalfshottile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player6.GetComponent<FollowThePath>().transform.position = player6.GetComponent<FollowThePath>().shortcutwaypoints[3].transform.position;
                    player6.GetComponent<FollowThePath>().shortcutwaypointIndex = 3;
                    player6.GetComponent<FollowThePath>().shortcutwaypointIndex += 1;
                    ShortcutMovePlayer(6);

                }



                // If you land on pink return to start
                if (player6SCStartWaypoint + diceSideThrown == 5)
                {
                    pinkReturntostarttile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player6.GetComponent<FollowThePath>().transform.position = player6.GetComponent<FollowThePath>().waypoints[0].transform.position;


                    player6.GetComponent<FollowThePath>().StartwaypointIndex = 0;

                    player6.GetComponent<FollowThePath>().passed1stShortcut = false;
                    player6.GetComponent<FollowThePath>().passed2ndShortcut = false;
                    player6.GetComponent<FollowThePath>().passed3rdShortcut = false;

                    diceSideThrown = 0;
                    player6StartWaypoint = 0;

                    MovePlayer(6);

                    player6.GetComponent<FollowThePath>().onShortcut = false;

                }


                // If you land on pink make a rule tile 
                if (player6SCStartWaypoint + diceSideThrown == 6)
                {
                    pinkMakearuletile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player6.GetComponent<FollowThePath>().transform.position = player6.GetComponent<FollowThePath>().shortcutwaypoints[6].transform.position;
                    player6.GetComponent<FollowThePath>().shortcutwaypointIndex = 6;
                    player6.GetComponent<FollowThePath>().shortcutwaypointIndex += 1;
                    ShortcutMovePlayer(6);

                }


                // If you land on pink take and give 3 tile 
                if (player6SCStartWaypoint + diceSideThrown == 7)
                {
                    pinkTakeandgive3tile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player6.GetComponent<FollowThePath>().transform.position = player6.GetComponent<FollowThePath>().shortcutwaypoints[7].transform.position;
                    player6.GetComponent<FollowThePath>().shortcutwaypointIndex = 7;
                    player6.GetComponent<FollowThePath>().shortcutwaypointIndex += 1;
                    ShortcutMovePlayer(6);

                }


                // If you land on pink take another shot tile 
                if (player6SCStartWaypoint + diceSideThrown == 9)
                {
                    pinkTakeanothershottile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player6.GetComponent<FollowThePath>().transform.position = player6.GetComponent<FollowThePath>().shortcutwaypoints[9].transform.position;
                    player6.GetComponent<FollowThePath>().shortcutwaypointIndex = 9;
                    player6.GetComponent<FollowThePath>().shortcutwaypointIndex += 1;
                    ShortcutMovePlayer(6);

                }


                // If you land on pink go back and give a shot tile 
                if (player6SCStartWaypoint + diceSideThrown == 10)
                {
                    pinkGobackandgiveashottile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player6.GetComponent<FollowThePath>().transform.position = player6.GetComponent<FollowThePath>().shortcutwaypoints[9].transform.position;
                    player6.GetComponent<FollowThePath>().shortcutwaypointIndex = 9;
                    player6.GetComponent<FollowThePath>().shortcutwaypointIndex += 1;
                    ShortcutMovePlayer(6);


                }



                // If you land on pink finish drink tile 
                if (player6SCStartWaypoint + diceSideThrown == 11)
                {
                    pinkFinishdrinktile.gameObject.SetActive(true);
                    clicktocontinueText.gameObject.SetActive(true);
                    player6.GetComponent<FollowThePath>().transform.position = player6.GetComponent<FollowThePath>().shortcutwaypoints[11].transform.position;
                    player6.GetComponent<FollowThePath>().shortcutwaypointIndex = 11;
                    player6.GetComponent<FollowThePath>().shortcutwaypointIndex += 1;
                    ShortcutMovePlayer(6);

                }





                player6.GetComponent<FollowThePath>().moveAllowed = false;
                player6.GetComponent<FollowThePath>().shortcutmoveAllowed = false;

                NextPlayerMoveTexts(6);

                player6.GetComponent<FollowThePath>().shortcutwaypointIndex -= 1;
                player6SCStartWaypoint = player6.GetComponent<FollowThePath>().shortcutwaypointIndex;

                
            }
        }










        // If someone wins end game 
        if (player1.GetComponent<FollowThePath>().StartwaypointIndex ==
          player1.GetComponent<FollowThePath>().waypoints.Length)
        {
            whoWinsTextShadow.gameObject.SetActive(true);
            player1MoveText.gameObject.SetActive(false);
            player2MoveText.gameObject.SetActive(false);
            player3MoveText.gameObject.SetActive(false);
            player4MoveText.gameObject.SetActive(false);
            player5MoveText.gameObject.SetActive(false);
            player6MoveText.gameObject.SetActive(false);
            whoWinsTextShadow.GetComponent<Text>().text = "Player 1 Wins";
            gameOver = true;
        }

        if (player2.GetComponent<FollowThePath>().StartwaypointIndex ==
            player2.GetComponent<FollowThePath>().waypoints.Length)
        {
            whoWinsTextShadow.gameObject.SetActive(true);
            player1MoveText.gameObject.SetActive(false);
            player2MoveText.gameObject.SetActive(false);
            player3MoveText.gameObject.SetActive(false);
            player4MoveText.gameObject.SetActive(false);
            player5MoveText.gameObject.SetActive(false);
            player6MoveText.gameObject.SetActive(false);
            whoWinsTextShadow.GetComponent<Text>().text = "Player 2 Wins";
            gameOver = true;
        }

        if (player3.GetComponent<FollowThePath>().StartwaypointIndex ==
            player3.GetComponent<FollowThePath>().waypoints.Length)
        {
            whoWinsTextShadow.gameObject.SetActive(true);
            player1MoveText.gameObject.SetActive(false);
            player2MoveText.gameObject.SetActive(false);
            player3MoveText.gameObject.SetActive(false);
            player4MoveText.gameObject.SetActive(false);
            player5MoveText.gameObject.SetActive(false);
            player6MoveText.gameObject.SetActive(false);
            whoWinsTextShadow.GetComponent<Text>().text = "Player 3 Wins";
            gameOver = true;
        }

        if (player4.GetComponent<FollowThePath>().StartwaypointIndex ==
            player4.GetComponent<FollowThePath>().waypoints.Length)
        {
            whoWinsTextShadow.gameObject.SetActive(true);
            player1MoveText.gameObject.SetActive(false);
            player2MoveText.gameObject.SetActive(false);
            player3MoveText.gameObject.SetActive(false);
            player4MoveText.gameObject.SetActive(false);
            player5MoveText.gameObject.SetActive(false);
            player6MoveText.gameObject.SetActive(false);
            whoWinsTextShadow.GetComponent<Text>().text = "Player 4 Wins";
            gameOver = true;
        }

        if (player5.GetComponent<FollowThePath>().StartwaypointIndex ==
            player5.GetComponent<FollowThePath>().waypoints.Length)
        {
            whoWinsTextShadow.gameObject.SetActive(true);
            player1MoveText.gameObject.SetActive(false);
            player2MoveText.gameObject.SetActive(false);
            player3MoveText.gameObject.SetActive(false);
            player4MoveText.gameObject.SetActive(false);
            player5MoveText.gameObject.SetActive(false);
            player6MoveText.gameObject.SetActive(false);
            whoWinsTextShadow.GetComponent<Text>().text = "Player 5 Wins";
            gameOver = true;
        }

        if (player6.GetComponent<FollowThePath>().StartwaypointIndex ==
            player6.GetComponent<FollowThePath>().waypoints.Length)
        {
            whoWinsTextShadow.gameObject.SetActive(true);
            player1MoveText.gameObject.SetActive(false);
            player2MoveText.gameObject.SetActive(false);
            player3MoveText.gameObject.SetActive(false);
            player4MoveText.gameObject.SetActive(false);
            player5MoveText.gameObject.SetActive(false);
            player6MoveText.gameObject.SetActive(false);
            whoWinsTextShadow.GetComponent<Text>().text = "Player 6 Wins";
            gameOver = true;
        }

    }


    public static void NextPlayerMoveTexts(int whosturnisit)
    {
        switch (whosturnisit)
        {
            case 1:
                if (numofPlayers == 1)
                {
                    player1MoveText.gameObject.SetActive(true);
                    player2MoveText.gameObject.SetActive(false);
                    player3MoveText.gameObject.SetActive(false);
                    player4MoveText.gameObject.SetActive(false);
                    player5MoveText.gameObject.SetActive(false);
                    player6MoveText.gameObject.SetActive(false);
                }
                else
                {
                    player1MoveText.gameObject.SetActive(false);
                    player2MoveText.gameObject.SetActive(true);
                    player3MoveText.gameObject.SetActive(false);
                    player4MoveText.gameObject.SetActive(false);
                    player5MoveText.gameObject.SetActive(false);
                    player6MoveText.gameObject.SetActive(false);
                }
                break;

            case 2:
                if (numofPlayers == 2)
                {
                    player1MoveText.gameObject.SetActive(true);
                    player2MoveText.gameObject.SetActive(false);
                    player3MoveText.gameObject.SetActive(false);
                    player4MoveText.gameObject.SetActive(false);
                    player5MoveText.gameObject.SetActive(false);
                    player6MoveText.gameObject.SetActive(false);
                }
                else
                {
                    player1MoveText.gameObject.SetActive(false);
                    player2MoveText.gameObject.SetActive(false);
                    player3MoveText.gameObject.SetActive(true);
                    player4MoveText.gameObject.SetActive(false);
                    player5MoveText.gameObject.SetActive(false);
                    player6MoveText.gameObject.SetActive(false);
                }
                break;

            case 3:
                if (numofPlayers == 3)
                {
                    player1MoveText.gameObject.SetActive(true);
                    player2MoveText.gameObject.SetActive(false);
                    player3MoveText.gameObject.SetActive(false);
                    player4MoveText.gameObject.SetActive(false);
                    player5MoveText.gameObject.SetActive(false);
                    player6MoveText.gameObject.SetActive(false);
                }
                else
                {
                    player1MoveText.gameObject.SetActive(false);
                    player2MoveText.gameObject.SetActive(false);
                    player3MoveText.gameObject.SetActive(false);
                    player4MoveText.gameObject.SetActive(true);
                    player5MoveText.gameObject.SetActive(false);
                    player6MoveText.gameObject.SetActive(false);
                }
                break;

            case 4:
                if (numofPlayers == 4)
                {
                    player1MoveText.gameObject.SetActive(true);
                    player2MoveText.gameObject.SetActive(false);
                    player3MoveText.gameObject.SetActive(false);
                    player4MoveText.gameObject.SetActive(false);
                    player5MoveText.gameObject.SetActive(false);
                    player6MoveText.gameObject.SetActive(false);
                }
                else
                {
                    player1MoveText.gameObject.SetActive(false);
                    player2MoveText.gameObject.SetActive(false);
                    player3MoveText.gameObject.SetActive(false);
                    player4MoveText.gameObject.SetActive(false);
                    player5MoveText.gameObject.SetActive(true);
                    player6MoveText.gameObject.SetActive(false);
                }
                break;
            case 5:
                if (numofPlayers == 5)
                {
                    player1MoveText.gameObject.SetActive(true);
                    player2MoveText.gameObject.SetActive(false);
                    player3MoveText.gameObject.SetActive(false);
                    player4MoveText.gameObject.SetActive(false);
                    player5MoveText.gameObject.SetActive(false);
                    player6MoveText.gameObject.SetActive(false);
                }
                else
                {
                    player1MoveText.gameObject.SetActive(false);
                    player2MoveText.gameObject.SetActive(false);
                    player3MoveText.gameObject.SetActive(false);
                    player4MoveText.gameObject.SetActive(false);
                    player5MoveText.gameObject.SetActive(false);
                    player6MoveText.gameObject.SetActive(true);
                }
                break;
            case 6:
                if (numofPlayers == 6)
                {
                    player1MoveText.gameObject.SetActive(true);
                    player2MoveText.gameObject.SetActive(false);
                    player3MoveText.gameObject.SetActive(false);
                    player4MoveText.gameObject.SetActive(false);
                    player5MoveText.gameObject.SetActive(false);
                    player6MoveText.gameObject.SetActive(false);
                }
                // else
                    // player7MoveText.gameObject.SetActive(true);
                break;
        }
    }



    public static void MovePlayer(int playerToMove)
    {
        switch (playerToMove)
        {
            case 1:
                player1.GetComponent<FollowThePath>().moveAllowed = true;
                break;

            case 2:
                player2.GetComponent<FollowThePath>().moveAllowed = true;
                break;
            case 3:
                player3.GetComponent<FollowThePath>().moveAllowed = true;
                break;
            case 4:
                player4.GetComponent<FollowThePath>().moveAllowed = true;
                break;
            case 5:
                player5.GetComponent<FollowThePath>().moveAllowed = true;
                break;
            case 6:
                player6.GetComponent<FollowThePath>().moveAllowed = true;
                break;
        }
    }

    public static void ShortcutMovePlayer(int playerToMove)
    {
        switch (playerToMove)
        {
            case 1:
                player1.GetComponent<FollowThePath>().shortcutmoveAllowed = true;
                break;
            case 2:
                player2.GetComponent<FollowThePath>().shortcutmoveAllowed = true;
                break;
            case 3:
                player3.GetComponent<FollowThePath>().shortcutmoveAllowed = true;
                break;
            case 4:
                player4.GetComponent<FollowThePath>().shortcutmoveAllowed = true;
                break;
            case 5:
                player5.GetComponent<FollowThePath>().shortcutmoveAllowed = true;
                break;
            case 6:
                player6.GetComponent<FollowThePath>().shortcutmoveAllowed = true;
                break;
        }
    }


    public void ChooseRoute(int playerTakingShortcut)
    {
        switch (playerTakingShortcut)
        {
            case 1:
                P1TakeShortcutButton.gameObject.SetActive(true);
                P1DontTakeShortcutButton.gameObject.SetActive(true);
                break;
            case 2:
                P2TakeShortcutButton.gameObject.SetActive(true);
                P2DontTakeShortcutButton.gameObject.SetActive(true);
                break;
            case 3:
                P3TakeShortcutButton.gameObject.SetActive(true);
                P3DontTakeShortcutButton.gameObject.SetActive(true);
                break;
            case 4:
                P4TakeShortcutButton.gameObject.SetActive(true);
                P4DontTakeShortcutButton.gameObject.SetActive(true);
                break;
            case 5:
                P5TakeShortcutButton.gameObject.SetActive(true);
                P5DontTakeShortcutButton.gameObject.SetActive(true);
                break;
            case 6:
                P6TakeShortcutButton.gameObject.SetActive(true);
                P6DontTakeShortcutButton.gameObject.SetActive(true);
                break;

        }

    }



    public void P1takeShortcut()
    {
        // this is technically working but its moving the same amount of spaces that you roll to the shortcut tile onto the shortcut

        // player1.GetComponent<FollowThePath>().shortcutwaypointIndex = player1StartWaypoint + diceSideThrown - 4;
        player1SCStartWaypoint = player1.GetComponent<FollowThePath>().shortcutwaypointIndex;
        // player1StartWaypoint = player1.GetComponent<FollowThePath>().StartwaypointIndex;
        diceSideThrown = 0;

        player1.GetComponent<FollowThePath>().onShortcut = true;

        if (player1StartWaypoint + diceSideThrown >= 4)
        {
            player1.GetComponent<FollowThePath>().passed1stShortcut = true;
        }

        if (player1StartWaypoint + diceSideThrown >= 12)
        {
            player1.GetComponent<FollowThePath>().passed2ndShortcut = true;
        }

        if (player1StartWaypoint + diceSideThrown >= 19)
        {
            player1.GetComponent<FollowThePath>().passed3rdShortcut = true;
        }


        P1TakeShortcutButton.gameObject.SetActive(false);
        P1DontTakeShortcutButton.gameObject.SetActive(false);
        shotforshortcutTile.gameObject.SetActive(false);

        

        player1.GetComponent<FollowThePath>().shortcutmoveAllowed = true;

        NextPlayerMoveTexts(1);

        // Debug.Log("player 2 move text " + );

        // Debug.Log("P1START WAYPOINT " + player1StartWaypoint);
        // Debug.Log("SHORTCUTWAYPOINT INDEX" + player1.GetComponent<FollowThePath>().shortcutwaypointIndex);
        // Debug.Log("P1SC + DICEROLL " + player1SCStartWaypoint + diceSideThrown);

        // Debug.Log("POSITION " + player1.GetComponent<FollowThePath>().transform.position);
        // Debug.Log("IF ONSHORTCUT " + player1.GetComponent<FollowThePath>().onShortcut); // was on shortcut at this point 
        // Debug.Log("ON SHORTCUT? " + player1.GetComponent<FollowThePath>().onShortcut);



    }

    public void P1donttakeShortcut()
    {
        // player1StartWaypoint = player1.GetComponent<FollowThePath>().StartwaypointIndex - diceSideThrown;
        // diceSideThrown = 0;

        player1.GetComponent<FollowThePath>().onShortcut = false;

        if (player1StartWaypoint + diceSideThrown >= 4)
        {
            player1.GetComponent<FollowThePath>().passed1stShortcut = true;
        }

        if (player1StartWaypoint + diceSideThrown >= 12)
        {
            player1.GetComponent<FollowThePath>().passed2ndShortcut = true;

        }

        if (player1StartWaypoint + diceSideThrown >= 19)
        {
            player1.GetComponent<FollowThePath>().passed3rdShortcut = true;
        }


        player1StartWaypoint = player1.GetComponent<FollowThePath>().StartwaypointIndex - diceSideThrown;

        P1TakeShortcutButton.gameObject.SetActive(false);
        P1DontTakeShortcutButton.gameObject.SetActive(false);
        shotforshortcutTile.gameObject.SetActive(false);


        
        player1.GetComponent<FollowThePath>().moveAllowed = true;

        NextPlayerMoveTexts(1);

        // Debugs
        Debug.Log("P1WAYPOINT " + player1StartWaypoint);
        Debug.Log("DICEROLL " + diceSideThrown);
        // Debug.Log("OTHER BUTTON GETTING CLICKED");
    }






    public void P2takeshortcut()
    {
        
        player2SCStartWaypoint = player2.GetComponent<FollowThePath>().shortcutwaypointIndex;
        diceSideThrown = 0;

        player2.GetComponent<FollowThePath>().onShortcut = true;

        if (player2StartWaypoint + diceSideThrown >= 4)
        {
            player2.GetComponent<FollowThePath>().passed1stShortcut = true;
        }

        if (player2StartWaypoint + diceSideThrown >= 12)
        {
            player2.GetComponent<FollowThePath>().passed2ndShortcut = true;
        }

        if (player2StartWaypoint + diceSideThrown >= 19)
        {
            player2.GetComponent<FollowThePath>().passed3rdShortcut = true;
        }


        P2TakeShortcutButton.gameObject.SetActive(false);
        P2DontTakeShortcutButton.gameObject.SetActive(false);
        shotforshortcutTile.gameObject.SetActive(false);

        NextPlayerMoveTexts(2);

        player2.GetComponent<FollowThePath>().shortcutmoveAllowed = true;

        Debug.Log("p2 shortcut button showing ");
    }

    public void P2donttakeShortcut()
    {
        // player2StartWaypoint = player2.GetComponent<FollowThePath>().StartwaypointIndex - diceSideThrown;
        // diceSideThrown = 0;

        player2.GetComponent<FollowThePath>().onShortcut = false;

        if (player2StartWaypoint + diceSideThrown >= 4)
        {
            player2.GetComponent<FollowThePath>().passed1stShortcut = true;
        }

        if (player2StartWaypoint + diceSideThrown >= 12)
        {
            player2.GetComponent<FollowThePath>().passed2ndShortcut = true;

        }

        if (player2StartWaypoint + diceSideThrown >= 19)
        {
            player2.GetComponent<FollowThePath>().passed3rdShortcut = true;
        }

        player2StartWaypoint = player2.GetComponent<FollowThePath>().StartwaypointIndex - diceSideThrown;


        P2TakeShortcutButton.gameObject.SetActive(false);
        P2DontTakeShortcutButton.gameObject.SetActive(false);
        shotforshortcutTile.gameObject.SetActive(false);

        NextPlayerMoveTexts(2);

        player2.GetComponent<FollowThePath>().moveAllowed = true;

        Debug.Log("p2 shortcut button showing ");
    }



    public void P3takeShortcut()
    {
        
        player3SCStartWaypoint = player3.GetComponent<FollowThePath>().shortcutwaypointIndex;
        diceSideThrown = 0;

        player3.GetComponent<FollowThePath>().onShortcut = true;

        if (player3StartWaypoint + diceSideThrown >= 4)
        {
            player3.GetComponent<FollowThePath>().passed1stShortcut = true;
        }

        if (player3StartWaypoint + diceSideThrown >= 12)
        {
            player3.GetComponent<FollowThePath>().passed2ndShortcut = true;
        }

        if (player3StartWaypoint + diceSideThrown >= 19)
        {
            player3.GetComponent<FollowThePath>().passed3rdShortcut = true;
        }


        P3TakeShortcutButton.gameObject.SetActive(false);
        P3DontTakeShortcutButton.gameObject.SetActive(false);
        shotforshortcutTile.gameObject.SetActive(false);



        player3.GetComponent<FollowThePath>().shortcutmoveAllowed = true;

        NextPlayerMoveTexts(3);



    }

    public void P3donttakeShortcut()
    {
        player3StartWaypoint = player3.GetComponent<FollowThePath>().StartwaypointIndex - diceSideThrown;
        // diceSideThrown = 0;

        player3.GetComponent<FollowThePath>().onShortcut = false;

        if (player3StartWaypoint + diceSideThrown >= 4)
        {
            player3.GetComponent<FollowThePath>().passed1stShortcut = true;
        }

        if (player3StartWaypoint + diceSideThrown >= 12)
        {
            player3.GetComponent<FollowThePath>().passed2ndShortcut = true;
        }

        if (player3StartWaypoint + diceSideThrown >= 19)
        {
            player3.GetComponent<FollowThePath>().passed3rdShortcut = true;
        }




        P3TakeShortcutButton.gameObject.SetActive(false);
        P3DontTakeShortcutButton.gameObject.SetActive(false);
        shotforshortcutTile.gameObject.SetActive(false);



        player3.GetComponent<FollowThePath>().moveAllowed = true;

        NextPlayerMoveTexts(3);

        
    }



    public void P4takeShortcut()
    {
        // this is technically working but its moving the same amount of spaces that you roll to the shortcut tile onto the shortcut

        // player4.GetComponent<FollowThePath>().shortcutwaypointIndex = player4StartWaypoint + diceSideThrown - 4;
        player4SCStartWaypoint = player4.GetComponent<FollowThePath>().shortcutwaypointIndex;
        diceSideThrown = 0;

        player4.GetComponent<FollowThePath>().onShortcut = true;

        if (player4StartWaypoint + diceSideThrown >= 4)
        {
            player4.GetComponent<FollowThePath>().passed1stShortcut = true;
        }

        if (player4StartWaypoint + diceSideThrown >= 12)
        {
            player4.GetComponent<FollowThePath>().passed2ndShortcut = true;
        }

        if (player4StartWaypoint + diceSideThrown >= 19)
        {
            player4.GetComponent<FollowThePath>().passed3rdShortcut = true;
        }


        P4TakeShortcutButton.gameObject.SetActive(false);
        P4DontTakeShortcutButton.gameObject.SetActive(false);
        shotforshortcutTile.gameObject.SetActive(false);



        player4.GetComponent<FollowThePath>().shortcutmoveAllowed = true;

        NextPlayerMoveTexts(4);



    }

    public void P4donttakeShortcut()
    {
        player4StartWaypoint = player4.GetComponent<FollowThePath>().StartwaypointIndex - diceSideThrown;
        // diceSideThrown = 0;

        player4.GetComponent<FollowThePath>().onShortcut = false;

        if (player4StartWaypoint + diceSideThrown >= 4)
        {
            player4.GetComponent<FollowThePath>().passed1stShortcut = true;
        }

        if (player4StartWaypoint + diceSideThrown >= 12)
        {
            player4.GetComponent<FollowThePath>().passed2ndShortcut = true;
        }

        if (player4StartWaypoint + diceSideThrown >= 19)
        {
            player4.GetComponent<FollowThePath>().passed3rdShortcut = true;
        }




        P4TakeShortcutButton.gameObject.SetActive(false);
        P4DontTakeShortcutButton.gameObject.SetActive(false);
        shotforshortcutTile.gameObject.SetActive(false);



        player4.GetComponent<FollowThePath>().moveAllowed = true;

        NextPlayerMoveTexts(4);

        
    }

    public void P5takeShortcut()
    {
        // this is technically working but its moving the same amount of spaces that you roll to the shortcut tile onto the shortcut

        // player5.GetComponent<FollowThePath>().shortcutwaypointIndex = player5StartWaypoint + diceSideThrown - 4;
        player5SCStartWaypoint = player5.GetComponent<FollowThePath>().shortcutwaypointIndex;
        diceSideThrown = 0;

        player5.GetComponent<FollowThePath>().onShortcut = true;

        if (player5StartWaypoint + diceSideThrown >= 4)
        {
            player5.GetComponent<FollowThePath>().passed1stShortcut = true;
        }

        if (player5StartWaypoint + diceSideThrown >= 12)
        {
            player5.GetComponent<FollowThePath>().passed2ndShortcut = true;
        }

        if (player5StartWaypoint + diceSideThrown >= 19)
        {
            player5.GetComponent<FollowThePath>().passed3rdShortcut = true;
        }


        P5TakeShortcutButton.gameObject.SetActive(false);
        P5DontTakeShortcutButton.gameObject.SetActive(false);
        shotforshortcutTile.gameObject.SetActive(false);



        player5.GetComponent<FollowThePath>().shortcutmoveAllowed = true;

        NextPlayerMoveTexts(5);

    }

    public void P5donttakeShortcut()
    {
        player5StartWaypoint = player5.GetComponent<FollowThePath>().StartwaypointIndex - diceSideThrown;
        // diceSideThrown = 0;

        player5.GetComponent<FollowThePath>().onShortcut = false;

        if (player5StartWaypoint + diceSideThrown >= 4)
        {
            player5.GetComponent<FollowThePath>().passed1stShortcut = true;
        }

        if (player5StartWaypoint + diceSideThrown >= 12)
        {
            player5.GetComponent<FollowThePath>().passed2ndShortcut = true;
        }

        if (player5StartWaypoint + diceSideThrown >= 19)
        {
            player5.GetComponent<FollowThePath>().passed3rdShortcut = true;
        }




        P5TakeShortcutButton.gameObject.SetActive(false);
        P5DontTakeShortcutButton.gameObject.SetActive(false);
        shotforshortcutTile.gameObject.SetActive(false);



        player5.GetComponent<FollowThePath>().moveAllowed = true;

        NextPlayerMoveTexts(5);

        // Debugs
        // Debug.Log("P5WAYPOINT " + player5StartWaypoint);
        // Debug.Log("DICEROLL " + diceSideThrown);
        // Debug.Log("OTHER BUTTON GETTING CLICKED");
    }



    public void P6takeShortcut()
    {
        // this is technically working but its moving the same amount of spaces that you roll to the shortcut tile onto the shortcut

        // player6.GetComponent<FollowThePath>().shortcutwaypointIndex = player6StartWaypoint + diceSideThrown - 4;
        player6SCStartWaypoint = player6.GetComponent<FollowThePath>().shortcutwaypointIndex;
        diceSideThrown = 0;

        player6.GetComponent<FollowThePath>().onShortcut = true;

        if (player6StartWaypoint + diceSideThrown >= 4)
        {
            player6.GetComponent<FollowThePath>().passed1stShortcut = true;
        }

        if (player6StartWaypoint + diceSideThrown >= 12)
        {
            player6.GetComponent<FollowThePath>().passed2ndShortcut = true;
        }

        if (player6StartWaypoint + diceSideThrown >= 19)
        {
            player6.GetComponent<FollowThePath>().passed3rdShortcut = true;
        }


        P6TakeShortcutButton.gameObject.SetActive(false);
        P6DontTakeShortcutButton.gameObject.SetActive(false);
        shotforshortcutTile.gameObject.SetActive(false);



        player6.GetComponent<FollowThePath>().shortcutmoveAllowed = true;

        NextPlayerMoveTexts(6);

        
    }

    public void P6donttakeShortcut()
    {
        player6StartWaypoint = player6.GetComponent<FollowThePath>().StartwaypointIndex - diceSideThrown;
        // diceSideThrown = 0;

        player6.GetComponent<FollowThePath>().onShortcut = false;

        if (player6StartWaypoint + diceSideThrown >= 4)
        {
            player6.GetComponent<FollowThePath>().passed1stShortcut = true;
        }

        if (player6StartWaypoint + diceSideThrown >= 12)
        {
            player6.GetComponent<FollowThePath>().passed2ndShortcut = true;
        }

        if (player6StartWaypoint + diceSideThrown >= 19)
        {
            player6.GetComponent<FollowThePath>().passed3rdShortcut = true;
        }




        P6TakeShortcutButton.gameObject.SetActive(false);
        P6DontTakeShortcutButton.gameObject.SetActive(false);
        shotforshortcutTile.gameObject.SetActive(false);



        player6.GetComponent<FollowThePath>().moveAllowed = true;

        NextPlayerMoveTexts(6);

        
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
