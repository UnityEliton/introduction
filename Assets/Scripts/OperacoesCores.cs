using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OperacoesCores : MonoBehaviour
{
    public InputField inputEntrada;
    public InputField inputEntradaX;
    public InputField inputEntradaY;
    public Button buttonGo;
    public Button buttonAnd;
    public Button buttonOr;
    public Image imagem;
    public Image imagem2;
    // Start is called before the first frame update
    void Start()
    {
        //buttonGo.onClick.AddListener(operacoes);
        buttonAnd.onClick.AddListener(tabelaAnd);
        buttonOr.onClick.AddListener(tabelaOr);
    }

    void tabelaAnd()
    {
        bool varBoolX;
        bool varBoolY;
        if (inputEntradaX.text == "true")
        {   varBoolX = true;  }
        else{  varBoolX = false;  }
        if (inputEntradaY.text == "true")
        {   varBoolY = true;   }
        else{  varBoolY = false;   }
        if (varBoolX && varBoolY)
        {   imagem.color = Color.green;
            imagem2.color = Color.green;
        } else{
            imagem.color = Color.red;
            imagem2.color = Color.red;
        }
    }

    void tabelaOr()
    {
        bool varBoolX;
        bool varBoolY;
        if (inputEntradaX.text == "true")
        { varBoolX = true; }
        else { varBoolX = false; }
        if (inputEntradaY.text == "true")
        { varBoolY = true; }
        else { varBoolY = false; }

        if (varBoolX || varBoolY)
        {   imagem.color = Color.green;
            imagem2.color = Color.green;
        } else
        {   imagem.color = Color.red;
            imagem2.color = Color.red;
        }
    }

    void operacoes()    {
        float dadoDeEntrada = float.Parse(inputEntrada.text);
        
        if (dadoDeEntrada == 1){
            imagem.color = new Color( 255, 255 , 255 , 100);
        }else if (  (dadoDeEntrada >= 2) && 
                    (dadoDeEntrada > 1) ) {
            imagem.color = Color.cyan;
            imagem2.color = Color.blue;
        }else if (dadoDeEntrada <= 3)   {
            imagem2.color = Color.magenta;
        }   else  {
            imagem.color = Color.black;
        }
                
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
