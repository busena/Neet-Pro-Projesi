using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class odevArayuz : MonoBehaviour
{
    //public GameObject InputObject;
    //public GameObject TextObject;
    public TMP_InputField inputField;
    public TMP_Text displayText; 
    public Button displayButton; 
    void Start()
    {
        displayButton.onClick.AddListener(DisplayText);
    }
    void DisplayText()
    {
        displayText.text = inputField.text;
    }

    void Update()
    {
        
    }

    //public void GetText()
    //{
    //    TMP_InputField input = InputObject.GetCompenent<TMP_InputField>();
    //    string text = input.text;

    //    TMP_Text textComp = Text.DestroyObject().GetComponent<TMP_Text>();  
    //    textComp.text = text;

    //    Debug.Log(text);
    //}
}
