using UnityEngine;
using System.Collections;

public class EnemyShipHealth : MonoBehaviour
{
    public float enemyHealth;

    public GameObject enemyShipDestroyEffectPrefab;

    //public GameObject embersEffect;

    StageManager stageManager;

    CoinManager coinManager;

    private void Start()
    {
        stageManager = FindObjectOfType<StageManager>();

        coinManager = FindObjectOfType<CoinManager>();

        //StartCoroutine(asflasf());
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            enemyHealth -= 10f;

            GameObject embersEffect = ObjectPoolEmbersEffect.instance.GetPooledObject();
            if (embersEffect != null)
            {
                embersEffect.transform.position = collision.transform.position;
                embersEffect.SetActive(true);                
            }

        
            
            if (enemyHealth == 0)
            {               
                coinManager.coin += 100;
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
                coinManager.coin += 100;
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
                coinManager.coin += 100;
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
                coinManager.coin += 100;
                //PlayerPrefs.SetFloat("Coin", coinManager.coin);
                //PlayerPrefs.GetFloat("Coin", );
                GameObject enemyShipDestroyEffect = Instantiate(enemyShipDestroyEffectPrefab, transform.position, Quaternion.identity);
                Destroy(enemyShipDestroyEffect, 2f);
                stageManager.numberOfDeadEnemyShip++;
                Destroy(gameObject);
            }
        }

    }

    /*IEnumerator asflasf()
    {
        yield return new WaitForSeconds(0.2f);
        embersEffect.SetActive(false);
        
    }*/
}
