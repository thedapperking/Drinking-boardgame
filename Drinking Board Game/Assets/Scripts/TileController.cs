using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileController : MonoBehaviour
{
    // public NewGameControl newGameControl;
    
    public GameObject clicktocontinueText;
    
    public int timer;
    public float x, y, z;

    public GameObject tileBack;     // Back of tiles are the descriptions that pop up
    public bool tileBackisactive;   // If the tileback is showing 

    public bool showTileAllowed;



    public void Start()
    {
        //tileBackisactive = false;
        //showTileAllowed = false;
    }

    public void Update()
    {
        if (showTileAllowed == true)
        {
            tileBack.gameObject.SetActive(true);
            clicktocontinueText.gameObject.SetActive(true);
            // StartFlip();
        }
    }

    public void OnMouseDown()
    {
        // tile.gameObject.SetActive(false); // instead of just making tile disappear after you click make it flip back over into the tile >> this will be called "backTiles[].gameObject"
        clicktocontinueText.gameObject.SetActive(false);
        tileBack.gameObject.SetActive(false);
        // showTileAllowed = false;
        // StartFlip();
    }


    //// Adds flip animation 

    //public void Flip()
    //{
        
    //    if (tileBackisactive == true)
    //    {
    //        tileBack.gameObject.SetActive(false);
    //        tileBackisactive = false;
    //        showtileAllowed = false;
    //    }
    //    else
    //    {
    //        tileBack.gameObject.SetActive(true);
    //        tileBackisactive = true;
    //        showtileAllowed = false;
    //    }
    //}

    //public void StartFlip()
    //{
    //    StartCoroutine(CalculateFlip());
    //}

    //IEnumerator CalculateFlip()
    //{
    //    for (int i = 0; i < 180; i++)
    //    {
    //        yield return new WaitForSeconds(0.01f);
    //        transform.Rotate(new Vector3(x, y, z));

    //        if (timer == 90 || timer == -90)
    //        {
    //            Flip();
    //        }
    //    }

    //    timer = 0;
    //}




}
