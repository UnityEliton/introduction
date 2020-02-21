using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gerente : MonoBehaviour
{
    public List<GameObject> listObjects = 
        new List<GameObject>();
    int totalMosquitos;
    public Text textPontos;
    // Start is called before the first frame update
    void Start()
    {
        totalMosquitos = listObjects.Count;
        textPontos.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        int pontos = totalMosquitos - listObjects.Count;
        textPontos.text = pontos.ToString();
    }
}
