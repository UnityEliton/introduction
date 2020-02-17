using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fatorial : MonoBehaviour
{
    public Button go;
    public Text textResultado;
    public InputField inputFat;
    // Start is called before the first frame update
    void Start()
    {
        go.onClick.AddListener(doFatorial);
    }

    void doFatorial()
    {
        int fatorial = int.Parse(inputFat.text);
        int indice = 1;
        int resultado = 1;
        while(indice <= fatorial)
        {
            resultado = indice * resultado;
            indice = indice + 1;
        }
        textResultado.text = resultado.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
