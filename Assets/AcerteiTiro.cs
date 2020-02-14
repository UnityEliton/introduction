using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AcerteiTiro : MonoBehaviour
{
    public InputField iXT;
    public InputField iYT;
    public InputField iXB;
    public InputField iYB;
    public Button go;
    public InputField iXS;
    public InputField iYS;
    public Text tResposta;
    public Image imagem;


    // Start is called before the first frame update
    void Start()  
    {
        go.onClick.AddListener(verifique);
    }

    void verifique()
    {
        float xT = float.Parse(iXT.text);
        float yT = float.Parse(iYT.text);
        float xB = float.Parse(iXB.text);
        float yB = float.Parse(iYB.text);

        float xS = float.Parse(iXS.text);
        float yS = float.Parse(iYS.text);

        if (yS < yT && yS > yB && xS < xT && xS > xB)
        {
            tResposta.text = "Acertou";
            imagem.color = Color.red;
        }
        else
        {
            tResposta.text = "Errou";
            imagem.color = Color.cyan;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
