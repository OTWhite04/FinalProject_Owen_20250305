using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonsScript : MonoBehaviour
{

    public bool isPaused;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused == true)
            {
                PauseGame();
            }
            else if(isPaused == false)
            {
                PlayGame();
            }
        }
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Level1");
    }

    public void PauseGame()
    {
        Time.timeScale = 0.0f;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1.0f;
    }
}
