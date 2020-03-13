using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pilha : MonoBehaviour
{
    Stack<string> pilhaText = new Stack<string>();
    public Button buttonAdd;
    public Button buttonPop;
    public Button buttonPeek;
    public InputField inputString;
    public Text resultadoPilha;
    // Start is called before the first frame update
    void Start()
    {
        buttonAdd.onClick.AddListener(AddString);
        buttonPop.onClick.AddListener(RemoveString);
        buttonPeek.onClick.AddListener(PegaStringTopo);
    }

    void AddString()
    {
        pilhaText.Push(inputString.text);
    }

    void RemoveString()
    {
        string textoSaindo = pilhaText.Pop();
        print("Removido do topo da pilha: " + textoSaindo);
    }

    void PegaStringTopo()
    {
        string topo = pilhaText.Peek();
        print("Texto do topo da pilha: " + topo);
    }

    // Update is called once per frame
    void Update()
    {
        string text = "";
        foreach (string s in pilhaText.ToArray())
        {
            text = text + s + "\n";
        }
        resultadoPilha.text = text;
    }
}
