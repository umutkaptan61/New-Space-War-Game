using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool1 : MonoBehaviour
{
    public static ObjectPool1 instance;
   
    private List<GameObject> pooledObjects = new List<GameObject>();
    private int amountToPool = 10;
   

    [SerializeField] private GameObject bulletPrefab1;
    [SerializeField] private GameObject bulletPrefab2;
    [SerializeField] private GameObject bulletPrefab3;
    [SerializeField] private GameObject bulletPrefab4;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
     
    }

    void Start()
    {
        if (PlayerPrefs.GetFloat("playerShip") == 1)
        {
            for (int i = 0; i < amountToPool; i++)
            {
                GameObject obj = Instantiate(bulletPrefab1);
                obj.SetActive(false);
                pooledObjects.Add(obj);
            }
        }

        if (PlayerPrefs.GetFloat("playerShip") == 2)
        {
            for (int i = 0; i < amountToPool; i++)
            {
                GameObject obj = Instantiate(bulletPrefab2);
                obj.SetActive(false);
                pooledObjects.Add(obj);
            }
        }

        if (PlayerPrefs.GetFloat("playerShip") == 3)
        {
            for (int i = 0; i < amountToPool; i++)
            {
                GameObject obj = Instantiate(bulletPrefab3);
                obj.SetActive(false);
                pooledObjects.Add(obj);
            }
        }

        if (PlayerPrefs.GetFloat("playerShip") == 4)
        {
            for (int i = 0; i < amountToPool; i++)
            {
                GameObject obj = Instantiate(bulletPrefab4);
                obj.SetActive(false);
                pooledObjects.Add(obj);
            }
        }
    }

    
    public GameObject GetPooledObject()
    {
        for (int i = 0; i < pooledObjects.Count; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }

        return null;
    }
}
