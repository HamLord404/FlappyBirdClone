using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsticleMovement : MonoBehaviour
{

    float speed = -0.03f;

    int lifespan = 1000;
    int age = 0;



    // Start is called before the first frame update
    void Start()
    {

        int spawnGen = Random.Range(-4,4);
        this.transform.position = (this.transform.position + new Vector3(0, spawnGen, 0));
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = (this.transform.position + new Vector3(speed,0,0));
        age++;
        if (age >= lifespan)
        {
            this.gameObject.SetActive(false);
        }
    }

}
