using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C2F : MonoBehaviour
{
	public float f, c;
    // Start is called before the first frame update
    void Start()
    {
        c = (float) 5 * (f-32) / 9;
        print(c);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
