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

        // Changes the current player when clicking on the dice 
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

        //// DICE MOVEMENT FROM NEWGAMECONTROL ////   

        newGameControl.DiceClickMove();

        coroutineAllowed = true;
    }

}
