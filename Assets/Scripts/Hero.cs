using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hero : MonoBehaviour
{
    
    public static int Health = 100;
    public static bool Stone;
    public static bool Scissors;
    public static bool Paper;
    public static bool motion_hero = false;
    public static bool motion_enemy = false;

   
    public void Stone_Attack()
    {
        Debug.Log("Камінь");
        Stone = true;
        motion_enemy = true;
        motion_hero = true;
    }
    public void Scissors_Attack()
    {
        Debug.Log("Ножиці");
        Scissors = true;
        motion_enemy = true;
        motion_hero = true;
    }
    public void Paper_Attack()
    {
        Debug.Log("Папір");
        Paper = true;
        motion_enemy = true;
        motion_hero = true;
    }
}
