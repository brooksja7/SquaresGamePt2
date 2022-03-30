using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Game_Setup()
    {
        SceneManager.LoadScene("Game_Setup");
    }
    public void main()
    {
        SceneManager.LoadScene("Main_Menu");
    }

    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void GAME()
    {
        SceneManager.LoadScene("Game");
    }
    public void Pause()
    {
        SceneManager.LoadScene("Pause");
    }
}
