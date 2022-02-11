using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text moneyText;

    void Update()
    {
    	moneyText.text = GameObject.Find("MainCamera").GetComponent<Clicker>().money.ToString();    
    }
}
