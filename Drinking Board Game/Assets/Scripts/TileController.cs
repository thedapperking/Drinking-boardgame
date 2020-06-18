using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileController : MonoBehaviour
{
    public GameObject tile;
    public GameObject clicktocontinueText;
    
    void OnMouseDown()
    {
        tile.gameObject.SetActive(false);
        clicktocontinueText.gameObject.SetActive(false);
    }

   
}
