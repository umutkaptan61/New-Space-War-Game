using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerShipChoose : MonoBehaviour
{
    [SerializeField] private GameObject selectShipPanel;
    [SerializeField] private GameObject playerShipSpawnPoints;    

    //public List<GameObject> fireButtons;

    public List<GameObject> playerShipPrefabs;

    public bool ýsOpened;
    


    void Start()
    {
        selectShipPanel.SetActive(true);

        ýsOpened = false;             
    }

    
    void Update()
    {
        
    }   

    public void ActiveEt(int index2)
    {
        if (index2 == 1 && ýsOpened == false)
        {
            //fireButtons[0].SetActive(true);
            playerShipPrefabs[0].transform.position = playerShipSpawnPoints.transform.position;
            playerShipPrefabs[0].SetActive(true);
            selectShipPanel.SetActive(false);
            ýsOpened = true;
        }

        else if (index2 == 2 && ýsOpened == false)
        {
            //fireButtons[1].SetActive(true);
            playerShipPrefabs[1].transform.position = playerShipSpawnPoints.transform.position;
            playerShipPrefabs[1].SetActive(true);           
            selectShipPanel.SetActive(false);
            ýsOpened = true;
        }

        else if (index2 == 3 && ýsOpened == false)
        {
            //fireButtons[2].SetActive(true);
            playerShipPrefabs[2].transform.position = playerShipSpawnPoints.transform.position;
            playerShipPrefabs[2].SetActive(true);
            selectShipPanel.SetActive(false);
            ýsOpened = true;
        }

        if (index2 == 4 && ýsOpened == false)
        {
            //fireButtons[3].SetActive(true);
            playerShipPrefabs[3].transform.position = playerShipSpawnPoints.transform.position;
            playerShipPrefabs[3].SetActive(true);
            selectShipPanel.SetActive(false);
            ýsOpened = true;
        }
    }
}
