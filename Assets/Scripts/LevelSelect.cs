using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public void LevelOne ()
    {
        SceneManager.LoadScene("Level01");
    }

    public void LevelTwo ()
    {
        SceneManager.LoadScene("Level02");
    }
}
