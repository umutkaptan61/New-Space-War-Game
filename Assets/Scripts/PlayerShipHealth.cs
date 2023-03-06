using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShipHealth : MonoBehaviour
{
    public float playerHealth;

    public GameObject playerShipDestroyEffectPrefab;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("EnemyBullet"))
        {
            playerHealth -= 5f;
            if (playerHealth <= 0)
            {
                GameObject playerShipDestroyEffect = Instantiate(playerShipDestroyEffectPrefab, transform.position, Quaternion.identity);
                Destroy(playerShipDestroyEffect, 2f);
                Destroy(gameObject);
            }
        }
    }
}