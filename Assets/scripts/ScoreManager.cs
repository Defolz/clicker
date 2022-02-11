using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text moneyText;

    public void KMBMaker()
    { 
        if(GameObject.Find("MainCamera").GetComponent<Clicker>().money < 1000)
        {
            moneyText.text = GameObject.Find("MainCamera").GetComponent<Clicker>().money.ToString() + "";;   
        }
        else if(GameObject.Find("MainCamera").GetComponent<Clicker>().money < 1000000)
        { 
            moneyText.text = (GameObject.Find("MainCamera").GetComponent<Clicker>().money/1000).ToString() + "K"; 
        }
        else if(GameObject.Find("MainCamera").GetComponent<Clicker>().money < 1000000000)
        {
            moneyText.text = (GameObject.Find("MainCamera").GetComponent<Clicker>().money/1000000).ToString() + "M"; 
        }
        else
        {
            moneyText.text = (GameObject.Find("MainCamera").GetComponent<Clicker>().money/1000000000).ToString() + "B";
        }
    }    

    void Update()
    {
    	KMBMaker();   
    }
}
