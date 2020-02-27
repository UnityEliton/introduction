using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gerente : MonoBehaviour
{
    public List<GameObject> listObjects = 
        new List<GameObject>();
    public int totalMosquitosMortos;
    public Text textPontos;
    // Start is called before the first frame update
    void Start()
    {
        totalMosquitosMortos = 0;
        textPontos.text = totalMosquitosMortos.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        textPontos.text = totalMosquitosMortos.ToString();
    }
}
