using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnProjectile : MonoBehaviour
{
    public GameObject icePoint;
    public List<GameObject> vfx = new List<GameObject>();
    public RotateToMouse rotToMouse;


    private GameObject effectToSpawn;
    private float timeToFire = 0;




    // Start is called before the first frame update
    void Start()
    {
        effectToSpawn = vfx[0];
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
            SpawnVfx();
        }
    }

    private void SpawnVfx()
    {
        GameObject vfx;
        vfx = Instantiate(effectToSpawn, icePoint.transform.position, Quaternion.Inverse(Quaternion.identity));

    }
}
