using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageManager : MonoBehaviour
{
    //EnemyShipHealth enemyShipHealth;

   // public GameObject stage1End;

    public GameObject stage1Back;

    public int numberOfDeadEnemyShip;
    public List<int> numberOfDeadEnemyShips;

    public Camera mainCam;

    private SpriteRenderer spriteRenderer;

    private bool colorChange = false;

    private bool stageEnd = false;
 
    public GameObject bulletCatcher;
   
    public Text stageText;

    public GameObject stageFinishPanel;

    CoinManager coinManager;

    public Text coinText;

    public int levelNumber;

    public static int stageNumber = 1;



    //public bool stage1finished = false;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        bulletCatcher.SetActive(true);
        //enemyShipHealth = FindObjectOfType<EnemyShipHealth>();
        coinManager = FindObjectOfType<CoinManager>();
        
    }


     void Update()
     {
        if (numberOfDeadEnemyShip == numberOfDeadEnemyShips[0] && colorChange == false)
        {
            spriteRenderer.color = Color.green;
            //stageText.text = "STAGE 2-5";
        }

        if (numberOfDeadEnemyShip == numberOfDeadEnemyShips[1] && colorChange == true)
        {
            spriteRenderer.color = Color.green;
        }

        if (numberOfDeadEnemyShip == numberOfDeadEnemyShips[2] && colorChange == false)
        {
            spriteRenderer.color = Color.green;
        }

        if (numberOfDeadEnemyShip == numberOfDeadEnemyShips[3] && colorChange == true)
        {
            spriteRenderer.color = Color.green;
        }

        if (numberOfDeadEnemyShip == numberOfDeadEnemyShips[4] && colorChange == false)
        {
            spriteRenderer.color = Color.green;
        }


        coinText.text = "" + coinManager.coin;
        //Debug.Log(spriteRenderer.color);

        /*if (numberOfDeadEnemyShip == 5)
        {
            stage1End.GetComponent<SpriteRenderer>().color = Color.green;
            stage1End.GetComponent<BoxCollider2D>().isTrigger = true;
        }*/
     }

    private void OnCollisionEnter2D(Collision2D collision)
    {        
        if (collision.gameObject.CompareTag("PlayerShip") && numberOfDeadEnemyShip == numberOfDeadEnemyShips[0] && stageEnd == false)
        {
            stageNumber = 2;
            stageText.text = "STAGE 2 / 5";
            mainCam.transform.position += new Vector3(0f, 8.21f, 0f);
            stage1Back.SetActive(true);
            colorChange = true;
            spriteRenderer.color = Color.red;
            transform.position += new Vector3(0f, 8.21f, 0f);           
            bulletCatcher.transform.position += new Vector3(0f, 8.21f, 0f);           
            stageEnd = true;
        }

        if (collision.gameObject.CompareTag("PlayerShip") && numberOfDeadEnemyShip == numberOfDeadEnemyShips[1] && stageEnd == true)
        {
            stageNumber = 3;
            stageText.text = "STAGE 3 / 5";
            mainCam.transform.position += new Vector3(0f, 8.21f, 0f);
            stage1Back.transform.position += new Vector3(0f, 8.21f, 0f);
            colorChange = false;
            spriteRenderer.color = Color.red;
            transform.position += new Vector3(0f, 8.21f, 0f);           
            bulletCatcher.transform.position += new Vector3(0f, 8.21f, 0f);         
            stageEnd = false;
        }

        if (collision.gameObject.CompareTag("PlayerShip") && numberOfDeadEnemyShip == numberOfDeadEnemyShips[2] && stageEnd == false)
        {
            stageNumber = 4;
            stageText.text = "STAGE 4 / 5";
            mainCam.transform.position += new Vector3(0f, 8.21f, 0f);
            stage1Back.transform.position += new Vector3(0f, 8.21f, 0f);
            colorChange = true;
            spriteRenderer.color = Color.red;
            transform.position += new Vector3(0f, 8.21f, 0f);       
            bulletCatcher.transform.position += new Vector3(0f, 8.21f, 0f);           
            stageEnd = true;
        }

        if (collision.gameObject.CompareTag("PlayerShip") && numberOfDeadEnemyShip == numberOfDeadEnemyShips[3] && stageEnd == true)
        {
            stageNumber = 5;
            stageText.text = "STAGE 5 / 5";
            mainCam.transform.position += new Vector3(0f, 8.21f, 0f);
            stage1Back.transform.position += new Vector3(0f, 8.21f, 0f);
            colorChange = false;
            spriteRenderer.color = Color.red;
            transform.position += new Vector3(0f, 8.21f, 0f);        
            bulletCatcher.transform.position += new Vector3(0f, 8.21f, 0f);         
            stageEnd = false;
        }

        if (collision.gameObject.CompareTag("PlayerShip") && numberOfDeadEnemyShip == numberOfDeadEnemyShips[4] && stageEnd == false)
        {           
            stageFinishPanel.SetActive(true);

            if (levelNumber == 1)
            {
                PlayerPrefs.SetString("finishLevel1", "Yes");
            }

            if (levelNumber == 2)
            {
                PlayerPrefs.SetString("finishLevel2", "Yes");
            }
        }
    }
        
}


