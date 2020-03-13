using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pilha : MonoBehaviour
{
    Stack<string> pilhaText = new Stack<string>();
    public Button buttonAdd;
    // Start is called before the first frame update
    void Start()
    {
        buttonAdd.onClick.AddListener(AddString);
    }

    void AddString()
    {
        pilhaText.Push("Texto");
        pilhaText.Pop();
        pilhaText.Peek();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
