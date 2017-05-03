using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyVida : MonoBehaviour {
    private float vida;

	void Start () {
        switch (tag)
        {
            case "Enemy01":
                vida = 1;
                break;
            case "Enemy02":
                vida = 2;
                break;
            case "Enemy03":
                vida = 4;
                break;
        }
	}
    public void RestarVida(float danio)
    {
        vida -= danio;
    }
	void Update () {
        if (vida <= 0)
            gameObject.SetActive(false);
	}
}
