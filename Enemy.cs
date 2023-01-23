using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;
    public Menager menager;

    // Start is called before the first frame update
    void Awake()
    {
        menager = GameObject.FindObjectOfType<Menager>();
        if (menager == null)
        {
            Debug.LogError("Nie znaleziono obiektu Menager.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Damage(int amountOfDamage) 
    {
        health = health - amountOfDamage;
        //Debug.Log($"Current health: {health}");
        if (health < 0)
        {
            health = 0;
            //Debug.LogWarning($"Current health: {health}");
            menager.AddEnemyToCounter();
            Destroy(gameObject);
        }

    }    



}
