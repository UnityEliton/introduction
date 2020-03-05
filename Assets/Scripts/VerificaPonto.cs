using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VerificaPonto : MonoBehaviour
{
    public InputField inputFieldX;
    public InputField inputFieldY;
    public Button buttonverifique;
    public Text textResposta;
    // Start is called before the first frame update
    void Start()
    {
        buttonverifique.onClick.
            AddListener(VerifiqueOPonto);
    }

    void VerifiqueOPonto()
    {
        float meuX = 1;
        float meuY = 1;
        float x = float.Parse(inputFieldX.text);
        float y = float.Parse(inputFieldY.text);
        string resposta;
        //verifica x
        if(x < meuX)
        {
        resposta = "Está a esquerda de X";
        }
        else if (x == meuX)
        {
        resposta = "Está na mesma linha de X";
        }
        else
        {
        resposta = "Está a direta de X";
        }
        // verifique y
        if (y < meuY)
        {
            resposta = resposta + 
                " e está abaixo de Y";
        }
        else if (y == meuY)
        {
            resposta = resposta + 
                " e está na mesma linha de Y";
        }
        else
        {
            resposta = resposta + 
                " e está acima de Y";
        }
        bool varBool = x == meuX && y == meuY;
        if (varBool)
            resposta = "Ele são os mesmos pontos.";


        textResposta.text = resposta;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
