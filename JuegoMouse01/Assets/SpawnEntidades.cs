using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEntidades : MonoBehaviour {
    GameObject enemy01;
    GameObject[] enemys01;
    ActivarDesactivar[] info01;
    GameObject enemy02;
    GameObject[] enemys02;
    ActivarDesactivar[] info02;
    GameObject enemy03;
    GameObject[] enemys03;
    ActivarDesactivar[] info03;

    void Start ()
    {
        enemys01 = new GameObject[20];
        enemys02 = new GameObject[10];
        enemys03 = new GameObject[5];
        info01 = new ActivarDesactivar[enemys01.Length];
        info02 = new ActivarDesactivar[enemys02.Length];
        info03 = new ActivarDesactivar[enemys03.Length];

        for (int i = 0; i< enemys01.Length; i++)
        {
            enemys01[i] = Instantiate(enemy01, Vector3.zero, Quaternion.identity);
            info01[i] = enemys01[1].GetComponent<ActivarDesactivar>();
            info01[i].Desactivarse();
        }
        for (int i = 0; i < enemys02.Length; i++)
        {
            enemys02[i] = Instantiate(enemy02, Vector3.zero, Quaternion.identity);
            info02[i] = enemys02[1].GetComponent<ActivarDesactivar>();
            info02[i].Desactivarse();
        }
        for (int i = 0; i < enemys03.Length; i++)
        {
            enemys03[i] = Instantiate(enemy03, Vector3.zero, Quaternion.identity);
            info03[i] = enemys03[1].GetComponent<ActivarDesactivar>();
            info03[i].Desactivarse();
        }
    }
	
	void Update ()
    {
		
	}
}
