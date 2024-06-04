using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuManager : MonoBehaviour
{
    public GameObject creditos, mainMenu;

    public void irCreditos()
    {
        mainMenu.SetActive(false);
        creditos.SetActive(true);
    }

    public void irMenu()
    {
        creditos.SetActive(false);
        mainMenu.SetActive(true);
    }

    public void irJogo()
    {
        SceneManager.LoadScene(1);
    }

    public void sair()
    {
        Application.Quit();
        Debug.Log("saiu");
    }

    public void InstaMathreur()
    {
        Application.OpenURL("https://www.instagram.com/mahouku");
    }

    public void voltarMenu()
    {
        SceneManager.LoadScene(0);
    }

}
