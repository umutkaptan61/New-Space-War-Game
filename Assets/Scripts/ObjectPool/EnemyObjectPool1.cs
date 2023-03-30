using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyObjectPool1 : MonoBehaviour
{
    public static EnemyObjectPool1 instance;
   
    private List<GameObject> pooledObjects = new List<GameObject>();
    private int amountToPool = 10;
   

    [SerializeField] private GameObject enemyBulletPrefab;
    
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
     
    }

    void Start()
    {
        for (int i = 0; i < amountToPool; i++)
        {
            GameObject obj = Instantiate(enemyBulletPrefab);
            obj.SetActive(false);
            pooledObjects.Add(obj);
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
