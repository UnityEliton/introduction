using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Documentacao : MonoBehaviour
{
    public Text texto;
    // Start is called before the first frame update
    void Start()
    {
        texto.text = "Aula de documentação";
        texto.fontSize = 30;
        texto.color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
