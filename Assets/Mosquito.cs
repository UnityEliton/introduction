﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mosquito : MonoBehaviour
{
    public GameObject gerenteObjeto;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnMouseDown()
    {
        gerenteObjeto.GetComponent<Gerente>().
            listObjects.Remove(this.gameObject);
        gerenteObjeto.GetComponent<Gerente>().
            totalMosquitosMortos++; // total = total + 1
        Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
