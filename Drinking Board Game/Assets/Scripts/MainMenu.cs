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
        if (NewGameControl.numofPlayers >= 2)
        {
            NewGameControl.numofPlayers -= 1;
            
        }
        playersText.text = NewGameControl.numofPlayers.ToString();

        // Debug.Log("numofplayers " + GameControl.numofPlayers);
    }

    public void RightArrowButton()
    {
        if (NewGameControl.numofPlayers <= 5)
        {
            NewGameControl.numofPlayers += 1;

        }
        playersText.text = NewGameControl.numofPlayers.ToString();

        // Debug.Log("numofplayers " + GameControl.numofPlayers);
    }
}
