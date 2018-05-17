﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpone : MonoBehaviour {
    public GameObject rock;
    public GameObject bigrock;
    public GameObject naiagara;
    public GameObject largeblock;
    Vector3 vec;
    public GameObject spon;
	// Use this for initialization
	void Start () {
        InvokeRepeating("Spone", 0.1f, 0.03f);
        InvokeRepeating("BigSpone", 0.1f, 0.04f);
        InvokeRepeating("LargeSpone", 0.1f, 15f);
        Invoke("N", 10f);
    }

	
	// Update is called once per frame
	void Update () {

	}
    void Spone()
    {
        Instantiate(rock,new Vector3(-20+40*Random.value, -20+40 * Random.value,spon.transform.position.z-10),Quaternion.identity);
       
    }
    void BigSpone()
    {
        Instantiate(bigrock, new Vector3(-20 + 40 * Random.value, -20 + 40 * Random.value, spon.transform.position.z-10), Quaternion.identity);
    }
    void N()
    {
        InvokeRepeating("Naiagara", 0.1f, 0.1f);
    }
    void Naiagara()
    {
        Instantiate(naiagara, new Vector3(-10 + 20 * Random.value, -10 + 20 * Random.value, spon.transform.position.z - 5), Quaternion.identity);
    }
    void LargeSpone()
    {
        Instantiate(largeblock, new Vector3(-10 + 20 * Random.value, -10 + 20 * Random.value, spon.transform.position.z - 5), Quaternion.identity);
    }
}
