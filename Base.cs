using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour
{
    public Menager menager;

    // Start is called before the first frame update
    void Start()
    {
        menager.ourBase = transform;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Debug.Log("Koniec gry!");
            Time.timeScale = 0;
            menager.GameOver();

        }
    }
}
