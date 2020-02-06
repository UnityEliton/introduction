using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculadora : MonoBehaviour
{
	public InputField operando1;
	public InputField operando2;
	public Button buttonSoma;
	public Button buttonSubtrcao;
	public Button buttonMultiplicacao;
	public Button buttonDivisao;
	public Text resultado;
    // Start is called before the first frame update
    void Start()
    {
        buttonSoma.onClick.AddListener(Soma);
        buttonDivisao.onClick.AddListener(Divisao);
        buttonMultiplicacao.onClick.AddListener(Multiplicacao);
        buttonSubtrcao.onClick.AddListener(Subtracao);
    }

    void Soma(){
    	int numero1 = int.Parse(operando1.text);
    	int numero2 = int.Parse(operando2.text);
    	int res = numero1 + numero2;
    	resultado.text = res.ToString();
    }
    void Subtracao(){
    	int numero1 = int.Parse(operando1.text);
    	int numero2 = int.Parse(operando2.text);
    	int res = numero1 - numero2;
    	resultado.text = res.ToString();
    }
    void Divisao(){
    	int numero1 = int.Parse(operando1.text);
    	int numero2 = int.Parse(operando2.text);
    	int res = numero1 / numero2;
    	resultado.text = res.ToString();
    }
    void Multiplicacao(){
    	int numero1 = int.Parse(operando1.text);
    	int numero2 = int.Parse(operando2.text);
    	int res = numero1 * numero2;
    	resultado.text = res.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
