﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereBuffer : MonoBehaviour {

  public GameObject prefab;

  public StablePointCloud SPC;
  public int maxSpheres;
  public GameObject[] spheres;

  private int shownSphere = 0;
  private int currentSphere = 0;


	// Use this for initialization
	void Start () {

    spheres = new GameObject[maxSpheres];

    for( int i = 0; i < maxSpheres; i++ ){
      spheres[i] = Instantiate( prefab );
    }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


  public void SetSphere( Vector3 position ){

    spheres[ currentSphere ].transform.position = position;
    spheres[ currentSphere ].GetComponent<ConnectToClosest>().SetClosest( SPC.GetFull() );

    currentSphere ++;
    currentSphere %= maxSpheres;

  }



}
