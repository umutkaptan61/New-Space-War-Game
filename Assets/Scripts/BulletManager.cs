using System.Collections;
using UnityEngine;

public class BulletManager : MonoBehaviour
{     
    //[SerializeField] private GameObject bombEffect;

    //public float damage;

    EnemyShipHealth enemyShipHealth;

    //public GameObject smallExplosion;

    private void Start()
    {
        enemyShipHealth = FindObjectOfType<EnemyShipHealth>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {     
        if (collision.gameObject.CompareTag("EnemyShip"))
        {
            /*GameObject newEffect = Instantiate(bombEffect, transform.position, Quaternion.identity);
            Destroy(newEffect, 0.5f);*/

            //smallExplosion = ObjectPoolExpolisionEffect.instance.GetPooledObject();
            //smallExplosion.transform.position = transform.position;
            //smallExplosion.SetActive(true);
            
            

            //enemyShipHealth.enemyHealth--;
            //Destroy(gameObject);
            gameObject.SetActive(false);
            
            //smallExplosion.SetActive(false);
        }

        if (collision.gameObject.CompareTag("Stage1End"))
        {
            //Destroy(gameObject);
            gameObject.SetActive(false);
        }
    }  

   
}

