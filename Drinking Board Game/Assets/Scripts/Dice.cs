using System;
using System.Collections;
using UnityEngine;

public class Dice : MonoBehaviour {

    private Sprite[] diceSides;
    private SpriteRenderer rend;
    
    public NewGameControl newGameControl;

    public int diceWhosturn = 0;
    
    public bool coroutineAllowed = true;
    public static bool diceAllowed = true;

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

        if (NewGameControl.currentPlayer != NewGameControl.whosturn)
        {
            NewGameControl.currentPlayer += 1;
            NewGameControl.currentPlayer %= NewGameControl.numofPlayers;
        }
    }

    public IEnumerator RollTheDice()
    {
        coroutineAllowed = false;
        int randomDiceSide = 0;
        for (int i = 0; i <= 20; i++)   // Animate the dice to look like its rolling random numbers
        {
            randomDiceSide = UnityEngine.Random.Range(0, 4);
            rend.sprite = diceSides[randomDiceSide];
            yield return new WaitForSeconds(0.075f);
        }

        NewGameControl.diceSideThrown = randomDiceSide + 1;

        //// DICE MOVEMENT FROM NEWGAMECONTROL ////   

        newGameControl.DiceClickMove();

        coroutineAllowed = true;
    }

}
