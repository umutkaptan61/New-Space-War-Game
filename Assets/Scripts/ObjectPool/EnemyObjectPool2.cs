using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyObjectPool2 : MonoBehaviour
{
    public static EnemyObjectPool2 instance2;

    private List<GameObject> pooledObjects2 = new List<GameObject>();
    private int amountToPool = 10;

    [SerializeField] private GameObject enemyBulletPrefab2;

    private void Awake()
    {
        if (instance2 == null)
        {
            instance2 = this;
        }
    }

    void Start()
    {
        for (int i = 0; i < amountToPool; i++)
        {
            GameObject obj = Instantiate(enemyBulletPrefab2);
            obj.SetActive(false);
            pooledObjects2.Add(obj);
        }
       
    }
    public GameObject GetPooledObject2()
    {
        for (int i = 0; i < pooledObjects2.Count; i++)
        {
            if (!pooledObjects2[i].activeInHierarchy)
            {
                return pooledObjects2[i];
            }
        }

        return null;
    }
}
