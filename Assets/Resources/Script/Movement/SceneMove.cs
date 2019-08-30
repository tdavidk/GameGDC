using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMove : MonoBehaviour
{
    public void TitleMenu()
    {
        SceneManager.LoadScene("TitleScreen");
    }

    public void LevelSelect()
    {
        SceneManager.LoadScene("LevelSelection");
    }

    public void FirstLevel()
    {
        SceneManager.LoadScene("LevelSatu");
    }

    public void SecondLevel()
    {
        SceneManager.LoadScene("LevelDua");
    }
}
