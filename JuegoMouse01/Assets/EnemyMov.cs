using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMov : MonoBehaviour {
    float velEnemy;
    bool collicion;

	void Start () {
        switch (tag)
        {
            case "Enemy01":
                velEnemy = 0.25f;
                break;
            case "Enemy02":
                velEnemy = 0.60f;
                break;
            case "Enemy03":
                velEnemy = 0.10f;
                break;
        }
    }
	
	void Update () {

        print(velEnemy);

		if (transform.position != Vector3.zero && !collicion)
        {
            if (transform.position.x > 0)
                transform.Translate(-Vector3.right * Time.deltaTime * velEnemy);
            else if (transform.position.x < 0)
                transform.Translate(Vector3.right * Time.deltaTime * velEnemy);
            if (transform.position.z > 0)
                transform.Translate(-Vector3.forward * Time.deltaTime * velEnemy);
            else if (transform.position.z < 0)
                transform.Translate(Vector3.forward * Time.deltaTime * velEnemy);
        }
	}
    void OnCollisionEnter(Collision coll)
    {
        if(coll.gameObject.name == "Casa")
            collicion = true;
    }
}
