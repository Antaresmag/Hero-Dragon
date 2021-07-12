using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fighting : MonoBehaviour
{

    public GameObject health_dragon, health_hero, MassegePanel, gameInfo;

    void Start()
    {
        MassegePanel.gameObject.SetActive(false);
    }


    void FixedUpdate()
    {
        health_dragon.GetComponent<Text>().text = "Hether: " + Dragon.Health.ToString();
        health_hero.GetComponent<Text>().text = "Hether: " + Hero.Health.ToString();


        if (Hero.Health <= 0 || Dragon.Health <= 0)
        {
            Debug.Log("Game over");
            if (Hero.Health <= 0)
            {
                gameInfo.GetComponent<Text>().text = "Ви Програли! ".ToString();
            }
            else if (Dragon.Health <= 0)
            {
                gameInfo.GetComponent<Text>().text = "Ви Виграли! ".ToString();
            }

        }
        else if (Hero.Health > 0 && Hero.motion_hero)
        {
            SisitemFighting();
            Debug.Log("metot vyzva");

        }
        else
        {

            Debug.Log("draw");
        }

    }

    void SisitemFighting()
    {
        if (Hero.motion_hero)
        {
            Debug.Log("Перевірка хто переміг");
            if (Hero.Stone == true && Dragon.random == 1)
            {
                Dragon.Health -= 10;
                Debug.Log("Камінь б'є Ножиці ");
            }
            if (Hero.Scissors == true && Dragon.random == 2)
            {
                Dragon.Health -= 10;
                Debug.Log("Ножиці б'ють Папір ");
            }
            if (Hero.Paper == true && Dragon.random == 0)
            {
                Dragon.Health -= 10;
                Debug.Log("Піпір б'є Камінь ");
            }

            if (Hero.Scissors == true && Dragon.random == 0)
            {
                Hero.Health -= 10;
                Debug.Log("Ножиці програють Каменю ");
            }
            if (Hero.Paper == true && Dragon.random == 1)
            {
                Hero.Health -= 10;
                Debug.Log("Папір програє Ножицям ");
            }
            if (Hero.Stone == true && Dragon.random == 2)
            {
                Hero.Health -= 10;
                Debug.Log("Камінь програє Папіру ");
            }
            else
            {
                Hero.Health -= 0;
                Dragon.Health -= 0;
                Debug.Log("Сили рівні ");
            }
            Hero.motion_hero = false;
            MassegePanel.gameObject.SetActive(true);

        }

    }
}



