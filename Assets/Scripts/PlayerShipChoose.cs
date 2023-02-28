using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerShipChoose : MonoBehaviour
{
    [SerializeField] private GameObject selectShipPanel;
    [SerializeField] private GameObject playerShipSpawnPoints;
    //[SerializeField] private GameObject playerShipPrefab;

    public List<GameObject> fireButtons;

    public List<GameObject> playerShipPrefabs;

    public bool acikMi;
    


    void Start()
    {
        selectShipPanel.SetActive(true);

        acikMi = false;
        
       // prefablarListesi = new List<GameObject>();
    }

    
    void Update()
    {
        
    }

   /* public void YellowShip()
    {
        //ChoseShip
    }

    public void BlueShip()
    {

    }

    public void GreenShip()
    {

    }

    public void RedShip()
    {

    }*/

    /*public void ChoseShip(int index)
    {
        if (index == 0)
        {
            GameObject newPlayerShip = Instantiate(playerShipPrefabs[0], playerShipSpawnPoints.transform.position, Quaternion.identity);           
            selectShipPanel.SetActive(false);
        }

        else if (index == 1)
        {
            GameObject newPlayerShip = Instantiate(playerShipPrefabs[1], playerShipSpawnPoints.transform.position, Quaternion.identity);
            selectShipPanel.SetActive(false);
        }

        else if (index == 2)
        {
            GameObject newPlayerShip = Instantiate(playerShipPrefabs[2], playerShipSpawnPoints.transform.position, Quaternion.identity);
            selectShipPanel.SetActive(false);
        }

        else if (index == 3)
        {
            GameObject newPlayerShip = Instantiate(playerShipPrefabs[3], playerShipSpawnPoints.transform.position, Quaternion.identity);
            selectShipPanel.SetActive(false);
        }

    }*/

    public void ActiveEt(int index2)
    {
        if (index2 == 1 && acikMi == false)
        {
            fireButtons[0].SetActive(true);
            playerShipPrefabs[0].transform.position = playerShipSpawnPoints.transform.position;
            playerShipPrefabs[0].SetActive(true);
            selectShipPanel.SetActive(false);
            acikMi = true;
        }

        else if (index2 == 2 && acikMi == false)
        {
            fireButtons[1].SetActive(true);
            playerShipPrefabs[1].transform.position = playerShipSpawnPoints.transform.position;
            playerShipPrefabs[1].SetActive(true);           
            selectShipPanel.SetActive(false);
            acikMi = true;
        }

        else if (index2 == 3 && acikMi == false)
        {
            fireButtons[2].SetActive(true);
            playerShipPrefabs[2].transform.position = playerShipSpawnPoints.transform.position;
            playerShipPrefabs[2].SetActive(true);
            selectShipPanel.SetActive(false);
            acikMi = true;
        }

        if (index2 == 4 && acikMi == false)
        {
            fireButtons[3].SetActive(true);
            playerShipPrefabs[3].transform.position = playerShipSpawnPoints.transform.position;
            playerShipPrefabs[3].SetActive(true);
            selectShipPanel.SetActive(false);
            acikMi = true;
        }
    }
}
