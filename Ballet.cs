using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballet : MonoBehaviour
{
    public float speed;
    public int amountOfDamage;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            //Debug.Log("Trafiony");
            other.GetComponent<Enemy>().Damage(amountOfDamage);
            Destroy(gameObject);
        } 
    }

}
