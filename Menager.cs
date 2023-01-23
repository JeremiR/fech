using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menager : MonoBehaviour
{
    public GameObject panelStart;
    public GameObject panelGameOver;
    public GameObject panelWin;
    public GameObject panelPlaceTurret;
    public TurretMenager turretMenager;
    public Transform ourBase;

    int currentWave = 0;
    public int[] waves;
    public int counter;

    // Start is called before the first frame update
    void Start()
    {
        panelGameOver.SetActive(false);
        panelWin.SetActive(false);
        panelStart.SetActive(true);
        panelPlaceTurret.SetActive(false);
        turretMenager.DeactivateAllBases();
        Time.timeScale = 0;
    }


    public void Play()
    {
        panelStart.SetActive(false);
        panelPlaceTurret.SetActive(true);
        turretMenager.ActivateAllBases();
        //Time.timeScale = 1;
    }

    public void GameOver() 
    {
        panelGameOver.SetActive(true);
        Time.timeScale = 0;
    }

    public void WaveFimished() 
    {
        panelWin.SetActive(true);
                Time.timeScale = 0;
    }

    public void PlayNextWave() 
    {
        panelWin.SetActive(false);
        DestroyAllEnemis();
        counter = 0;
        currentWave++;
        panelPlaceTurret.SetActive(true);
        turretMenager.ActivateAllBases();
        //Time.timeScale = 1;

    }

    public void PlayAgain() 
    {
        panelGameOver.SetActive(false);
        DestroyAllEnemis();
        Time.timeScale = 1;
    }

    void DestroyAllEnemis() 
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        if (enemies.Length == 0)
        {
            return;
        }

        for (int i = 0; i < enemies.Length; i++)
        {
            Destroy(enemies[i]);
        }

    }

    public void AddEnemyToCounter()
    {
        counter++;
        IsWaveFinishet();

    }

    bool IsWaveFinishet() 
    {
        if (counter >= waves[currentWave])
        {
            Debug.Log("Fala zakoczona.");
            WaveFimished();
            return true;
        }
        return false;
    }

}
