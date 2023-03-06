using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{     
    [SerializeField] private GameObject bombEffect;

    //public float damage;

    EnemyShipHealth enemyShipHealth;

    private void Start()
    {
        enemyShipHealth = FindObjectOfType<EnemyShipHealth>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {     
        if (collision.gameObject.CompareTag("EnemyShip"))
        {
            GameObject newEffect = Instantiate(bombEffect, transform.position, Quaternion.identity);
            Destroy(newEffect, 0.5f);

            //enemyShipHealth.enemyHealth--;
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Stage1End"))
        {
            Destroy(gameObject);
        }
    }

    

}

