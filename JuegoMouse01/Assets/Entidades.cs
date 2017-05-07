using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entidades : MonoBehaviour
{
    public GameObject enemy01;
    GameObject[] enemys01;
    ActivarDesactivar[] info01;
    public GameObject enemy02;
    GameObject[] enemys02;
    ActivarDesactivar[] info02;
    public GameObject enemy03;
    GameObject[] enemys03;
    ActivarDesactivar[] info03;
    int timer;
    Vector3 nuevaPos;

    void Awake()
    {
        enemys01 = new GameObject[20];
        enemys02 = new GameObject[10];
        enemys03 = new GameObject[5];
        info01 = new ActivarDesactivar[enemys01.Length];
        info02 = new ActivarDesactivar[enemys02.Length];
        info03 = new ActivarDesactivar[enemys03.Length];
        timer = 0;
        nuevaPos = Vector3.zero;

        Crear(enemys01, enemy01, info01);
        Crear(enemys02, enemy02, info02);
        Crear(enemys03, enemy03, info03);
    }
    void Update()
    {
        timer++;
        print(timer);
        switch (timer)
        {
            case 1:
                Spawn(enemys01, info01, 0.25f);
                break;
            case 700:
                Spawn(enemys02, info02, 0.50f);
                break;
            case 1400:
                Spawn(enemys03, info03, 1f);
                break;
        }
    }
    void Crear(GameObject[] objts, GameObject objt, ActivarDesactivar[] info)
    {
        for (int i = 0; i < objts.Length; i++)
        {
            objts[i] = Instantiate(objt, Vector3.zero, Quaternion.identity);
            info[i] = objts[i].GetComponent<ActivarDesactivar>();
            info[i].Desactivarse();
        }
    }
    void Spawn(GameObject[] objts, ActivarDesactivar[] info, float nuevaY)
    {
        for(int i = 0; i < objts.Length; i++)
        {
            switch(Random.Range(0, 3))
            {
                case 0:
                    nuevaPos.x = -5;
                    nuevaPos.z = Random.Range(-5, 5);
                    nuevaPos.y = nuevaY;
                    objts[i].transform.position = nuevaPos;
                    break;
                case 1:
                    nuevaPos.x = 5;
                    nuevaPos.z = Random.Range(-5, 5);
                    nuevaPos.y = nuevaY;
                    objts[i].transform.position = nuevaPos;
                    break;
                case 2:
                    nuevaPos.x = Random.Range(-5, 5);
                    nuevaPos.z = -5;
                    nuevaPos.y = nuevaY;
                    objts[i].transform.position = nuevaPos;
                    break;
                case 3:
                    nuevaPos.x = Random.Range(-5, 5);
                    nuevaPos.z = 5;
                    nuevaPos.y = nuevaY;
                    objts[i].transform.position = nuevaPos;
                    break;
            }
            info[i].Activar();
        }
    }
}
