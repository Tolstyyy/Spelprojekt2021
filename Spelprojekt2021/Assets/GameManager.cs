using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    // Variables    
    bool gameHasEnded = false;
    bool gameIsPaused = false;

    public GameObject Player;
    public GameObject replayMenuUI;
    public GameObject pauseMenuUI;


    // Functions
    public void GameOver ()
    {
        if (gameHasEnded == false)
        {           
            gameHasEnded = true;           
            replayMenuUI.SetActive(true);
            Destroy(pauseMenuUI);

            Debug.Log("Game Over");           
        }      
	}  

    public void PauseScreen()
    {
        if (gameIsPaused == true && gameHasEnded == false)
        {
            Time.timeScale = 0f;
        }
    }
}
