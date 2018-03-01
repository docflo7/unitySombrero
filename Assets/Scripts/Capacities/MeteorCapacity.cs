﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorCapacity : MonoBehaviour, ICapacity {

    public int startingAltitude = 10;
    public int nbMeteors = 5;
    //public float impulsePower = 100;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ActivateCapacity()
    {
        MakeMeteor();
    }

    private void MakeMeteor()
    {
        Vector3[] positions = new Vector3[nbMeteors];
        GameObject obj = Resources.Load("Rock 01\\meteor") as GameObject;
        Vector3 position = transform.position;
        

        for(int loop = 0; loop < nbMeteors; loop++)
        {
            positions[loop] = new Vector3(position.x + Random.Range(-8.0f, 8.0f),
                position.y + startingAltitude + 2 * loop, 
                position.z + Random.Range(-8.0f, 8.0f));
        }

        for (int loop = 0; loop < nbMeteors; loop++)
        {
            Instantiate(obj, positions[loop], transform.rotation);
        }
    }
}
