using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triger : MonoBehaviour
{
    public float i = 0;
    private bool CosanieKamna = false;
    private bool CosanoeKamna = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            i = 1;
        }
        // здесь вы можете в список куда-то добавить коллайдер

    }
    void OnTriggerExit(Collider other)
    {
        if (other.name == "Player")
        {
            i = 0;
        }
        // здесь вы можете в список куда-то добавить коллайдер

    }

    
}
