using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class р : MonoBehaviour
{
    public Text BallaText;
    public string q;
    public GameObject stone;
        public int Balli = 0;
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
        BallaText.text = Balli.ToString();
       
        if (i == 1)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Balli += 1;
                Destroy(stone);
            }
        }
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