using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretMenager : MonoBehaviour
{
    public List<TowerBase> turrets;

    public void RegisterTurret(TowerBase turret)
    {
        turrets.Add(turret);
    }

    public void UnregisterTurret(TowerBase turret) 
    {
        turrets.Remove(turret);
    }

    public void DeactivateAllBases() 
    {
        foreach (TowerBase item in turrets)
        {
            item.GetComponent<MeshCollider>().enabled = false;
        }
    }

    public void ActivateAllBases()
    {
        foreach (TowerBase item in turrets)
        {
            item.GetComponent<MeshCollider>().enabled = true;
        }
    }

}
