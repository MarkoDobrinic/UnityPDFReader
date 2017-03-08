using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayText : MonoBehaviour {
       
    public Text textPDF;  

    void Awake()
    {
        //textPDF = GetComponent<Text>();
    }


	// Use this for initialization
	void Start () {
        

	}
	
	// Update is called once per frame
	void Update () {
      
	}
    public void changeText()
    {
        textPDF.text = "Loading PDF...";
    }
}
