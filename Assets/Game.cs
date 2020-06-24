using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{

    int spawnTimer = 240;
    int spawnCounter = 0;


    public Transform spawnLocation;
    public GameObject obsticle;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnCounter++;
        if (spawnCounter >= spawnTimer)
        {

            spawnObsticle();
            spawnCounter = 0;

        }
    }

    void spawnObsticle()
    {
        Instantiate(obsticle,spawnLocation.position,Quaternion.identity);
    }


}
