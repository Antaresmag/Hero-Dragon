using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public static bool destobjt = false;
    public GameObject MassegePanel, baner;
    void Start()
    {

    }
    public void RestartLevel()
    {
        Hero.Health = 100;
        Dragon.Health = 100;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Fighting");
    }

    public void ContGame()
    {
        destobjt = true;
        MassegePanel.gameObject.SetActive(false);
        baner.gameObject.SetActive(true);
    }
}
