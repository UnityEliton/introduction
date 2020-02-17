using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fatorial : MonoBehaviour
{
    public Button go;
    public Text textResultado;
    public InputField inputFat;
    // Start is called before the first frame update
    void Start()
    {
        go.onClick.AddListener(doFatorial);
    }

    void doFatorial()
    {
        // https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/builtin-types/integral-numeric-types
        ulong fatorial = ulong.Parse(inputFat.text);
        ulong indice = 1;
        ulong resultado = 1;
        while (indice <= fatorial)
        {
            resultado = indice * resultado;
            indice = indice + 1;
        }
        textResultado.text = resultado.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
