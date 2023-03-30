using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelChoose : MonoBehaviour
{
    public GameObject secondLvlButton;
    public GameObject thirdLvlButton;



    void Update()
    {
        if (PlayerPrefs.GetString("finishLevel1") == ("Yes"))
        {
            //secondLvlButton.GetComponent<Image>().color = new Color(255f,255f,255f,255f);
            secondLvlButton.GetComponent<Button>().interactable = true;
        }

        if (PlayerPrefs.GetString("finishLevel2") == ("Yes"))
        {
            thirdLvlButton.GetComponent<Button>().interactable = true;
        }
    }
}
