using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{   
    public GameObject meteorPrefab;

    public float minX, maxX, minY, maxY;

    public float time;
    public float waitTime;

    void Update()
    {     
        if (waitTime <= 0)
        {
            if (StageManager.stageNumber == 1)
            {
                Vector3 randomSpawnPosition = new Vector3(Random.Range(minX, maxX), -20.92f, -1f);
                Instantiate(meteorPrefab, randomSpawnPosition, Quaternion.identity);
                waitTime = time;
            }

            if (StageManager.stageNumber == 2)
            {
                Vector3 randomSpawnPosition = new Vector3(Random.Range(minX, maxX), -12.71f, -1f);
                Instantiate(meteorPrefab, randomSpawnPosition, Quaternion.identity);
                waitTime = time;
            }

            if (StageManager.stageNumber == 3)
            {
                Vector3 randomSpawnPosition = new Vector3(Random.Range(minX, maxX), -4.5f, -1f);
                Instantiate(meteorPrefab, randomSpawnPosition, Quaternion.identity);
                waitTime = time;
            }

            if (StageManager.stageNumber == 4)
            {
                Vector3 randomSpawnPosition = new Vector3(Random.Range(minX, maxX), 3.71f, -1f);
                Instantiate(meteorPrefab, randomSpawnPosition, Quaternion.identity);
                waitTime = time;
            }

            if (StageManager.stageNumber == 5)
            {
                Vector3 randomSpawnPosition = new Vector3(Random.Range(minX, maxX), 11.91f, -1f);
                Instantiate(meteorPrefab, randomSpawnPosition, Quaternion.identity);
                waitTime = time;
            }


        }     

        else
        {
            waitTime -= Time.deltaTime;
        }
    }

    /*IEnumerator jsafasfsa()
    {
        Vector3 randomSpawnPosition = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), -1f);
        Instantiate(bombEffectPrefab, randomSpawnPosition, Quaternion.identity);
        yield return new WaitForSeconds(3f);
        Instantiate(cubePrefab, randomSpawnPosition, Quaternion.identity);
    }*/
}

