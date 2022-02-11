using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Clicker : MonoBehaviour
{     
    [SerializeField] public int money;
    public int income;
    public int double_click = 200;
    public int autofarm = 500;
    public int Double_click;
    public int AutoFarm;
    public AudioSource audioSource;

    void Start()
    {
        income = 1;
        money = PlayerPrefs.GetInt("money");
        Double_click = PlayerPrefs.GetInt("Double_click");
        AutoFarm = PlayerPrefs.GetInt("AutoFarm");
        if (AutoFarm == 1)
        {
            StartCoroutine(IdleFarm());   
        }
    }

    public void ButtonClick()
    {
        if (Double_click == 1)
        {
            money += income * 2;
        }
        else
        {
            money += income;
        }

        PlayerPrefs.SetInt("money", money);
        audioSource.Play();
    }

    public void BuyDoubleClick()
    {         
        if (Double_click == 0 & money >= double_click)
        {    
            money -= double_click;
            Double_click = 1; 
        }
        else if (Double_click == 1)
        {
            Double_click = 1;
        }
        else
        {
            Double_click = 0;
        }
        PlayerPrefs.SetInt("money", money);
        PlayerPrefs.SetInt("Double_click", Double_click);
    }

    public void BuyAutoFarm()
    {
        if (AutoFarm == 0 & money >= autofarm)
        {    
            money -= autofarm;
            AutoFarm = 1;
            StartCoroutine(IdleFarm()); 
        }
        else if (AutoFarm == 1)
        {
            AutoFarm = 1;
        }
        else
        {
            AutoFarm = 0;
        }
        PlayerPrefs.SetInt("money", money);
        PlayerPrefs.SetInt("AutoFarm", AutoFarm);   
    }

    IEnumerator IdleFarm()
    {
        yield return new WaitForSeconds(1);
        money++;
        PlayerPrefs.SetInt("money", money);
        StartCoroutine(IdleFarm());
    }

    void Update()
    {
        
    }
}
