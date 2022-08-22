using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UiUpdate : MonoBehaviour
{

    public Text text;
    public Text txtPuntaje;

    // Start is called before the first frame update
    void Start()
    {
        text.text = PlayerPrefs.GetString("nombre");
        txtPuntaje.text = PlayerPrefs.GetInt("Puntaje").ToString();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
