using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void PlayGame ()
   {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);         // old function of play button, don't use
   }



    public void QuitGame ()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

}
