using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bloco : MonoBehaviour
{
    public GameObject game;
    // Start is called before the first frame update
    void Start()
    {
    
    }
    //https://www.flaticon.com/free-icon/mosquito_1905068
    void OnMouseDown()
    {
        print("Aqui");
        game.GetComponent<GerenteGame>().listObj.Remove(this.gameObject);
        // this object was clicked - do something
        Destroy(this.gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
