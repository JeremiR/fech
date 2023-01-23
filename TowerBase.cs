using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TowerBase : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    public GameObject towerGhost;
    public GameObject towerPrefab;
    Menager menager;

    public void OnPointerClick(PointerEventData eventData)
    {
        Instantiate(towerPrefab, transform.position, transform.rotation);
        towerGhost.SetActive(false);
        GetComponent<MeshCollider>().enabled = false;
        Time.timeScale = 1;
        menager.panelPlaceTurret.SetActive(false);
        menager.turretMenager.UnregisterTurret(this);
        menager.turretMenager.DeactivateAllBases();

    }

    public void OnPointerEnter(PointerEventData eventData)
    { 
        towerGhost.SetActive(true);
        //Debug.Log("Myszka nad obiektem.");
    }
               
    public void OnPointerExit(PointerEventData eventData)
    {
        towerGhost.SetActive(false);
        //Debug.Log("Myszka poza obiektem.");
    }

    // Start is called before the first frame update
    void Start()
    {
        menager = GameObject.FindObjectOfType<Menager>();
        if (menager == null)
        {
            Debug.LogError("Nie znaleziono obiektu Menager.");
        }
        menager.turretMenager.RegisterTurret(this); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
