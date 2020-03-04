using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vetor : MonoBehaviour
{
    public InputField inputFieldValor;
    public InputField inputFieldIndice;
    public Button botaoGo;
    public Text texto;
    int[] vetorInteiros = new int[4];
    // int variavel;
    // Start is called before the first frame update
    void Start()
    {
        botaoGo.onClick.AddListener(modificaVetor);
    }

    void modificaVetor()
    {
        int indice = int.Parse(inputFieldIndice.text);
        int valor = int.Parse(inputFieldValor.text);
        vetorInteiros[indice] = valor;
    }

    // Update is called once per frame
    void Update()
    {
        string txt = "| ";

        foreach ( var i in vetorInteiros)
        {
            txt = txt + i.ToString() + " | ";
        }
        texto.text = txt;
    }
}
