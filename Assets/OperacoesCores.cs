using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OperacoesCores : MonoBehaviour
{
    public InputField inputEntrada;
    public Button buttonGo;
    public Image imagem;
    public Image imagem2;
    // Start is called before the first frame update
    void Start()
    {
        buttonGo.onClick.AddListener(operacoes);
    }

    void operacoes()
    {
        float dadoDeEntrada = float.Parse(inputEntrada.text);
        bool variavelBooleana;

        if (dadoDeEntrada == 1)
        {
            imagem.color = new Color( 255, 255 , 255 , 100);
        }
        else if (dadoDeEntrada >= 2)
        {
            imagem.color = Color.cyan;
        }
        else
        {
            imagem.color = Color.black;
        }

        if (dadoDeEntrada > 1)
        {
            imagem2.color = Color.blue;
        }
        else if (dadoDeEntrada <= 3)
        {
            imagem2.color = Color.magenta;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
