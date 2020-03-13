using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Matriz : MonoBehaviour
{
    public Button buttonInsira;
    public InputField inputValor;
    public InputField inputLinha;
    public InputField inputColuna;
    public Text textMatriz;
    int[][] matrizInteiros = new int[4][];
    // Start is called before the first frame update
    void Start()
    {
        buttonInsira.onClick.AddListener(Inserir);
        for (int i = 0; i < 4; i++) // i = i + 1;
            matrizInteiros[i] = new int[5];
    }

    void Inserir()
    {
        int valor = int.Parse(inputValor.text);
        int linha = int.Parse(inputLinha.text);
        int coluna = int.Parse(inputColuna.text);
        matrizInteiros[linha][coluna] = valor;
    }

    // Update is called once per frame
    void Update()
    {
        string txt = "| ";

        for(int L = 0; L < 4; L++)
        {
            for(int c = 0; c < 5; c++)
            {
                txt = txt + 
      matrizInteiros[L][c].ToString() + " | ";
            }
            txt = txt + "\n| ";
        }
        textMatriz.text = txt;
    }
}
