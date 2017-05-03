using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarDesactivar : MonoBehaviour {

	void Start ()
    {
		
	}

	void Update ()
    {
		
	}
    public void Desactivarse()
    {
        gameObject.SetActive(false);
    }
    public void Activar()
    {
        gameObject.SetActive(true);
    }
}
