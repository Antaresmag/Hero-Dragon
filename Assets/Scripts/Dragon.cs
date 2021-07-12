using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using System.Linq.Expressions;

public class Dragon : MonoBehaviour
{
    public static int Health = 100;
    public GameObject b;
    public GameObject[] Attacks;
    public static int random;
    void Update()
    {

       

        if (Hero.motion_enemy == true)
        {
            random = Random.Range(0, Attacks.Length);
            RandomAttack();
            Debug.Log(" перевірка на хіт");
        }
       
    }

    public void RandomAttack()
    {
        b.gameObject.SetActive(false);
        Instantiate(Attacks[random], transform.position, Quaternion.identity);
        Debug.Log("Дракон обрав аттаку: " + random);
        Hero.motion_enemy = false;
    }



}
