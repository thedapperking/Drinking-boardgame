using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.Tilemaps;
using UnityEngine.Video;

public class TileController : MonoBehaviour
{
    public int timer;
    public float x, y, z;

    [SerializeField]
    private float speed = 1f;

    public Transform gameBoard;     // Grabs the transform of the gameboard so we can set the tiles position to the middle of it 
    public Vector3 middleOfGameBoard; // Use this to replace gameboard.Transform.Position so you choose the Y axis
    public GameObject tileBack;     // Back of tiles are the descriptions that pop up
    public bool tileBackisactive;   // If the tileback is showing 
    
    public Vector3 origPosition;    // Original position of the tile that this script is attached to
    public Vector3 origScale;       // Original scale of the tile that this script is attached to 
    public Vector3 scaleTile;       // The size that we want the tile to scale to when we land on it
    
    public bool moveToMiddleAllowed;
    public bool moveToOriginAllowed;

    public void Update()
    {
        if (moveToMiddleAllowed)
            MoveTileToMiddle();

        if (moveToOriginAllowed)
            MoveTileToOrigin();
    }

    public void Start()
    {
        scaleTile = new Vector3(4, 4, 0);
        origPosition = transform.position;
        origScale = transform.localScale;

        middleOfGameBoard = new Vector3(gameBoard.position.x, gameBoard.position.y, -3);
        tileBackisactive = false;
    }

    // Adds flip animation
    public void Flip()
    {
        if (tileBackisactive == true) // If the tile is already showing
        {
            tileBack.SetActive(false);
            tileBackisactive = false;

        }else    // If you are flipping over the tile for the first time 
        {
            tileBack.SetActive(true);
            tileBackisactive = true;
        }
    }

    public void MoveTileToMiddle()
    {
        if (transform.position != middleOfGameBoard || transform.localScale != scaleTile)
        {
            transform.localScale = Vector3.MoveTowards(transform.localScale, scaleTile, speed * Time.deltaTime);

            transform.position = Vector3.MoveTowards(transform.position, middleOfGameBoard, speed * Time.deltaTime);
            
            if (transform.position == middleOfGameBoard && transform.localScale == scaleTile) // && transform.localScale == scaleTile)
            {
                NewGameControl.clicktocontinueText.SetActive(true);
                moveToMiddleAllowed = false;
            }
        }
    }

    public void MoveTileToOrigin()
    {
        if (transform.position != origPosition || transform.localScale != origScale)
        {
            transform.localScale = Vector3.MoveTowards(transform.localScale, origScale, speed * Time.deltaTime);

            transform.position = Vector3.MoveTowards(transform.position, origPosition, speed * Time.deltaTime);
            
            if (transform.position == origPosition && transform.localScale == origScale)
            {
                moveToOriginAllowed = false;
            }
        }
    }

    public void StartFlip()
    {
        StartCoroutine(CalculateFlip());
    }

    IEnumerator CalculateFlip()
    {
        for (int i = 0; i < 180; i++)
        {
            yield return new WaitForSeconds(0.01f);
            transform.Rotate(new Vector3(x, y, z));
            timer++;

            if (timer == 90 || timer == -90)
            {
                Flip();
            }
        }

        timer = 0;
    }




}
