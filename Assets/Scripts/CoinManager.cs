using UnityEngine;

public class CoinManager : MonoBehaviour
{
    public int coin;

    //public GameObject[] buttons;

    void Start()
    {
        //PlayerPrefs.SetFloat("Coin", 0);
        coin = PlayerPrefs.GetInt("coin");
    }

    
    void Update()
    {      
         PlayerPrefs.SetInt("coin", coin);           
    }

    
}
