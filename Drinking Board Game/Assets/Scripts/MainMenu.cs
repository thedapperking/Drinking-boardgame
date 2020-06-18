using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class MainMenu : MonoBehaviour
{
    // public Text playersText;
    public TextMeshProUGUI playersText;
    
    
    
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void LeftArrowButton()
    {
        if (GameControl.numofPlayers >= 2)
        {
            GameControl.numofPlayers -= 1;
            
        }
        playersText.text = GameControl.numofPlayers.ToString();

        // Debug.Log("numofplayers " + GameControl.numofPlayers);
    }

    public void RightArrowButton()
    {
        if (GameControl.numofPlayers <= 5)
        {
            GameControl.numofPlayers += 1;

        }
        playersText.text = GameControl.numofPlayers.ToString();

        // Debug.Log("numofplayers " + GameControl.numofPlayers);
    }
}
