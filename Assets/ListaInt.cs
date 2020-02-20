using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListaInt : MonoBehaviour
{
    public Text textResultado;
    public Button buttonAdd;
    public InputField entradaDados;
    string texto = "Vazia";
    List<int> listaNumeros = new List<int>();
    // Start is called before the first frame update
    void Start()
    {
        buttonAdd.onClick.AddListener(addInt);
    }
    void addInt()
    {
        int num = int.Parse(entradaDados.text);
        listaNumeros.Add(num);
        print(num);
    }

    string getTexto()
    {
        texto = "";
        foreach(var num in listaNumeros)
        {
            texto = texto + num.ToString() + "\n";
        }
        return texto;
    }

    // Update is called once per frame
    void Update()
    {
        textResultado.text = getTexto();
    }
}
