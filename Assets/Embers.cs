using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Embers : MonoBehaviour
{

    void Start()
    {
        
    }

    private void Update()
    {
        if (gameObject.activeInHierarchy)
        {
            StartCoroutine(EmbersEffectManager());
        }
       
    }

    IEnumerator EmbersEffectManager()
    {
        yield return new WaitForSeconds(0.4f);
        gameObject.SetActive(false);
    }
}
