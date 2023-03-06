using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShipHealth : MonoBehaviour
{
    public float enemyHealth;

    public GameObject enemyShipDestroyEffectPrefab;

    

    StageManager stageManager;

    private void Start()
    {
        stageManager = FindObjectOfType<StageManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            enemyHealth -= 10f;
            if (enemyHealth == 0)
            {
                
                GameObject enemyShipDestroyEffect = Instantiate(enemyShipDestroyEffectPrefab, transform.position, Quaternion.identity);
                Destroy(enemyShipDestroyEffect, 2f);
                stageManager.numberOfDeadEnemyShip++;
                Destroy(gameObject);
            }
        }

        else if (collision.gameObject.CompareTag("Bullet2"))
        {
            enemyHealth -= 5f;
            if (enemyHealth == 0)
            {
                
                GameObject enemyShipDestroyEffect = Instantiate(enemyShipDestroyEffectPrefab, transform.position, Quaternion.identity);
                Destroy(enemyShipDestroyEffect, 2f);
                stageManager.numberOfDeadEnemyShip++;
                Destroy(gameObject);
            }
        }


        else if (collision.gameObject.CompareTag("Bullet3"))
        {
            enemyHealth -= 10f;
            if (enemyHealth == 0)
            {
               
                GameObject enemyShipDestroyEffect = Instantiate(enemyShipDestroyEffectPrefab, transform.position, Quaternion.identity);
                Destroy(enemyShipDestroyEffect, 2f);
                stageManager.numberOfDeadEnemyShip++;
                Destroy(gameObject);
            }
        }

        else if (collision.gameObject.CompareTag("Bullet4"))
        {
            enemyHealth -= 5f;
            if (enemyHealth == 0)
            {
               
                GameObject enemyShipDestroyEffect = Instantiate(enemyShipDestroyEffectPrefab, transform.position, Quaternion.identity);
                Destroy(enemyShipDestroyEffect, 2f);
                stageManager.numberOfDeadEnemyShip++;
                Destroy(gameObject);
            }
        }

    }

   
}
