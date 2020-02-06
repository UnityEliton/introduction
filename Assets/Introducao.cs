using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Introducao : MonoBehaviour
{
	private int soma;
	public int numero1;
	public int numero2;
    // Start is called before the first frame update
    void Start()
    {
    	soma = numero1 + numero2;
    	print("A soma de " + numero1 + " mais " 
    		+ numero2 + " eh:");
    	print(soma);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
