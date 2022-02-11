using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shop : MonoBehaviour
{
    public Text priceDoubleClick;
    public Text priceAutoFarm;
    public Button but;

    void Start()
    {
      priceDoubleClick.text = GameObject.Find("MainCamera").GetComponent<Clicker>().double_click.ToString();
      priceAutoFarm.text = GameObject.Find("MainCamera").GetComponent<Clicker>().autofarm.ToString();

    }

    public void Interactives(int Double_click)
    {
      but.interactable = false;
    }
}
