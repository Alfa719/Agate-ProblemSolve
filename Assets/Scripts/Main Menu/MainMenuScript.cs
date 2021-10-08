using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public GameObject MainMenu, PlayMenu;
    void Start()
    {
        MainMenu.SetActive(true);
        PlayMenu.SetActive(false);
    }
    public void PlayButton()
    {
        MainMenu.SetActive(false);
        PlayMenu.SetActive(true);
    }
    public void Level1Button()
    {
        SceneManager.LoadScene("Problem 1");
    }
    public void Level2Button()
    {
        SceneManager.LoadScene("Problem 2");
    }public void Level3Button()
    {
        SceneManager.LoadScene("Problem 3");
    }public void Level4Button()
    {
        SceneManager.LoadScene("Problem 4");
    }public void Level5Button()
    {
        SceneManager.LoadScene("Problem 5");
    }public void Level6Button()
    {
        SceneManager.LoadScene("Problem 6");
    }public void Level7Button()
    {
        SceneManager.LoadScene("Problem 7");
    }public void Level8Button()
    {
        SceneManager.LoadScene("Problem 8");
    }public void Level9Button()
    {
        SceneManager.LoadScene("Problem 9");
    }
    public void BackButton()
    {
        MainMenu.SetActive(true);
        PlayMenu.SetActive(false);
    }
    public void ExitButton()
    {
        Debug.Log("Keluar dari aplikasi");
        Application.Quit();
    }
}
