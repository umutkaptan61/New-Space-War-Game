using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolEmbersEffect : MonoBehaviour
{
    public static ObjectPoolEmbersEffect instance;

    private List<GameObject> pooledObjects = new List<GameObject>();
    private int amountToPool = 30;

    [SerializeField] private GameObject embersEffectPrefab;

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
            GameObject obj = Instantiate(embersEffectPrefab);
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
