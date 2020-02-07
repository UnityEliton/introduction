using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiaMes : MonoBehaviour
{
    public Text textSaida;
    public InputField inputEntrada;
    public Button buttonGo;

    // Start is called before the first frame update
    void Start()
    {
        buttonGo.onClick.AddListener(diasDoMes);    
    }

    void diasDoMes()
    {
        switch ( inputEntrada.text )
        {
            case "janeiro":
                textSaida.text = "O mes de janeiro tem 31 dias";
                break;
            case "fevereiro":
                textSaida.text = "O mes de fevereiro tem 28 dias " + 
                                  "e no ano bixesto tem 29 dias";
                break;

            case "marco":
                textSaida.text = "O mes de marco tem 31 dias";
                break;

            case "abril":
                textSaida.text = "O mes de abril tem 30 dias";
                break;

            case "maio":
                textSaida.text = "O mes de maio tem 31 dias";
                break;

            case "junho":
                textSaida.text = "O mes de junho tem 30 dias";
                break;

            case "julho":
                textSaida.text = "O mes de julho tem 31 dias";
                break;

            case "agosto":
                textSaida.text = "O mes de agosto tem 31 dias";
                break;

            case "setembro":
                textSaida.text = "O mes de setembro tem 30 dias";
                break;

            case "outubro":
                textSaida.text = "O mes de outubro tem 31 dias";
                break;

            case "novembro":
                textSaida.text = "O mes de novembro tem 30 dias";
                break;

            case "dezembro":
                textSaida.text = "O mes de dezembro tem 31 dias";
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
