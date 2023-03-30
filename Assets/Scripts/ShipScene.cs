using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ShipScene : MonoBehaviour
{
    public GameObject selectShipPanel;

    public Text coinText;

    CoinManager coinManager;

    //public List<GameObject> buttons;

    public GameObject button2;
    public GameObject button3;
    public GameObject button4;

    public GameObject useShipButton2;
    public GameObject useShipButton3;
    public GameObject useShipButton4;

    void Start()
    {
        selectShipPanel.SetActive(false);
        coinManager = FindObjectOfType<CoinManager>();
    }

    
    void Update()
    {
        // Debug.Log(PlayerPrefs.GetFloat("playerShip"));
        coinText.text = "Coin : " + PlayerPrefs.GetInt("coin");
        BuyShipManager();
        UseShipButton();
    }


    public void ChooseShip(int index)
    {
        if (index == 1)
        {
            PlayerPrefs.SetFloat("playerShip", 1);          
        }

        if (index == 2)
        {
            PlayerPrefs.SetFloat("playerShip", 2);                     
        }

        if (index == 3)
        {
            PlayerPrefs.SetFloat("playerShip", 3);           
        }

        if (index == 4)
        {
            PlayerPrefs.SetFloat("playerShip", 4);         
        }
    }

    public void CoinManager(int shipÝndex)   //Gemi satýn alýnca para eksiltir.
    {
        if (shipÝndex == 2)
        {
            coinManager.coin -= 500;
            PlayerPrefs.SetString("buyTheShip2","Yes");
        }

        if (shipÝndex == 3)
        {
            coinManager.coin -= 1000;
            PlayerPrefs.SetString("buyTheShip3", "Yes");
        }

        if (shipÝndex == 4)
        {
            coinManager.coin -= 2000;
            PlayerPrefs.SetString("buyTheShip4", "Yes");
        }

    }


   public void PlayButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //Time.timeScale = 1f;
    }

    /*public void SelectShipPanel()
    {
        selectShipPanel.SetActive(true);
    }*/
    

    public void BuyShipManager()    //Gemi satýn alma butonlarýný düzenler.
    {       
        if (PlayerPrefs.GetInt("coin") < 500f || PlayerPrefs.GetString("buyTheShip2") == ("Yes"))
        {                   
            button2.gameObject.GetComponent<Button>().interactable = false; 
        }
  

        if (PlayerPrefs.GetInt("coin") < 1000f || PlayerPrefs.GetString("buyTheShip3") == ("Yes"))
        {          
            button3.gameObject.GetComponent<Button>().interactable = false; 
        }

        if (PlayerPrefs.GetInt("coin") < 2000f || PlayerPrefs.GetString("buyTheShip4") == ("Yes"))
        {         
            button4.gameObject.GetComponent<Button>().interactable = false; 
        }

    }

    /*public void UseShipButtonManager(int shipÝndex)   //Gemi satýn alýnca gemiyi sahiplen butonu açar.
    {
        if (shipÝndex == 2)
        {
            useShipButton2.GetComponent<Button>().interactable = true;
            //PlayerPrefs.SetString("buyTheShip2","Yes");
        }

        if (shipÝndex == 3)
        {
            useShipButton3.GetComponent<Button>().interactable = true;
        }

        if (shipÝndex == 4)
        {
            useShipButton4.GetComponent<Button>().interactable = true;
        }
    }*/

    public void UseShipButton()
    {
        if (PlayerPrefs.GetString("buyTheShip2") == ("Yes"))
        {            
            useShipButton2.GetComponent<Button>().interactable = true;
        }

        if (PlayerPrefs.GetString("buyTheShip3") == ("Yes"))
        {
            useShipButton3.GetComponent<Button>().interactable = true;
        }

        if (PlayerPrefs.GetString("buyTheShip4") == ("Yes"))
        {
            useShipButton4.GetComponent<Button>().interactable = true;
        }
    }
}
