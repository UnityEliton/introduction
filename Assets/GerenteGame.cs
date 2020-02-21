using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerenteGame : MonoBehaviour
{
    public List<GameObject> listObj = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void RemoveItem(GameObject im)
    {
        listObj.Remove(im);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
