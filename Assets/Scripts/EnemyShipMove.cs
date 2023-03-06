using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShipMove : MonoBehaviour
{
    public int enemyShipType;
        
    [SerializeField] private Transform enemyBulletSpawnPoints;
    [SerializeField] private Transform enemyBulletSpawnPoints2;
    [SerializeField] public GameObject enemyBulletObjectPrefab;
    [SerializeField] public float enemyBulletSpeed;

    public Transform movePoints;
    
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    public float move_Speed;

    public float startTime;
    public float waitTime;

    public float fireWaitTime;
    public float startFireTime;
    
      

    void Start()
    {
        movePoints.position = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
    }

    
    void Update()
    {
        EnemyShipMovement();
        EnemyShipFireManager();
    }


    private void EnemyShipMovement()
    {
        transform.position = Vector2.MoveTowards(transform.position, movePoints.position, move_Speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, movePoints.position) < 0.2f)
        {
            if (waitTime <= 0)
            {
                movePoints.position = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
                waitTime = startTime;
            }

            else
            {
                waitTime -= Time.deltaTime;            
            }
        }
    }


    private void EnemyShipFireManager()
    {
        if (enemyShipType == 1)
        {
            if (fireWaitTime <= 0)
            {
                GameObject newEnemyBullet = Instantiate(enemyBulletObjectPrefab, enemyBulletSpawnPoints.transform.position, Quaternion.identity);
                newEnemyBullet.GetComponent<Rigidbody2D>().AddForce(Vector3.down * enemyBulletSpeed);

                GameObject newEnemyBullet2 = Instantiate(enemyBulletObjectPrefab, enemyBulletSpawnPoints2.transform.position, Quaternion.identity);
                newEnemyBullet2.GetComponent<Rigidbody2D>().AddForce(Vector3.down * enemyBulletSpeed);

                Destroy(newEnemyBullet, 2f);
                Destroy(newEnemyBullet2, 2f);
                fireWaitTime = startFireTime;
            }

            else
            {
                fireWaitTime -= Time.deltaTime;
            }
        }


        if (enemyShipType == 2)
        {
            if (fireWaitTime <= 0)
            {
                GameObject newEnemyBullet = Instantiate(enemyBulletObjectPrefab, enemyBulletSpawnPoints.transform.position, Quaternion.identity);
                newEnemyBullet.GetComponent<Rigidbody2D>().AddForce(Vector3.down * enemyBulletSpeed);            

                Destroy(newEnemyBullet, 2f);
                
                fireWaitTime = startFireTime;
            }

            else
            {
                fireWaitTime -= Time.deltaTime;
            }
        }


        if (enemyShipType == 3)
        {
            if (fireWaitTime <= 0)
            {
                GameObject newEnemyBullet = Instantiate(enemyBulletObjectPrefab, enemyBulletSpawnPoints.transform.position, Quaternion.identity);
                newEnemyBullet.GetComponent<Rigidbody2D>().AddForce(Vector3.down * enemyBulletSpeed);

                GameObject newEnemyBullet2 = Instantiate(enemyBulletObjectPrefab, enemyBulletSpawnPoints2.transform.position, Quaternion.identity);
                newEnemyBullet2.GetComponent<Rigidbody2D>().AddForce(Vector3.down * enemyBulletSpeed);

                Destroy(newEnemyBullet, 2f);
                Destroy(newEnemyBullet2, 2f);
                fireWaitTime = startFireTime;
            }

            else
            {
                fireWaitTime -= Time.deltaTime;
            }
        }


        if (enemyShipType == 4)
        {
            if (fireWaitTime <= 0)
            {
                GameObject newEnemyBullet = Instantiate(enemyBulletObjectPrefab, enemyBulletSpawnPoints.transform.position, Quaternion.identity);
                newEnemyBullet.GetComponent<Rigidbody2D>().AddForce(Vector3.down * enemyBulletSpeed);

                GameObject newEnemyBullet2 = Instantiate(enemyBulletObjectPrefab, enemyBulletSpawnPoints2.transform.position, Quaternion.identity);
                newEnemyBullet2.GetComponent<Rigidbody2D>().AddForce(Vector3.down * enemyBulletSpeed);

                Destroy(newEnemyBullet, 2f);
                Destroy(newEnemyBullet2, 2f);
                fireWaitTime = startFireTime;
            }

            else
            {
                fireWaitTime -= Time.deltaTime;
            }
        }


        if (enemyShipType == 5)
        {
            if (fireWaitTime <= 0)
            {
                GameObject newEnemyBullet = Instantiate(enemyBulletObjectPrefab, enemyBulletSpawnPoints.transform.position, Quaternion.identity);
                newEnemyBullet.GetComponent<Rigidbody2D>().AddForce(Vector3.down * enemyBulletSpeed);

                GameObject newEnemyBullet2 = Instantiate(enemyBulletObjectPrefab, enemyBulletSpawnPoints2.transform.position, Quaternion.identity);
                newEnemyBullet2.GetComponent<Rigidbody2D>().AddForce(Vector3.down * enemyBulletSpeed);

                Destroy(newEnemyBullet, 2f);
                Destroy(newEnemyBullet2, 2f);
                fireWaitTime = startFireTime;
            }

            else
            {
                fireWaitTime -= Time.deltaTime;
            }
        }
    }



    
}
