using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
	
	public GameObject GameOverCanvas;

	
    // Start is called before the first frame update
    void Start()
    {
        //hide canvas
        GameOverCanvas.SetActive(false);
        Time.timeScale = 1;

    }
	
	public void GameOver(){
        //show canvas
		GameOverCanvas.SetActive(true);
		Time.timeScale = 0;
	}

    public void Replay()
    {
        SceneManager.LoadScene(0);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
