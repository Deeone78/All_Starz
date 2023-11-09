
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class meny : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ItemShop()
    {
        SceneManager.LoadScene(2);
    }

    public void Loadmenu()
    {
        SceneManager.LoadScene(0);
    }

    public void CharacterSelection()
    {
        SceneManager.LoadScene(3);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
