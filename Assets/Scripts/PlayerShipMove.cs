using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShipMove : MonoBehaviour
{
    [SerializeField] public int shipType;  

    [SerializeField] private GameObject engineFireEffect;
    [SerializeField] private GameObject engineFireEffect2;
    [SerializeField] private GameObject engineFireEffect3;

    private Rigidbody2D rb;

   // private float dirX = 0f;
    //private float dirY = 0f;
   // public float defaultMoveSpeed;

    [SerializeField] private Transform playerBulletSpawnPoints;
    [SerializeField] private Transform playerBulletSpawnPoints2;
    [SerializeField] public GameObject playerBulletObjectPrefab;
    [SerializeField] public float playerBulletSpeed;


    public float fireWaitTime;
    public float waitTime;


    public MovementJoystick movementJoystick;
    public float playerSpeed;



    //[SerializeField] private FixedJoystick joystick;
    //[SerializeField] private float _moveSpeed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       // movementJoystick = FindObjectOfType<MovementJoystick>();
        //fireWaitTime = waitTime;
    }

    private void FixedUpdate()
    {
        if (movementJoystick.joystickVec.y != 0)
        {
            rb.velocity = new Vector2(movementJoystick.joystickVec.x * playerSpeed, movementJoystick.joystickVec.y * playerSpeed);
        }

        else
        {
            rb.velocity = Vector2.zero;
        }

         //rb.velocity = new Vector2(joystick.Horizontal * _moveSpeed, joystick.Vertical * _moveSpeed);

    }
   
    void Update()
    {       
        //PlayerShipController();   

        EngineFireEffectController();

        PlayerShipFireManager();
                        
    }

    /*private void PlayerShipController()
    {
        dirX = Input.GetAxisRaw("Horizontal");
        dirY = Input.GetAxisRaw("Vertical");

        rb.velocity = new Vector2(dirX * defaultMoveSpeed, rb.velocity.y);
        rb.velocity = new Vector2(rb.velocity.x, dirY * defaultMoveSpeed);

    }*/

    private void EngineFireEffectController()
    {
        if (shipType == 1)
        {
            if (Mathf.Abs(rb.velocity.x) >= 0.001f || Mathf.Abs(rb.velocity.y) >= 0.001f)
            {
                engineFireEffect.SetActive(true);
                engineFireEffect2.SetActive(true);              
            }

            else
            {
                engineFireEffect.SetActive(false);
                engineFireEffect2.SetActive(false);                
            }
        }


        else if (shipType == 2)
        {
            if (Mathf.Abs(rb.velocity.x) >= 0.001f || Mathf.Abs(rb.velocity.y) >= 0.001f)
            {               
                engineFireEffect.SetActive(true);
            }

            else
            {              
                engineFireEffect.SetActive(false);
            }
        }

        else if (shipType == 3)
        {
            if (Mathf.Abs(rb.velocity.x) >= 0.001f || Mathf.Abs(rb.velocity.y) >= 0.001f)
            {
                engineFireEffect.SetActive(true);
                engineFireEffect2.SetActive(true);
                engineFireEffect3.SetActive(true);
            }

            else
            {
                engineFireEffect.SetActive(false);
                engineFireEffect2.SetActive(false);
                engineFireEffect3.SetActive(false);
            }
        }

        else if (shipType == 4)
        {
            if (Mathf.Abs(rb.velocity.x) >= 0.001f || Mathf.Abs(rb.velocity.y) >= 0.001f)
            {
                engineFireEffect.SetActive(true);                
            }

            else
            {
                engineFireEffect.SetActive(false);              
            }
        }
    }

    public void PlayerShipFireManager()
    {
        if (shipType == 1)
        {
            if (fireWaitTime <= 0)
            {
                GameObject newBullet = Instantiate(playerBulletObjectPrefab, playerBulletSpawnPoints.transform.position, Quaternion.identity);
                newBullet.GetComponent<Rigidbody2D>().AddForce(Vector3.up * playerBulletSpeed);                
                Destroy(newBullet, 2f);
                fireWaitTime = waitTime;
            }

            else
            {
                fireWaitTime -= Time.deltaTime;
            }
        }
       

        else if (shipType == 2)
        {
            if (fireWaitTime <= 0)
            {
                GameObject newBullet = Instantiate(playerBulletObjectPrefab, playerBulletSpawnPoints.transform.position, Quaternion.identity);
                newBullet.GetComponent<Rigidbody2D>().AddForce(Vector3.up * playerBulletSpeed);
                Destroy(newBullet, 2f);

                GameObject newBullet2 = Instantiate(playerBulletObjectPrefab, playerBulletSpawnPoints2.transform.position, Quaternion.identity);
                newBullet2.GetComponent<Rigidbody2D>().AddForce(Vector3.up * playerBulletSpeed);
                Destroy(newBullet2, 2f);
                fireWaitTime = waitTime;
            }

            else
            {
                fireWaitTime -= Time.deltaTime;
            }
        }

        else if (shipType == 3)
        {
            if (fireWaitTime <= 0)
            {
                GameObject newBullet = Instantiate(playerBulletObjectPrefab, playerBulletSpawnPoints.transform.position, Quaternion.identity);
                newBullet.GetComponent<Rigidbody2D>().AddForce(Vector3.up * playerBulletSpeed);
                Destroy(newBullet, 2f);
                fireWaitTime = waitTime;
            }

            else
            {
                fireWaitTime -= Time.deltaTime;
            }
        }

        else if (shipType == 4)
        {
            if (fireWaitTime <= 0)
            {
                GameObject newBullet = Instantiate(playerBulletObjectPrefab, playerBulletSpawnPoints.transform.position, Quaternion.identity);
                newBullet.GetComponent<Rigidbody2D>().AddForce(Vector3.up * playerBulletSpeed);
                Destroy(newBullet, 2f);

                GameObject newBullet2 = Instantiate(playerBulletObjectPrefab, playerBulletSpawnPoints2.transform.position, Quaternion.identity);
                newBullet2.GetComponent<Rigidbody2D>().AddForce(Vector3.up * playerBulletSpeed);
                Destroy(newBullet2, 2f);
                fireWaitTime = waitTime;
            }

            else
            {
                fireWaitTime -= Time.deltaTime;
            }
        }    
    }  
}
