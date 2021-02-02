using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuManager : MonoBehaviour
{

    public GameObject MenuCanvas;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void StartMenu()
    {
        //show canvas
        MenuCanvas.SetActive(true);
        Time.timeScale = 0;
    }
    
    public void Replay()
    {
        SceneManager.LoadScene(0);
    }
}
