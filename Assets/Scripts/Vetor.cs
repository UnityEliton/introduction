using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vetor : MonoBehaviour
{
    public InputField inputFieldValor;
    public InputField inputFieldIndice;
    public Button botaoGo;
    public Text texto;
    const int tamanhoVetor = 5;
    Int32[] vetorInteiros = new int[tamanhoVetor];
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
        /*
        for (int j = 0; j < tamanhoVetor; j++)
        {
            txt = txt + vetorInteiros[j].ToString() + " | ";
        }
        */

        foreach ( var i in vetorInteiros)
        {
            txt = txt + i.ToString() + " | ";
        }
        texto.text = txt;
    }
}
