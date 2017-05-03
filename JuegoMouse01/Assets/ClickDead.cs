using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDead : MonoBehaviour {
    EnemyVida enemyVida;
    void Awake()
    {
        enemyVida = GetComponent<EnemyVida>();
    }
    void OnMouseDown()
    {
        enemyVida.RestarVida(1);
    }
}
