using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShipMove : MonoBehaviour
{
    public int enemyShipType;
        
    [SerializeField] private Transform enemyBulletSpawnPoints;
    [SerializeField] private Transform enemyBulletSpawnPoints2;
    //[SerializeField] public GameObject enemyBulletObjectPrefab;
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
        if (enemyShipType == 1 || enemyShipType == 3 || enemyShipType == 5)
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


        if (enemyShipType == 2 || enemyShipType == 4)
        {
            transform.position = Vector2.MoveTowards(transform.position, movePoints.position, move_Speed * Time.deltaTime);

            if (Vector2.Distance(transform.position, movePoints.position) < 0.2f)
            {
                if (waitTime <= 0)
                {
                    movePoints.position = new Vector2(Random.Range(minX,maxX), Random.Range(transform.position.y,transform.position.y));
                    waitTime = startTime;
                }

                else
                {
                    waitTime -= Time.deltaTime;
                }
            }
        }

    }


    private void EnemyShipFireManager()
    {
        if (enemyShipType == 1)
        {
            GameObject enemyBullet = EnemyObjectPool1.instance.GetPooledObject();
            GameObject enemyBullet2 = EnemyObjectPool2.instance2.GetPooledObject2();

            if (fireWaitTime <= 0)
            {
                             
                    if (enemyBullet != null)
                    {
                        enemyBullet.transform.position = enemyBulletSpawnPoints.transform.position;
                        enemyBullet.SetActive(true);
                        enemyBullet.GetComponent<Rigidbody2D>().AddForce(Vector3.down * enemyBulletSpeed);

                        fireWaitTime = startFireTime;
                    }

                    if (enemyBullet2 != null)
                    {
                        enemyBullet2.transform.position = enemyBulletSpawnPoints2.transform.position;
                        enemyBullet2.SetActive(true);
                        enemyBullet2.GetComponent<Rigidbody2D>().AddForce(Vector3.down * enemyBulletSpeed);

                        fireWaitTime = startFireTime;
                    }                                               
            }

            else
            {
                fireWaitTime -= Time.deltaTime;
            }
        }


        if (enemyShipType == 2)
        {
            GameObject enemyBullet = EnemyObjectPool1.instance.GetPooledObject();

            if (fireWaitTime <= 0)
            {
                if (enemyBullet != null)
                {
                    enemyBullet.transform.position = enemyBulletSpawnPoints.transform.position;
                    enemyBullet.SetActive(true);
                    enemyBullet.GetComponent<Rigidbody2D>().AddForce(Vector3.down * enemyBulletSpeed);

                    fireWaitTime = startFireTime;
                }             
            }

            else
            {
                fireWaitTime -= Time.deltaTime;
            }
        }


        if (enemyShipType == 3)
        {
            GameObject enemyBullet = EnemyObjectPool1.instance.GetPooledObject();
            GameObject enemyBullet2 = EnemyObjectPool2.instance2.GetPooledObject2();

            if (fireWaitTime <= 0)
            {
                             
                    if (enemyBullet != null)
                    {
                        enemyBullet.transform.position = enemyBulletSpawnPoints.transform.position;
                        enemyBullet.SetActive(true);
                        enemyBullet.GetComponent<Rigidbody2D>().AddForce(Vector3.down * enemyBulletSpeed);

                        fireWaitTime = startFireTime;
                    }

                    if (enemyBullet2 != null)
                    {
                        enemyBullet2.transform.position = enemyBulletSpawnPoints2.transform.position;
                        enemyBullet2.SetActive(true);
                        enemyBullet2.GetComponent<Rigidbody2D>().AddForce(Vector3.down * enemyBulletSpeed);

                        fireWaitTime = startFireTime;
                    }                                               
            }

            else
            {
                fireWaitTime -= Time.deltaTime;
            }
        }


        if (enemyShipType == 4)
        {
            GameObject enemyBullet = EnemyObjectPool1.instance.GetPooledObject();
            GameObject enemyBullet2 = EnemyObjectPool2.instance2.GetPooledObject2();

            if (fireWaitTime <= 0)
            {

                if (enemyBullet != null)
                {
                    enemyBullet.transform.position = enemyBulletSpawnPoints.transform.position;
                    enemyBullet.SetActive(true);
                    enemyBullet.GetComponent<Rigidbody2D>().AddForce(Vector3.down * enemyBulletSpeed);

                    fireWaitTime = startFireTime;
                }

                if (enemyBullet2 != null)
                {
                    enemyBullet2.transform.position = enemyBulletSpawnPoints2.transform.position;
                    enemyBullet2.SetActive(true);
                    enemyBullet2.GetComponent<Rigidbody2D>().AddForce(Vector3.down * enemyBulletSpeed);

                    fireWaitTime = startFireTime;
                }
            }

            else
            {
                fireWaitTime -= Time.deltaTime;
            }
        }


        if (enemyShipType == 5)
        {
            GameObject enemyBullet = EnemyObjectPool1.instance.GetPooledObject();
            GameObject enemyBullet2 = EnemyObjectPool2.instance2.GetPooledObject2();

            if (fireWaitTime <= 0)
            {

                if (enemyBullet != null)
                {
                    enemyBullet.transform.position = enemyBulletSpawnPoints.transform.position;
                    enemyBullet.SetActive(true);
                    enemyBullet.GetComponent<Rigidbody2D>().AddForce(Vector3.down * enemyBulletSpeed);

                    fireWaitTime = startFireTime;
                }

                if (enemyBullet2 != null)
                {
                    enemyBullet2.transform.position = enemyBulletSpawnPoints2.transform.position;
                    enemyBullet2.SetActive(true);
                    enemyBullet2.GetComponent<Rigidbody2D>().AddForce(Vector3.down * enemyBulletSpeed);

                    fireWaitTime = startFireTime;
                }
            }

            else
            {
                fireWaitTime -= Time.deltaTime;
            }
        }
    }



    
}
