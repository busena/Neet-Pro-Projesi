using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    public int sayi = 15;
    public string buse = "buse";
    //public bool sena = true;
    public List<int> deneme = new List<int>();
    public Vector3 pos;
    void Start()
    {
        Debug.Log(sayi);
        //Debug.Log(sena);
        Debug.LogWarning("Burasý 2. start");
        Debug.LogError("Burasý 3. start");
    }
    void Update()
    {
        Debug.Log(sayi);
        Debug.Log("Burasý update start");
    }


}
