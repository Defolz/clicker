using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class present : MonoBehaviour
{
    
    RectTransform ownRectTransform;
    //public GameObject present;
    public GameObject PresentMoney;
    public Button button;
    public GameObject Canvas;
    public int InvokeInt = 10;

	public float randX;
	public float posy;

    void Start()
    {
    	if (GameObject.Find("MainCamera").GetComponent<Clicker>().money > 1000)
    	{
    		StartCoroutine(SpawnPresent());	
    	}
    	
    	Button btn = button.GetComponent<Button>();
		btn.onClick.AddListener(Present);	
    }

    public void Present()
    {
    	GameObject.Find("MainCamera").GetComponent<Clicker>().money+=1000;
        PlayerPrefs.SetInt("money",GameObject.Find("MainCamera").GetComponent<Clicker>().money);
       	Destroy(PresentMoney);       
    }

    public void Repeat()
    {
    	StartCoroutine(SpawnPresent());	
    }

    IEnumerator SpawnPresent()
    {
    	yield return new WaitForSeconds(120);
    	randX = Random.Range(-300,300);
    	posy = 720;

    	GameObject Clone = Instantiate(PresentMoney, PresentMoney.transform.position = new Vector3(randX,posy, 0), Quaternion.identity) as GameObject;
    	Clone.transform.SetParent(Canvas.transform, false);
    	Repeat();	
    }


	
    // Update is called once per frame
      void Update()
    {
        //get the Input from Horizontal axis
        float horizontalInput = Input.GetAxis("Horizontal");
        //get the Input from Vertical axis
        float verticalInput = Input.GetAxis("Vertical");

        //update the position
        transform.position = transform.position + new Vector3(horizontalInput, verticalInput);
        if (transform.position.y < -200)
        {	
        	Destroy(PresentMoney); 	
        }
    }
}
