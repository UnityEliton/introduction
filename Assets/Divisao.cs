using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Divisao : MonoBehaviour
{
	public int dividendo, divisor;
	float quociente;
    // Start is called before the first frame update
    void Start()
    {
    	quociente = (float) dividendo / divisor;
     	print("A divisao de " + dividendo + 
     		" por " + divisor + " eh:");
     	print(quociente);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
