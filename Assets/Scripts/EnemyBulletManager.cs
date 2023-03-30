using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletManager : MonoBehaviour
{
    [SerializeField] private GameObject bombEffect;

    

    void Start()
    {
        
    }

    private void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {    
          if (collision.gameObject.CompareTag("PlayerShip"))
          {
              GameObject newEffect = Instantiate(bombEffect, transform.position, Quaternion.identity);
              Destroy(newEffect, 0.5f);

              //Destroy(gameObject);
              gameObject.SetActive(false);
          }

          if (collision.gameObject.CompareTag("BulletCatcher"))
          {
              //Destroy(gameObject);
              gameObject.SetActive(false);
          }
    }
}
