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

    public void Story1()
    {
        SceneManager.LoadScene("Story1");
    }

    public void Story2()
    {
        SceneManager.LoadScene("Story2");
    }

    public void Maintain()
    {
        SceneManager.LoadScene("UnderMaintain");
    }
}
