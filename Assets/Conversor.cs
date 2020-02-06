using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Conversor : MonoBehaviour
{
	public Text textSaida;
	public InputField inputEntrada;
	public InputField inputComando;
	public Button buttonGo;
	public Image imagem;

    // Start is called before the first frame update
    void Start()
    {
        buttonGo.onClick.AddListener(comandos);
    }

    void km2m(){
		float num = float.Parse(inputEntrada.text);
		float resultado = num*1000;
		textSaida.text = resultado.ToString();
    }

    float m2km(string metrosString){
    	float metros = float.Parse(metrosString); 
    	// transforma de texto para numero e coloca em metros
    	float km = metros/1000; // divide o valor de metros por 1000 e coloca em km
    	return km; // retornando o valor de km
    }

    void areacirculo()
    {
        float raio = float.Parse(inputEntrada.text);
        float area = 3.14f * raio * raio;
        textSaida.text = area.ToString();
    }

    float areacirculo1(string raioText)
    {
        float raio = float.Parse(raioText);
        float area = 3.14f * raio * raio;
        return area;
    }
    void comandos()
    {
    	if (inputComando.text == "quadrado") {
    		float num = float.Parse(inputEntrada.text);
    		float resultado = num*num;
    		textSaida.text = resultado.ToString();
		}
		else if (inputComando.text == "showmethething"){
			imagem.enabled = true;
		}
		else if( inputComando.text == "km2m" ){
			km2m();
		}
		else if( inputComando.text == "m2km" ){
			float km = m2km(inputEntrada.text);
			textSaida.text = km.ToString();
		}
        else if ( inputComando.text == "areacirculo")
        {
            float area = areacirculo1(inputEntrada.text);
            textSaida.text = area.ToString();
            // areacirculo();
            // float raio = float.Parse(inputEntrada.text);
            // float area = 3.14f * raio * raio;
            // textSaida.text = area.ToString();
        }
		else
		{
			textSaida.text = "Comando inválido";
		}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
