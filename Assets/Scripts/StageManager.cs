using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageManager : MonoBehaviour
{
    //EnemyShipHealth enemyShipHealth;

   // public GameObject stage1End;

    public GameObject stage1Back;

    public int numberOfDeadEnemyShip;

    public Camera mainCam;

    private SpriteRenderer spriteRenderer;

    private bool colorChange = false;

    private bool stageEnd = false;

    public GameObject bulletCatcher;

    public GameObject bulletCatcher2;

    public Text stageText;



    //public bool stage1finished = false;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        bulletCatcher.SetActive(true);
        //enemyShipHealth = FindObjectOfType<EnemyShipHealth>();
        
    }


     void Update()
     {
        if (numberOfDeadEnemyShip == 1 && colorChange == false)
        {
            spriteRenderer.color = Color.green;
            //stageText.text = "STAGE 2-5";
        }

        if (numberOfDeadEnemyShip == 2 && colorChange == true)
        {
            spriteRenderer.color = Color.green;
        }

        if (numberOfDeadEnemyShip == 3 && colorChange == false)
        {
            spriteRenderer.color = Color.green;
        }

        if (numberOfDeadEnemyShip == 4 && colorChange == true)
        {
            spriteRenderer.color = Color.green;
        }

        if (numberOfDeadEnemyShip == 5 && colorChange == false)
        {
            spriteRenderer.color = Color.green;
        }



        //Debug.Log(spriteRenderer.color);

        /*if (numberOfDeadEnemyShip == 5)
        {
            stage1End.GetComponent<SpriteRenderer>().color = Color.green;
            stage1End.GetComponent<BoxCollider2D>().isTrigger = true;
        }*/
     }

    private void OnCollisionEnter2D(Collision2D collision)
    {        
        if (collision.gameObject.CompareTag("PlayerShip") && numberOfDeadEnemyShip == 1 && stageEnd == false)
        {
            stageText.text = "STAGE 2 / 5";
            mainCam.transform.position += new Vector3(0f, 8.21f, 0f);
            stage1Back.SetActive(true);
            colorChange = true;
            spriteRenderer.color = Color.red;
            transform.position += new Vector3(0f, 8.21f, 0f);
            bulletCatcher.transform.position += new Vector3(0f, 8.21f, 0f);
            bulletCatcher2.transform.position += new Vector3(0f, 8.21f, 0f);
            stageEnd = true;
        }

        if (collision.gameObject.CompareTag("PlayerShip") && numberOfDeadEnemyShip == 2 && stageEnd == true)
        {
            stageText.text = "STAGE 3 / 5";
            mainCam.transform.position += new Vector3(0f, 8.21f, 0f);
            stage1Back.transform.position += new Vector3(0f, 8.21f, 0f);
            colorChange = false;
            spriteRenderer.color = Color.red;
            transform.position += new Vector3(0f, 8.21f, 0f);
            bulletCatcher.transform.position += new Vector3(0f, 8.21f, 0f);
            bulletCatcher2.transform.position += new Vector3(0f, 8.21f, 0f);
            stageEnd = false;
        }

        if (collision.gameObject.CompareTag("PlayerShip") && numberOfDeadEnemyShip == 3 && stageEnd == false)
        {
            stageText.text = "STAGE 4 / 5";
            mainCam.transform.position += new Vector3(0f, 8.21f, 0f);
            stage1Back.transform.position += new Vector3(0f, 8.21f, 0f);
            colorChange = true;
            spriteRenderer.color = Color.red;
            transform.position += new Vector3(0f, 8.21f, 0f);
            bulletCatcher.transform.position += new Vector3(0f, 8.21f, 0f);
            bulletCatcher2.transform.position += new Vector3(0f, 8.21f, 0f);
            stageEnd = true;
        }

        if (collision.gameObject.CompareTag("PlayerShip") && numberOfDeadEnemyShip == 4 && stageEnd == true)
        {
            stageText.text = "STAGE 5 / 5";
            mainCam.transform.position += new Vector3(0f, 8.21f, 0f);
            stage1Back.transform.position += new Vector3(0f, 8.21f, 0f);
            colorChange = false;
            spriteRenderer.color = Color.red;
            transform.position += new Vector3(0f, 8.21f, 0f);
            bulletCatcher.transform.position += new Vector3(0f, 8.21f, 0f);
            bulletCatcher2.transform.position += new Vector3(0f, 8.21f, 0f);
            stageEnd = false;
        }

        if (collision.gameObject.CompareTag("PlayerShip") && numberOfDeadEnemyShip == 5 && stageEnd == false)
        {
            mainCam.transform.position += new Vector3(0f, 8.21f, 0f);
            stage1Back.transform.position += new Vector3(0f, 8.21f, 0f);
            colorChange = true;
            spriteRenderer.color = Color.red;
            transform.position += new Vector3(0f, 8.21f, 0f);
            bulletCatcher.transform.position += new Vector3(0f, 8.21f, 0f);
            bulletCatcher2.transform.position += new Vector3(0f, 8.21f, 0f);
            stageEnd = true;
        }
    }
        
}


