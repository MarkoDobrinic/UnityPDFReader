using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using System;

[System.Serializable]
public class item
{
    public Texture pdfImage;
}


public class CreateScroll : MonoBehaviour {

    public GameObject sampleImage;
    public Transform contentPanel;
    public List<item> itemList;  
    

    void Start()
    {
        PopulateList();
    }

    void PopulateList()
    {
        
        foreach (var item in itemList)
        {
            GameObject newImage = Instantiate(sampleImage) as GameObject;
            SamplePdfImageScript imageScript = newImage.GetComponent<SamplePdfImageScript>();
            imageScript.samplePdfImage = item.pdfImage;

            newImage.transform.SetParent(contentPanel);
        }
    }
}
